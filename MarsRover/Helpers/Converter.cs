using System;
using System.Collections.Generic;
using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Helpers
{
    public static class Converter
    {
        public static Direction GetDirection(char d)
        {
            switch (d)
            {
                case 'N':
                    return Direction.N;
                case 'E':
                    return Direction.E;
                case 'S':
                    return Direction.S;
                case 'W':
                    return Direction.W;

                default:
                    return Direction.N;
            }
        }

        public static Movement GetMovement(char m)
        {
            switch (m)
            {
                case 'L':
                    return Movement.Left;
                case 'R':
                    return Movement.Right;
                case 'M':
                    return Movement.Forward;

                default:
                    return Movement.Forward;
            }
        }
    }
}
