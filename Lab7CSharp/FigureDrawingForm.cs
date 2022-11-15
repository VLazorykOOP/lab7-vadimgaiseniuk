using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
	public partial class FigureDrawingForm : Form
	{
		Random random = new Random();

		public List<Figure> Figures;

		public Color CurrentColor = Color.Black;

		public FigureDrawingForm()
		{
			InitializeComponent();

			Figures = new List<Figure>();
		}

		private Arc AddArc()
		{
			int radius = Convert.ToInt32(ArcRadiusTextBox.Text);
			int angle = Convert.ToInt32(ArcAngleTextBox.Text);
			int x = random.Next(MainPictureBox.Width - radius);
			int y = random.Next(MainPictureBox.Height - radius);
			Arc arc = new Arc(x, y, new Pen(CurrentColor), radius, angle, angle);

			return arc;
		}

		private Sector AddSector()
		{
			int radius = Convert.ToInt32(SectorRadiusTextBox.Text);
			int angle = Convert.ToInt32(SectorAngleTextBox.Text);
			int x = random.Next(MainPictureBox.Width - radius);
			int y = random.Next(MainPictureBox.Height - radius);
			Sector sector = new Sector(x, y, new SolidBrush(CurrentColor), radius, angle, angle);

			return sector;
		}

		private Ellipse AddEllipse()
		{
			int width = Convert.ToInt32(EllipseWidthTextBox.Text);
			int height = Convert.ToInt32(EllipseHeightTextBox.Text);
			int x = random.Next(MainPictureBox.Width - width);
			int y = random.Next(MainPictureBox.Height - height);
			Ellipse ellipse = new Ellipse(x, y, new Pen(CurrentColor), width, height);

			return ellipse;
		}

		private RoundedRectangle AddRoundedRectangle()
		{
			int width = Convert.ToInt32(RoundedRectangleWidthTextBox.Text);
			int height = Convert.ToInt32(RoundedRectangleHeightTextBox.Text);
			int roundValue = Convert.ToInt32(RoundedRectangleRoundValueTextBox.Text);
			int x = random.Next(MainPictureBox.Width - width);
			int y = random.Next(MainPictureBox.Height - height);
			RoundedRectangle roundedRectangle = new RoundedRectangle(x, y, new Pen(CurrentColor), width, height, roundValue);

			return roundedRectangle;
		}

		private void AddArcButton_Click(object sender, EventArgs e)
		{
			Figures.Add(AddArc());
		}

		private void AddSectorButton_Click(object sender, EventArgs e)
		{
			Figures.Add(AddSector());
		}

		private void AddEllipseButton_Click(object sender, EventArgs e)
		{
			Figures.Add(AddEllipse());
		}

		private void AddRectangleButton_Click(object sender, EventArgs e)
		{
			Figures.Add(AddRoundedRectangle());
		}

		private void ColorButton_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();

			CurrentColor = colorDialog1.Color;

			ColorPictureBox.BackColor = CurrentColor;

			Invalidate();
		}

		private void DrawButton_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
			MainPictureBox.Image = bitmap;
			Graphics graphics = Graphics.FromImage(MainPictureBox.Image);
			graphics.Clear(Color.White);

			foreach (Figure figure in Figures)
				figure.Draw(graphics);
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
			MainPictureBox.Image = bitmap;
			Graphics graphics = Graphics.FromImage(MainPictureBox.Image);
			graphics.Clear(Color.White);

			Figures.Clear();
		}

		private void LeftButton_Click(object sender, EventArgs e)
		{
			int index = Convert.ToInt32(IndexNumericUpDown.Value);
			int step = Convert.ToInt32(StepNumericUpDown.Value);
			Figure figure = Figures[index - 1];

			figure.Move(-step, 0);

			this.DrawButton_Click(this, EventArgs.Empty);
		}

		private void RightButton_Click(object sender, EventArgs e)
		{
			int index = Convert.ToInt32(IndexNumericUpDown.Value);
			int step = Convert.ToInt32(StepNumericUpDown.Value);
			Figure figure = Figures[index - 1];

			figure.Move(step, 0);

			this.DrawButton_Click(this, EventArgs.Empty);
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			int index = Convert.ToInt32(IndexNumericUpDown.Value);
			int step = Convert.ToInt32(StepNumericUpDown.Value);
			Figure figure = Figures[index - 1];

			figure.Move(0, -step);

			this.DrawButton_Click(this, EventArgs.Empty);
		}


		private void DownButton_Click(object sender, EventArgs e)
		{
			int index = Convert.ToInt32(IndexNumericUpDown.Value);
			int step = Convert.ToInt32(StepNumericUpDown.Value);
			Figure figure = Figures[index - 1];

			figure.Move(0, step);

			this.DrawButton_Click(this, EventArgs.Empty);
		}
	}
}
