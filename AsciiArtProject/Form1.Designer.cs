namespace AsciiArtProject {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnAsciify = new System.Windows.Forms.Button();
            this.PicOriginal = new System.Windows.Forms.PictureBox();
            this.TxtAsciied = new System.Windows.Forms.TextBox();
            this.PixelWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.PixelHeighUpDown = new System.Windows.Forms.NumericUpDown();
            this.LblPixelWidth = new System.Windows.Forms.Label();
            this.LblPixelHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelHeighUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAsciify
            // 
            this.BtnAsciify.Location = new System.Drawing.Point(165, 653);
            this.BtnAsciify.Name = "BtnAsciify";
            this.BtnAsciify.Size = new System.Drawing.Size(186, 76);
            this.BtnAsciify.TabIndex = 0;
            this.BtnAsciify.Text = "Asciify Image";
            this.BtnAsciify.UseVisualStyleBackColor = true;
            this.BtnAsciify.Click += new System.EventHandler(this.BtnAsciify_Click);
            // 
            // PicOriginal
            // 
            this.PicOriginal.Location = new System.Drawing.Point(40, 38);
            this.PicOriginal.Name = "PicOriginal";
            this.PicOriginal.Size = new System.Drawing.Size(427, 545);
            this.PicOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicOriginal.TabIndex = 2;
            this.PicOriginal.TabStop = false;
            // 
            // TxtAsciied
            // 
            this.TxtAsciied.Font = new System.Drawing.Font("Consolas", 4F);
            this.TxtAsciied.Location = new System.Drawing.Point(502, 38);
            this.TxtAsciied.Multiline = true;
            this.TxtAsciied.Name = "TxtAsciied";
            this.TxtAsciied.ReadOnly = true;
            this.TxtAsciied.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAsciied.Size = new System.Drawing.Size(1650, 1650);
            this.TxtAsciied.TabIndex = 3;
            this.TxtAsciied.WordWrap = false;
            // 
            // PixelWidthUpDown
            // 
            this.PixelWidthUpDown.Location = new System.Drawing.Point(261, 788);
            this.PixelWidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelWidthUpDown.Name = "PixelWidthUpDown";
            this.PixelWidthUpDown.Size = new System.Drawing.Size(120, 31);
            this.PixelWidthUpDown.TabIndex = 4;
            this.PixelWidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelWidthUpDown.ValueChanged += new System.EventHandler(this.PixelWidthUpDown_ValueChanged);
            // 
            // PixelHeighUpDown
            // 
            this.PixelHeighUpDown.Location = new System.Drawing.Point(261, 849);
            this.PixelHeighUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelHeighUpDown.Name = "PixelHeighUpDown";
            this.PixelHeighUpDown.Size = new System.Drawing.Size(120, 31);
            this.PixelHeighUpDown.TabIndex = 5;
            this.PixelHeighUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelHeighUpDown.ValueChanged += new System.EventHandler(this.PixelHeighUpDown_ValueChanged);
            // 
            // LblPixelWidth
            // 
            this.LblPixelWidth.AutoSize = true;
            this.LblPixelWidth.Location = new System.Drawing.Point(119, 788);
            this.LblPixelWidth.Name = "LblPixelWidth";
            this.LblPixelWidth.Size = new System.Drawing.Size(120, 25);
            this.LblPixelWidth.TabIndex = 6;
            this.LblPixelWidth.Text = "Pixel Width";
            // 
            // LblPixelHeight
            // 
            this.LblPixelHeight.AutoSize = true;
            this.LblPixelHeight.Location = new System.Drawing.Point(112, 849);
            this.LblPixelHeight.Name = "LblPixelHeight";
            this.LblPixelHeight.Size = new System.Drawing.Size(127, 25);
            this.LblPixelHeight.TabIndex = 7;
            this.LblPixelHeight.Text = "Pixel Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2192, 1719);
            this.Controls.Add(this.LblPixelHeight);
            this.Controls.Add(this.LblPixelWidth);
            this.Controls.Add(this.PixelHeighUpDown);
            this.Controls.Add(this.PixelWidthUpDown);
            this.Controls.Add(this.TxtAsciied);
            this.Controls.Add(this.PicOriginal);
            this.Controls.Add(this.BtnAsciify);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelWidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelHeighUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAsciify;
        private System.Windows.Forms.PictureBox PicOriginal;
        private System.Windows.Forms.TextBox TxtAsciied;
        private System.Windows.Forms.NumericUpDown PixelWidthUpDown;
        private System.Windows.Forms.NumericUpDown PixelHeighUpDown;
        private System.Windows.Forms.Label LblPixelWidth;
        private System.Windows.Forms.Label LblPixelHeight;
    }
}

