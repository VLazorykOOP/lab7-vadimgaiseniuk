
namespace Lab7CSharp
{
    partial class FreehandDrawingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.MainPictureBox = new System.Windows.Forms.PictureBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ChooseColor = new System.Windows.Forms.Button();
			this.CursorSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.ColorPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorSizeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// MainPictureBox
			// 
			this.MainPictureBox.BackColor = System.Drawing.Color.White;
			this.MainPictureBox.Location = new System.Drawing.Point(139, 12);
			this.MainPictureBox.Name = "MainPictureBox";
			this.MainPictureBox.Size = new System.Drawing.Size(953, 503);
			this.MainPictureBox.TabIndex = 1;
			this.MainPictureBox.TabStop = false;
			this.MainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
			this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
			this.MainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(26, 228);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(92, 91);
			this.ClearButton.TabIndex = 3;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ChooseColor
			// 
			this.ChooseColor.Location = new System.Drawing.Point(26, 93);
			this.ChooseColor.Name = "ChooseColor";
			this.ChooseColor.Size = new System.Drawing.Size(92, 91);
			this.ChooseColor.TabIndex = 4;
			this.ChooseColor.Text = "Choose color";
			this.ChooseColor.UseVisualStyleBackColor = true;
			this.ChooseColor.Click += new System.EventHandler(this.ChooseColor_Click);
			// 
			// CursorSizeNumericUpDown
			// 
			this.CursorSizeNumericUpDown.Location = new System.Drawing.Point(12, 361);
			this.CursorSizeNumericUpDown.Name = "CursorSizeNumericUpDown";
			this.CursorSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.CursorSizeNumericUpDown.TabIndex = 5;
			this.CursorSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.CursorSizeNumericUpDown.ValueChanged += new System.EventHandler(this.CursorSizeNumericUpDown_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 345);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Choose cursor size";
			// 
			// ColorPictureBox
			// 
			this.ColorPictureBox.BackColor = System.Drawing.Color.Black;
			this.ColorPictureBox.Location = new System.Drawing.Point(59, 190);
			this.ColorPictureBox.Name = "ColorPictureBox";
			this.ColorPictureBox.Size = new System.Drawing.Size(27, 25);
			this.ColorPictureBox.TabIndex = 7;
			this.ColorPictureBox.TabStop = false;
			// 
			// FreehandDrawingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1104, 527);
			this.Controls.Add(this.ColorPictureBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CursorSizeNumericUpDown);
			this.Controls.Add(this.ChooseColor);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.MainPictureBox);
			this.Name = "FreehandDrawingForm";
			this.Text = "FreehandDrawingForm";
			((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CursorSizeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.PictureBox MainPictureBox;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ChooseColor;
		private System.Windows.Forms.NumericUpDown CursorSizeNumericUpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox ColorPictureBox;
	}
}

