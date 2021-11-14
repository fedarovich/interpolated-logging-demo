namespace InterpolatedLoggingDemo
{
    public record Segment(Point Start, Point End)
    {
        public double GetLength()
        {
            var dx = Start.X - End.X;
            var dy = Start.Y - End.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
