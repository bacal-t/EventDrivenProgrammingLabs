namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLineWidth = new System.Windows.Forms.ComboBox();
            this.FigureBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FillColorBox = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gradientBtn = new System.Windows.Forms.Button();
            this.gradientColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // txtLineWidth
            // 
            this.txtLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLineWidth.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineWidth.Location = new System.Drawing.Point(793, 118);
            this.txtLineWidth.Name = "txtLineWidth";
            this.txtLineWidth.Size = new System.Drawing.Size(75, 25);
            this.txtLineWidth.TabIndex = 3;
            this.txtLineWidth.SelectedIndexChanged += new System.EventHandler(this.txtLineWidth_SelectedIndexChanged);
            // 
            // FigureBox
            // 
            this.FigureBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FigureBox.FormattingEnabled = true;
            this.FigureBox.Location = new System.Drawing.Point(747, 180);
            this.FigureBox.Name = "FigureBox";
            this.FigureBox.Size = new System.Drawing.Size(121, 25);
            this.FigureBox.TabIndex = 5;
            this.FigureBox.Text = "Line";
            this.FigureBox.SelectedIndexChanged += new System.EventHandler(this.FigureBox_SelectedIndexChanged);
            // 
            // FillColorBox
            // 
            this.FillColorBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillColorBox.FormattingEnabled = true;
            this.FillColorBox.Location = new System.Drawing.Point(747, 149);
            this.FillColorBox.Name = "FillColorBox";
            this.FillColorBox.Size = new System.Drawing.Size(121, 25);
            this.FillColorBox.TabIndex = 6;
            this.FillColorBox.Text = "Unfilled";
            this.FillColorBox.SelectedIndexChanged += new System.EventHandler(this.FillColorBox_SelectedIndexChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(790, 211);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(790, 240);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Save";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(747, 63);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(121, 39);
            this.btnColor.TabIndex = 9;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gradientBtn
            // 
            this.gradientBtn.BackColor = System.Drawing.Color.White;
            this.gradientBtn.Location = new System.Drawing.Point(747, 295);
            this.gradientBtn.Name = "gradientBtn";
            this.gradientBtn.Size = new System.Drawing.Size(118, 33);
            this.gradientBtn.TabIndex = 10;
            this.gradientBtn.UseVisualStyleBackColor = false;
            this.gradientBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradientColor
            // 
            this.gradientColor.AutoSize = true;
            this.gradientColor.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientColor.Location = new System.Drawing.Point(755, 275);
            this.gradientColor.Name = "gradientColor";
            this.gradientColor.Size = new System.Drawing.Size(99, 17);
            this.gradientColor.TabIndex = 11;
            this.gradientColor.Text = "Gradient Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pen Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradientColor);
            this.Controls.Add(this.gradientBtn);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.FigureBox);
            this.Controls.Add(this.txtLineWidth);
            this.Controls.Add(this.FillColorBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "LaboratoryWork#3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtLineWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FigureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox FillColorBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button gradientBtn;
        private System.Windows.Forms.Label gradientColor;
        private System.Windows.Forms.Label label2;
    }
}

