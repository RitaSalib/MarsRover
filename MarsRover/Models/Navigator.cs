using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Navigator : INavigator
    {
        ObservableCollection<IRover> Rovers { get; set; }
        IPlateau Plateau { get; set; }


        public Navigator()
        {
            Rovers = new ObservableCollection<IRover>();
        }

        public void Start(string commands)
        {
            this.Parse(commands);
            this.PrintRover();
        }

        private void Parse(string commandString)
        {
            var commands = commandString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            this.Plateau = CreatePlateau(commands[0]);

            for (int i = 1; i < commands.Length; i+=2)
            {
                var rover = CreateRover(commands[i]);
                var movements = GetRoverMovements(commands[i+1]);
               

                rover.Land(this.Plateau);
				this.Rovers.Add(rover);

                rover.Move(movements);
            }
        }

        private IPlateau CreatePlateau(string plateauOptions)
        {
            var arguments = plateauOptions.Split(':')[1];
            var size = arguments.Split(' ');
            var width = int.Parse(size[0]);
            var height = int.Parse(size[1]);

            return new Plateau(width, height);
        }

        private IRover CreateRover(string roverOptions)
        {
            var arguments = roverOptions.Split(':');
            var name = arguments[0].Split(' ')[0];

            var options = arguments[1].Split(' ');
            int posX = int.Parse(options[0]);
            int posY = int.Parse(options[1]);
            var directionArgs = options[2][0];

            var direction = Helpers.Converter.GetDirection(directionArgs);

            var position = new Point(posX, posY);

            var rover = new Rover();
            rover.Name = name;
            rover.Position = position;
            rover.Direction = direction;
            return rover;
        }

        private IList<Movement> GetRoverMovements(string toParse)
        {
            var arguments = toParse.Split(':')[1].ToCharArray();
            var movements = arguments.Select(movement => Helpers.Converter.GetMovement(movement)).ToList();
            return movements;
        }

        private void PrintRover()
        {
            foreach(var rover in Rovers)
            {
                Console.WriteLine(rover.Name+":"+ rover.Position.X+" "+ rover.Position.Y+" "+ rover.Direction.ToString());
            }
        }

    }
}
