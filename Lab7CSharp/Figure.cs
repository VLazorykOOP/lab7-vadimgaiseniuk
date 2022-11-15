using System.Drawing;

namespace Lab7CSharp
{
	public abstract class Figure
	{
		protected int X;
		protected int Y;

		public Pen Pen;
		public SolidBrush Brush;

		protected Figure(int x, int y, Pen pen) => (X, Y, Pen) = (x, y, pen);
		protected Figure(int x, int y, SolidBrush brush) => (X, Y, Brush) = (x, y, brush);

		public abstract void Draw(Graphics graphics);
		public virtual void Move(int dx, int dy)
		{
			X += dx;
			Y += dy;
		}
	}
}
