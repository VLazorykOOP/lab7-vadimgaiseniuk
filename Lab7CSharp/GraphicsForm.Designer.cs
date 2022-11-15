namespace Lab7CSharp
{
	partial class GraphicsForm
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
			this.MainPictureBox = new System.Windows.Forms.PictureBox();
			this.ChooseColorButton = new System.Windows.Forms.Button();
			this.ChooseFontButton = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.StartTimerButton = new System.Windows.Forms.Button();
			this.SpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.RedrawButton = new System.Windows.Forms.Button();
			this.ColorPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// MainPictureBox
			// 
			this.MainPictureBox.BackColor = System.Drawing.Color.White;
			this.MainPictureBox.Location = new System.Drawing.Point(162, 0);
			this.MainPictureBox.Name = "MainPictureBox";
			this.MainPictureBox.Size = new System.Drawing.Size(980, 570);
			this.MainPictureBox.TabIndex = 0;
			this.MainPictureBox.TabStop = false;
			this.MainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPictureBox_Paint);
			// 
			// ChooseColorButton
			// 
			this.ChooseColorButton.Location = new System.Drawing.Point(31, 12);
			this.ChooseColorButton.Name = "ChooseColorButton";
			this.ChooseColorButton.Size = new System.Drawing.Size(101, 95);
			this.ChooseColorButton.TabIndex = 1;
			this.ChooseColorButton.Text = "Choose color";
			this.ChooseColorButton.UseVisualStyleBackColor = true;
			this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
			// 
			// ChooseFontButton
			// 
			this.ChooseFontButton.Location = new System.Drawing.Point(31, 146);
			this.ChooseFontButton.Name = "ChooseFontButton";
			this.ChooseFontButton.Size = new System.Drawing.Size(101, 95);
			this.ChooseFontButton.TabIndex = 2;
			this.ChooseFontButton.Text = "Choose font";
			this.ChooseFontButton.UseVisualStyleBackColor = true;
			this.ChooseFontButton.Click += new System.EventHandler(this.ChooseFontButton_Click);
			// 
			// StartTimerButton
			// 
			this.StartTimerButton.Location = new System.Drawing.Point(31, 247);
			this.StartTimerButton.Name = "StartTimerButton";
			this.StartTimerButton.Size = new System.Drawing.Size(101, 95);
			this.StartTimerButton.TabIndex = 3;
			this.StartTimerButton.Text = "Start/Stop timer";
			this.StartTimerButton.UseVisualStyleBackColor = true;
			this.StartTimerButton.Click += new System.EventHandler(this.StartTimerButton_Click);
			// 
			// SpeedNumericUpDown
			// 
			this.SpeedNumericUpDown.Location = new System.Drawing.Point(22, 471);
			this.SpeedNumericUpDown.Name = "SpeedNumericUpDown";
			this.SpeedNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.SpeedNumericUpDown.TabIndex = 4;
			this.SpeedNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.SpeedNumericUpDown.ValueChanged += new System.EventHandler(this.SpeedNumericUpDown_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 455);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Input speed";
			// 
			// RedrawButton
			// 
			this.RedrawButton.Location = new System.Drawing.Point(31, 348);
			this.RedrawButton.Name = "RedrawButton";
			this.RedrawButton.Size = new System.Drawing.Size(101, 95);
			this.RedrawButton.TabIndex = 6;
			this.RedrawButton.Text = "Redraw";
			this.RedrawButton.UseVisualStyleBackColor = true;
			this.RedrawButton.Click += new System.EventHandler(this.RedrawButton_Click);
			// 
			// ColorPictureBox
			// 
			this.ColorPictureBox.BackColor = System.Drawing.Color.Black;
			this.ColorPictureBox.Location = new System.Drawing.Point(68, 113);
			this.ColorPictureBox.Name = "ColorPictureBox";
			this.ColorPictureBox.Size = new System.Drawing.Size(27, 25);
			this.ColorPictureBox.TabIndex = 8;
			this.ColorPictureBox.TabStop = false;
			// 
			// GraphicsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1142, 570);
			this.Controls.Add(this.ColorPictureBox);
			this.Controls.Add(this.RedrawButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SpeedNumericUpDown);
			this.Controls.Add(this.StartTimerButton);
			this.Controls.Add(this.ChooseFontButton);
			this.Controls.Add(this.ChooseColorButton);
			this.Controls.Add(this.MainPictureBox);
			this.Name = "GraphicsForm";
			this.Text = "GraphicsForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Graphics_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox MainPictureBox;
		private System.Windows.Forms.Button ChooseColorButton;
		private System.Windows.Forms.Button ChooseFontButton;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button StartTimerButton;
		private System.Windows.Forms.NumericUpDown SpeedNumericUpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RedrawButton;
		private System.Windows.Forms.PictureBox ColorPictureBox;
	}
}