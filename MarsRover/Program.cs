using System;
using System.IO;
using MarsRover.Models;

namespace MarsRover
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //  var commandString = buildCommandString();

            var commandStringBuilder = new System.Text.StringBuilder();
            commandStringBuilder.AppendLine(Console.ReadLine());
            commandStringBuilder.AppendLine(Console.ReadLine());
            commandStringBuilder.AppendLine(Console.ReadLine());
            commandStringBuilder.AppendLine(Console.ReadLine());
            commandStringBuilder.Append(Console.ReadLine());
            var commandString = commandStringBuilder.ToString();

            var navigator = new Navigator();
            navigator.Start(commandString.ToString());

        }


        /*	private static string buildCommandString()
            {
                var commandStringBuilder = new System.Text.StringBuilder();
                commandStringBuilder.AppendLine("Plateau:5 5");
                commandStringBuilder.AppendLine("Rover1 Landing:1 2 N");
                commandStringBuilder.AppendLine("Rover1 Instructions:LMLMLMLMM");
                commandStringBuilder.AppendLine("Rover2 Landing:3 3 E");
                commandStringBuilder.Append("Rover2 Instructions:MMRMMRMRRM");
                return commandStringBuilder.ToString();
            }
        }*/
    }
}
