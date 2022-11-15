using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Lab7CSharp
{
	public partial class GraphicsForm : Form
	{
		public double x = 0;

		public Timer timer = new Timer();

		public int CurrentSpeed = 5;
		public Color CurrentColor = Color.Black;
		public Pen Pen = new Pen(Color.Black);
		public Font CurrentFont = new Font("Times New Roman", 14);

		public GraphicsForm()
		{
			InitializeComponent();
		}

		public double Function(double x)
		{
			if (x == 0) return 0;

			return Math.Sin(x) / x;
		}

		public bool AnimateGraphic()
		{
			Graphics graphics = MainPictureBox.CreateGraphics();

			double yEx = MainPictureBox.Height / 2;
			double eF = 50;
			double y = Function(x);

			graphics.FillEllipse(new SolidBrush(CurrentColor), (float)(x * eF), (float)(y * eF + yEx), 3, 3);
			x += 0.05;

			return x < MainPictureBox.Width;
		}

		private void OnTimerElapsedEvent(object sender, ElapsedEventArgs args)
		{
			if (!AnimateGraphic())
			{
				timer.Enabled = false;
				timer.Stop();
			}
		}

		private void RedrawPictureBox()
		{
			x = 0;

			Bitmap bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
			MainPictureBox.Image = bitmap;
			Graphics graphics = Graphics.FromImage(MainPictureBox.Image);
			graphics.Clear(Color.White);

			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, MainPictureBox.Width, MainPictureBox.Height);

			graphics.DrawLine(Pen, new Point(0, MainPictureBox.Height / 2), new Point(MainPictureBox.Width, MainPictureBox.Height / 2));
			graphics.DrawLine(Pen, new Point(MainPictureBox.Width / 2, 0), new Point(MainPictureBox.Width / 2, MainPictureBox.Height));
			graphics.DrawString("-4", CurrentFont, new SolidBrush(Color.Black), 0, MainPictureBox.Height / 2 + 10);
			graphics.DrawString("4", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width - 30, MainPictureBox.Height / 2 + 10);
			graphics.DrawString("1", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 + 10, 10);
			graphics.DrawString("-1", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 + 10, MainPictureBox.Height - 20);
			graphics.DrawString("0", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 - 15, MainPictureBox.Height / 2 + 5);

			graphics.DrawString("y = sin(x) / x", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 4, MainPictureBox.Height / 4);
		}

		private void ChooseColorButton_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();

			CurrentColor = colorDialog1.Color;

			ColorPictureBox.BackColor = CurrentColor;

			Invalidate();
		}

		private void ChooseFontButton_Click(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();

			CurrentFont = fontDialog1.Font;
		}

		private void StartTimerButton_Click(object sender, EventArgs e)
		{
			if (timer.Enabled)
			{
				timer.Elapsed -= OnTimerElapsedEvent;
				timer.Stop();
				return;
			}

			timer.Interval = CurrentSpeed;
			timer.Elapsed += OnTimerElapsedEvent;
			timer.Start();
		}

		private void Graphics_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer.Stop();
		}

		private void MainPictureBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;

			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, MainPictureBox.Width, MainPictureBox.Height);

			graphics.DrawLine(Pen, new Point(0, MainPictureBox.Height / 2), new Point(MainPictureBox.Width, MainPictureBox.Height / 2));
			graphics.DrawLine(Pen, new Point(MainPictureBox.Width / 2, 0), new Point(MainPictureBox.Width / 2, MainPictureBox.Height));
			graphics.DrawString("-4", CurrentFont, new SolidBrush(Color.Black), 0, MainPictureBox.Height / 2 + 10);
			graphics.DrawString("4", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width - 30, MainPictureBox.Height / 2 + 10);
			graphics.DrawString("1", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 + 10, 10);
			graphics.DrawString("-1", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 + 10, MainPictureBox.Height - 20);
			graphics.DrawString("0", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 2 - 15, MainPictureBox.Height / 2 + 5);

			graphics.DrawString("y = sin(x) / x", CurrentFont, new SolidBrush(Color.Black), MainPictureBox.Width / 4, MainPictureBox.Height / 4);
		}

		private void SpeedNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			CurrentSpeed = Convert.ToInt32(SpeedNumericUpDown.Value);
		}

		private void RedrawButton_Click(object sender, EventArgs e)
		{
			timer.Elapsed -= OnTimerElapsedEvent;
			timer.Stop();
			RedrawPictureBox();
		}
	}
}
