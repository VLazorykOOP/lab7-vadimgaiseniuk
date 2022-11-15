using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class FreehandDrawingForm : Form
    {

		public Point CurrentCursorPosition = Point.Empty;
		public bool IsMouseDown;

		public Color CurrentColor = Color.Black;
		public int CurrentCursorSize = 1;

        public FreehandDrawingForm()
        {
            InitializeComponent();

			ClearButton_Click(this, EventArgs.Empty);
        }

		private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			CurrentCursorPosition = e.Location;
			IsMouseDown = true;
		}

		private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			IsMouseDown = false;

			CurrentCursorPosition = Point.Empty;
		}

		private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (IsMouseDown == true)
			{
				if (CurrentCursorPosition != null)
				{
					if (MainPictureBox.Image == null)
					{
						Bitmap mainBitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
						MainPictureBox.Image = mainBitmap;
					}

					Graphics graphics = Graphics.FromImage(MainPictureBox.Image);

					graphics.DrawLine(new Pen(CurrentColor, CurrentCursorSize), CurrentCursorPosition, e.Location);
					graphics.SmoothingMode = SmoothingMode.AntiAlias;

					MainPictureBox.Invalidate();

					CurrentCursorPosition = e.Location;
				}
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
			MainPictureBox.Image = bitmap;
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.Clear(Color.White);
		}

		private void ChooseColor_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();

			CurrentColor = colorDialog1.Color;

			ColorPictureBox.BackColor = CurrentColor;

			Invalidate();
		}

		private void CursorSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			CurrentCursorSize = Convert.ToInt32(CursorSizeNumericUpDown.Value);
		}
	}
}
