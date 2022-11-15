using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab7CSharp
{
	public class RoundedRectangle : Figure
	{
		private int _width;
		private int _height;
		private int _roundValue;

		public RoundedRectangle(int x, int y, Pen pen, int width, int height, int roundValue) : base(x, y, pen) => (_width, _height, _roundValue) = (width, height, roundValue);

		public override void Draw(Graphics graphics)
		{
			RectangleF rectangle = new RectangleF(X, Y, _width, _height);

			GraphicsPath graphicsPath = new GraphicsPath();

			graphicsPath.AddArc(X, Y, _roundValue, _roundValue, 180, 90);
			graphicsPath.AddArc(X + _width - _roundValue, Y, _roundValue, _roundValue, 270, 90);
			graphicsPath.AddArc(X + _width - _roundValue, Y + _height - _roundValue, _roundValue, _roundValue, 0, 90);
			graphicsPath.AddArc(X, Y + _height - _roundValue, _roundValue, _roundValue, 90, 90);

			graphicsPath.CloseFigure();

			PointF[] points = graphicsPath.PathPoints;
			byte[] pathTypes = graphicsPath.PathTypes;

			graphics.DrawPath(Pen, graphicsPath);
		}
	}
}
