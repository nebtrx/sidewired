namespace Sidewired.Core.Domain
{
    public struct Thickness
    {
        public Thickness(double uniformLength) : this()
        {
            Left = Top = Right = Bottom = uniformLength;
        }

        public Thickness(double left, double top, double right, double bottom) : this()
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public double Left { get; set; }

        public double Top { get; set; }

        public double Right { get; set; }

        public double Bottom { get; set; }
    }
}