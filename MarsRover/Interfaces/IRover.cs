using System.Collections.Generic;
using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IRover
    {
        string Name { get; set; }
        Direction Direction { get; set; }
        Point Position { get; set; }

        void Land(IPlateau plateau);
        void Move(IList<Movement> movements);
    }
}
