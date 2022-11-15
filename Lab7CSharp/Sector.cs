using System.Drawing;

namespace Lab7CSharp
{
	public class Sector : Figure
	{
		private int _radius;
		private int _startAngle;
		private int _sweepAngle;

		public Sector(int x, int y, SolidBrush brush, int radius, int startAngle, int sweepAngle) : base(x, y, brush) => (_radius, _startAngle, _sweepAngle) = (radius, startAngle, sweepAngle);

		public override void Draw(Graphics graphics)
		{
			graphics.FillPie(Brush, X, Y, _radius, _radius, _startAngle, _sweepAngle);
		}
	}
}
