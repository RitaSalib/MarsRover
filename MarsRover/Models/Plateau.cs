using MarsRover.Interfaces;

namespace MarsRover.Models
{
    public class Plateau: IPlateau
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public Plateau(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool CheckPoint(Point point)
        {
            if (point.X >= 0 && point.X <= this.Width 
                && point.Y >= 0 && point.Y <= this.Height)
                return true;
            
            return false;
        }
    }
}
