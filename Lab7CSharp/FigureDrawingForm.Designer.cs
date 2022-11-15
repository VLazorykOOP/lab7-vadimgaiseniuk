namespace Lab7CSharp
{
	partial class FigureDrawingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ClearButton = new System.Windows.Forms.Button();
			this.DrawButton = new System.Windows.Forms.Button();
			this.ColorButton = new System.Windows.Forms.Button();
			this.MainPictureBox = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.IndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.StepNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.LeftButton = new System.Windows.Forms.Button();
			this.UpButton = new System.Windows.Forms.Button();
			this.DownButton = new System.Windows.Forms.Button();
			this.RightButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.RoundedRectangleRoundValueTextBox = new System.Windows.Forms.TextBox();
			this.EllipseHeightTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.RoundedRectangleHeightTextBox = new System.Windows.Forms.TextBox();
			this.ArcAngleTextBox = new System.Windows.Forms.TextBox();
			this.SectorAngleTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.RoundedRectangleWidthTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddArcButton = new System.Windows.Forms.Button();
			this.EllipseWidthTextBox = new System.Windows.Forms.TextBox();
			this.AddEllipseButton = new System.Windows.Forms.Button();
			this.SectorRadiusTextBox = new System.Windows.Forms.TextBox();
			this.AddSectorButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.AddRectangleButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ArcRadiusTextBox = new System.Windows.Forms.TextBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.ColorPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IndexNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StepNumericUpDown)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(122, 342);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(106, 43);
			this.ClearButton.TabIndex = 35;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// DrawButton
			// 
			this.DrawButton.Location = new System.Drawing.Point(219, 293);
			this.DrawButton.Name = "DrawButton";
			this.DrawButton.Size = new System.Drawing.Size(106, 43);
			this.DrawButton.TabIndex = 34;
			this.DrawButton.Text = "Draw";
			this.DrawButton.UseVisualStyleBackColor = true;
			this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
			// 
			// ColorButton
			// 
			this.ColorButton.Location = new System.Drawing.Point(26, 293);
			this.ColorButton.Name = "ColorButton";
			this.ColorButton.Size = new System.Drawing.Size(106, 43);
			this.ColorButton.TabIndex = 33;
			this.ColorButton.Text = "Choose color";
			this.ColorButton.UseVisualStyleBackColor = true;
			this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
			// 
			// MainPictureBox
			// 
			this.MainPictureBox.BackColor = System.Drawing.Color.White;
			this.MainPictureBox.Location = new System.Drawing.Point(363, 12);
			this.MainPictureBox.Name = "MainPictureBox";
			this.MainPictureBox.Size = new System.Drawing.Size(958, 553);
			this.MainPictureBox.TabIndex = 31;
			this.MainPictureBox.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.IndexNumericUpDown);
			this.groupBox2.Controls.Add(this.StepNumericUpDown);
			this.groupBox2.Controls.Add(this.LeftButton);
			this.groupBox2.Controls.Add(this.UpButton);
			this.groupBox2.Controls.Add(this.DownButton);
			this.groupBox2.Controls.Add(this.RightButton);
			this.groupBox2.Location = new System.Drawing.Point(53, 402);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(243, 117);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Move figure";
			// 
			// IndexNumericUpDown
			// 
			this.IndexNumericUpDown.Location = new System.Drawing.Point(85, 10);
			this.IndexNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.IndexNumericUpDown.Name = "IndexNumericUpDown";
			this.IndexNumericUpDown.Size = new System.Drawing.Size(75, 20);
			this.IndexNumericUpDown.TabIndex = 11;
			this.IndexNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// StepNumericUpDown
			// 
			this.StepNumericUpDown.Location = new System.Drawing.Point(99, 62);
			this.StepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.StepNumericUpDown.Name = "StepNumericUpDown";
			this.StepNumericUpDown.Size = new System.Drawing.Size(54, 20);
			this.StepNumericUpDown.TabIndex = 10;
			this.StepNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// LeftButton
			// 
			this.LeftButton.Location = new System.Drawing.Point(4, 59);
			this.LeftButton.Name = "LeftButton";
			this.LeftButton.Size = new System.Drawing.Size(75, 23);
			this.LeftButton.TabIndex = 6;
			this.LeftButton.Text = "←";
			this.LeftButton.UseVisualStyleBackColor = true;
			this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
			// 
			// UpButton
			// 
			this.UpButton.Location = new System.Drawing.Point(85, 36);
			this.UpButton.Name = "UpButton";
			this.UpButton.Size = new System.Drawing.Size(75, 23);
			this.UpButton.TabIndex = 7;
			this.UpButton.Text = "↑";
			this.UpButton.UseVisualStyleBackColor = true;
			this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// DownButton
			// 
			this.DownButton.Location = new System.Drawing.Point(85, 88);
			this.DownButton.Name = "DownButton";
			this.DownButton.Size = new System.Drawing.Size(75, 23);
			this.DownButton.TabIndex = 8;
			this.DownButton.Text = "↓";
			this.DownButton.UseVisualStyleBackColor = true;
			this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
			// 
			// RightButton
			// 
			this.RightButton.Location = new System.Drawing.Point(166, 59);
			this.RightButton.Name = "RightButton";
			this.RightButton.Size = new System.Drawing.Size(75, 23);
			this.RightButton.TabIndex = 9;
			this.RightButton.Text = "→";
			this.RightButton.UseVisualStyleBackColor = true;
			this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.RoundedRectangleRoundValueTextBox);
			this.panel1.Controls.Add(this.EllipseHeightTextBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.RoundedRectangleHeightTextBox);
			this.panel1.Controls.Add(this.ArcAngleTextBox);
			this.panel1.Controls.Add(this.SectorAngleTextBox);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.RoundedRectangleWidthTextBox);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.AddArcButton);
			this.panel1.Controls.Add(this.EllipseWidthTextBox);
			this.panel1.Controls.Add(this.AddEllipseButton);
			this.panel1.Controls.Add(this.SectorRadiusTextBox);
			this.panel1.Controls.Add(this.AddSectorButton);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.AddRectangleButton);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ArcRadiusTextBox);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(342, 264);
			this.panel1.TabIndex = 30;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 237);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(111, 13);
			this.label9.TabIndex = 43;
			this.label9.Text = "Input the round value:";
			// 
			// RoundedRectangleRoundValueTextBox
			// 
			this.RoundedRectangleRoundValueTextBox.Location = new System.Drawing.Point(116, 234);
			this.RoundedRectangleRoundValueTextBox.Name = "RoundedRectangleRoundValueTextBox";
			this.RoundedRectangleRoundValueTextBox.Size = new System.Drawing.Size(100, 20);
			this.RoundedRectangleRoundValueTextBox.TabIndex = 42;
			// 
			// EllipseHeightTextBox
			// 
			this.EllipseHeightTextBox.Location = new System.Drawing.Point(116, 149);
			this.EllipseHeightTextBox.Name = "EllipseHeightTextBox";
			this.EllipseHeightTextBox.Size = new System.Drawing.Size(100, 20);
			this.EllipseHeightTextBox.TabIndex = 41;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Input the height";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 130);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 13);
			this.label8.TabIndex = 39;
			this.label8.Text = "Input the width:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 38;
			this.label7.Text = "Input the angle:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 211);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 37;
			this.label1.Text = "Input the height";
			// 
			// RoundedRectangleHeightTextBox
			// 
			this.RoundedRectangleHeightTextBox.Location = new System.Drawing.Point(116, 208);
			this.RoundedRectangleHeightTextBox.Name = "RoundedRectangleHeightTextBox";
			this.RoundedRectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
			this.RoundedRectangleHeightTextBox.TabIndex = 36;
			// 
			// ArcAngleTextBox
			// 
			this.ArcAngleTextBox.Location = new System.Drawing.Point(116, 33);
			this.ArcAngleTextBox.Name = "ArcAngleTextBox";
			this.ArcAngleTextBox.Size = new System.Drawing.Size(100, 20);
			this.ArcAngleTextBox.TabIndex = 27;
			// 
			// SectorAngleTextBox
			// 
			this.SectorAngleTextBox.Location = new System.Drawing.Point(116, 94);
			this.SectorAngleTextBox.Name = "SectorAngleTextBox";
			this.SectorAngleTextBox.Size = new System.Drawing.Size(100, 20);
			this.SectorAngleTextBox.TabIndex = 26;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Input the angle:";
			// 
			// RoundedRectangleWidthTextBox
			// 
			this.RoundedRectangleWidthTextBox.Location = new System.Drawing.Point(116, 183);
			this.RoundedRectangleWidthTextBox.Name = "RoundedRectangleWidthTextBox";
			this.RoundedRectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
			this.RoundedRectangleWidthTextBox.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Input the width:";
			// 
			// AddArcButton
			// 
			this.AddArcButton.Location = new System.Drawing.Point(225, 10);
			this.AddArcButton.Name = "AddArcButton";
			this.AddArcButton.Size = new System.Drawing.Size(104, 26);
			this.AddArcButton.TabIndex = 0;
			this.AddArcButton.Text = "Add Arc";
			this.AddArcButton.UseVisualStyleBackColor = true;
			this.AddArcButton.Click += new System.EventHandler(this.AddArcButton_Click);
			// 
			// EllipseWidthTextBox
			// 
			this.EllipseWidthTextBox.Location = new System.Drawing.Point(116, 127);
			this.EllipseWidthTextBox.Name = "EllipseWidthTextBox";
			this.EllipseWidthTextBox.Size = new System.Drawing.Size(100, 20);
			this.EllipseWidthTextBox.TabIndex = 18;
			// 
			// AddEllipseButton
			// 
			this.AddEllipseButton.Location = new System.Drawing.Point(225, 129);
			this.AddEllipseButton.Name = "AddEllipseButton";
			this.AddEllipseButton.Size = new System.Drawing.Size(104, 26);
			this.AddEllipseButton.TabIndex = 10;
			this.AddEllipseButton.Text = "Add Ellipse";
			this.AddEllipseButton.UseVisualStyleBackColor = true;
			this.AddEllipseButton.Click += new System.EventHandler(this.AddEllipseButton_Click);
			// 
			// SectorRadiusTextBox
			// 
			this.SectorRadiusTextBox.Location = new System.Drawing.Point(116, 68);
			this.SectorRadiusTextBox.Name = "SectorRadiusTextBox";
			this.SectorRadiusTextBox.Size = new System.Drawing.Size(100, 20);
			this.SectorRadiusTextBox.TabIndex = 16;
			// 
			// AddSectorButton
			// 
			this.AddSectorButton.Location = new System.Drawing.Point(225, 76);
			this.AddSectorButton.Name = "AddSectorButton";
			this.AddSectorButton.Size = new System.Drawing.Size(104, 26);
			this.AddSectorButton.TabIndex = 11;
			this.AddSectorButton.Text = "Add Sector";
			this.AddSectorButton.UseVisualStyleBackColor = true;
			this.AddSectorButton.Click += new System.EventHandler(this.AddSectorButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Input the radius:";
			// 
			// AddRectangleButton
			// 
			this.AddRectangleButton.Location = new System.Drawing.Point(225, 192);
			this.AddRectangleButton.Name = "AddRectangleButton";
			this.AddRectangleButton.Size = new System.Drawing.Size(104, 51);
			this.AddRectangleButton.TabIndex = 12;
			this.AddRectangleButton.Text = "Add Rectangle with rounded corners";
			this.AddRectangleButton.UseVisualStyleBackColor = true;
			this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Input the radius:";
			// 
			// ArcRadiusTextBox
			// 
			this.ArcRadiusTextBox.Location = new System.Drawing.Point(116, 7);
			this.ArcRadiusTextBox.Name = "ArcRadiusTextBox";
			this.ArcRadiusTextBox.Size = new System.Drawing.Size(100, 20);
			this.ArcRadiusTextBox.TabIndex = 14;
			// 
			// ColorPictureBox
			// 
			this.ColorPictureBox.BackColor = System.Drawing.Color.Black;
			this.ColorPictureBox.Location = new System.Drawing.Point(163, 302);
			this.ColorPictureBox.Name = "ColorPictureBox";
			this.ColorPictureBox.Size = new System.Drawing.Size(27, 25);
			this.ColorPictureBox.TabIndex = 12;
			this.ColorPictureBox.TabStop = false;
			// 
			// FigureDrawingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1333, 577);
			this.Controls.Add(this.ColorPictureBox);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.DrawButton);
			this.Controls.Add(this.ColorButton);
			this.Controls.Add(this.MainPictureBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Name = "FigureDrawingForm";
			this.Text = "FigureDrawingForm";
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IndexNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StepNumericUpDown)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button DrawButton;
		private System.Windows.Forms.Button ColorButton;
		private System.Windows.Forms.PictureBox MainPictureBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown IndexNumericUpDown;
		private System.Windows.Forms.NumericUpDown StepNumericUpDown;
		private System.Windows.Forms.Button LeftButton;
		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button DownButton;
		private System.Windows.Forms.Button RightButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox SectorAngleTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox RoundedRectangleWidthTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button AddArcButton;
		private System.Windows.Forms.TextBox EllipseWidthTextBox;
		private System.Windows.Forms.Button AddEllipseButton;
		private System.Windows.Forms.TextBox SectorRadiusTextBox;
		private System.Windows.Forms.Button AddSectorButton;
		private System.Windows.Forms.Button AddRectangleButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ArcRadiusTextBox;
		private System.Windows.Forms.TextBox ArcAngleTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RoundedRectangleHeightTextBox;
		private System.Windows.Forms.TextBox EllipseHeightTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox RoundedRectangleRoundValueTextBox;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.PictureBox ColorPictureBox;
	}
}