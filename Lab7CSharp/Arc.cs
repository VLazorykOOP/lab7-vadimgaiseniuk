using System.Drawing;

namespace Lab7CSharp
{
	public class Arc : Figure
	{
		private int _radius;
		private int _startAngle;
		private int _sweepAngle;

		public Arc(int x, int y, Pen pen, int radius, int startAngle, int sweepAngle) : base(x, y, pen) => (_radius, _startAngle, _sweepAngle) = (radius, startAngle, sweepAngle);

		public override void Draw(Graphics graphics)
		{
			graphics.DrawArc(Pen, X, Y, _radius, _radius, _startAngle, _sweepAngle);
		}
	}
}
