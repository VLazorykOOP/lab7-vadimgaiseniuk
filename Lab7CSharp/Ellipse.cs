using System.Drawing;

namespace Lab7CSharp
{
	public class Ellipse : Figure
	{
		private int _width;
		private int _height;

		public Ellipse(int x, int y, Pen pen, int width, int height) : base(x, y, pen) => (_width, _height) = (width, height);

		public override void Draw(Graphics graphics)
		{
			graphics.DrawEllipse(Pen, X, Y, _width, _height);
		}
	}
}
