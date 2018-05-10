using System;
using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IPlateau
    {
        int Width { get; set; }
        int Height { get; set; }

        bool CheckPoint(Point point);
    }
}
