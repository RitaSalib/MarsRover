using System;
using System.Collections.Generic;
using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Rover : IRover
    {
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public Point Position { get; set; }

        public void Land(IPlateau plateau)
        {
            if (!plateau.CheckPoint(Position))
            {
                throw new Exception("Position out of bounds");
            }

        }

        public void Move(IList<Movement> movements)
        {
            foreach (var movement in movements)
            {
                switch (movement)
                {
                    case Movement.Left:
                        RotateLeft();
                        break;
                    case Movement.Right:
                        RotateRight();
                        break;
                    case Movement.Forward:
                        MoveForward();
                        break;
                }

            }
        }

        private void RotateLeft()
        {
            this.Direction = (Direction - 1) < Direction.N ? Direction.W : Direction - 1;
        }

        private void RotateRight()
        {
            this.Direction = (Direction + 1) > Direction.W ? Direction.N : Direction + 1;
        }

        private void MoveForward()
        {
            if (Direction == Direction.N)
            {
                this.Position.Y++;
            }
            else if (Direction == Direction.E)
            {
                this.Position.X++;
            }
            else if (Direction == Direction.S)
            {
                this.Position.Y--;
            }
            else if (Direction == Direction.W)
            {
                this.Position.X--;
            }
        }


    }
}
