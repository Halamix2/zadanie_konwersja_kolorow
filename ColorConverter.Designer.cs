namespace Rysowanie
{
    partial class ColorConverter
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
            System.Windows.Forms.Label redLabel;
            System.Windows.Forms.Label greenLabel;
            System.Windows.Forms.Label blueLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.color_panel = new System.Windows.Forms.Panel();
            this.slider_red = new System.Windows.Forms.TrackBar();
            this.slider_green = new System.Windows.Forms.TrackBar();
            this.slider_blue = new System.Windows.Forms.TrackBar();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.label_rgb = new System.Windows.Forms.Label();
            this.label_yellow = new System.Windows.Forms.Label();
            this.label_magenta = new System.Windows.Forms.Label();
            this.label_cyan = new System.Windows.Forms.Label();
            this.slider_yellow = new System.Windows.Forms.TrackBar();
            this.slider_magenta = new System.Windows.Forms.TrackBar();
            this.slider_cyan = new System.Windows.Forms.TrackBar();
            this.label_key = new System.Windows.Forms.Label();
            this.slider_key = new System.Windows.Forms.TrackBar();
            this.label_cmyk = new System.Windows.Forms.Label();
            redLabel = new System.Windows.Forms.Label();
            greenLabel = new System.Windows.Forms.Label();
            blueLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_magenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_key)).BeginInit();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.ForeColor = System.Drawing.Color.Red;
            redLabel.Location = new System.Drawing.Point(24, 108);
            redLabel.Name = "redLabel";
            redLabel.Size = new System.Drawing.Size(30, 13);
            redLabel.TabIndex = 5;
            redLabel.Text = "RED";
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.ForeColor = System.Drawing.Color.Green;
            greenLabel.Location = new System.Drawing.Point(12, 159);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new System.Drawing.Size(45, 13);
            greenLabel.TabIndex = 6;
            greenLabel.Text = "GREEN";
            // 
            // blueLabel
            // 
            blueLabel.AutoSize = true;
            blueLabel.ForeColor = System.Drawing.Color.Blue;
            blueLabel.Location = new System.Drawing.Point(19, 210);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new System.Drawing.Size(35, 13);
            blueLabel.TabIndex = 7;
            blueLabel.Text = "BLUE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Yellow;
            label4.Location = new System.Drawing.Point(398, 210);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 13);
            label4.TabIndex = 17;
            label4.Text = "YELLOW";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Magenta;
            label5.Location = new System.Drawing.Point(390, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 13);
            label5.TabIndex = 16;
            label5.Text = "MAGENTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Cyan;
            label6.Location = new System.Drawing.Point(403, 109);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 13);
            label6.TabIndex = 15;
            label6.Text = "CYAN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(409, 261);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(28, 13);
            label8.TabIndex = 22;
            label8.Text = "KEY";
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(713, 383);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Save";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(632, 383);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // color_panel
            // 
            this.color_panel.Location = new System.Drawing.Point(12, 12);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(727, 79);
            this.color_panel.TabIndex = 2;
            // 
            // slider_red
            // 
            this.slider_red.AutoSize = false;
            this.slider_red.Location = new System.Drawing.Point(55, 108);
            this.slider_red.Maximum = 255;
            this.slider_red.Name = "slider_red";
            this.slider_red.Size = new System.Drawing.Size(236, 45);
            this.slider_red.TabIndex = 0;
            this.slider_red.TickFrequency = 0;
            this.slider_red.Scroll += new System.EventHandler(this.RgbSlide);
            // 
            // slider_green
            // 
            this.slider_green.Location = new System.Drawing.Point(55, 159);
            this.slider_green.Maximum = 255;
            this.slider_green.Name = "slider_green";
            this.slider_green.Size = new System.Drawing.Size(236, 45);
            this.slider_green.TabIndex = 3;
            this.slider_green.TickFrequency = 0;
            this.slider_green.Scroll += new System.EventHandler(this.RgbSlide);
            // 
            // slider_blue
            // 
            this.slider_blue.Location = new System.Drawing.Point(55, 210);
            this.slider_blue.Maximum = 255;
            this.slider_blue.Name = "slider_blue";
            this.slider_blue.Size = new System.Drawing.Size(236, 45);
            this.slider_blue.TabIndex = 4;
            this.slider_blue.TickFrequency = 0;
            this.slider_blue.Scroll += new System.EventHandler(this.RgbSlide);
            // 
            // label_red
            // 
            this.label_red.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_red.ForeColor = System.Drawing.Color.Black;
            this.label_red.Location = new System.Drawing.Point(297, 108);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(52, 31);
            this.label_red.TabIndex = 8;
            // 
            // label_green
            // 
            this.label_green.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_green.ForeColor = System.Drawing.Color.Black;
            this.label_green.Location = new System.Drawing.Point(297, 158);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(52, 31);
            this.label_green.TabIndex = 9;
            // 
            // label_blue
            // 
            this.label_blue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_blue.ForeColor = System.Drawing.Color.Black;
            this.label_blue.Location = new System.Drawing.Point(297, 208);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(52, 31);
            this.label_blue.TabIndex = 10;
            // 
            // label_rgb
            // 
            this.label_rgb.AutoSize = true;
            this.label_rgb.ForeColor = System.Drawing.Color.Red;
            this.label_rgb.Location = new System.Drawing.Point(146, 258);
            this.label_rgb.Name = "label_rgb";
            this.label_rgb.Size = new System.Drawing.Size(49, 13);
            this.label_rgb.TabIndex = 11;
            this.label_rgb.Text = "rgb(r,g,b)";
            // 
            // label_yellow
            // 
            this.label_yellow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_yellow.ForeColor = System.Drawing.Color.Black;
            this.label_yellow.Location = new System.Drawing.Point(687, 208);
            this.label_yellow.Name = "label_yellow";
            this.label_yellow.Size = new System.Drawing.Size(52, 31);
            this.label_yellow.TabIndex = 20;
            // 
            // label_magenta
            // 
            this.label_magenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_magenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_magenta.ForeColor = System.Drawing.Color.Black;
            this.label_magenta.Location = new System.Drawing.Point(687, 158);
            this.label_magenta.Name = "label_magenta";
            this.label_magenta.Size = new System.Drawing.Size(52, 31);
            this.label_magenta.TabIndex = 19;
            // 
            // label_cyan
            // 
            this.label_cyan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cyan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cyan.ForeColor = System.Drawing.Color.Black;
            this.label_cyan.Location = new System.Drawing.Point(687, 108);
            this.label_cyan.Name = "label_cyan";
            this.label_cyan.Size = new System.Drawing.Size(52, 31);
            this.label_cyan.TabIndex = 18;
            // 
            // slider_yellow
            // 
            this.slider_yellow.Location = new System.Drawing.Point(445, 210);
            this.slider_yellow.Maximum = 100;
            this.slider_yellow.Name = "slider_yellow";
            this.slider_yellow.Size = new System.Drawing.Size(236, 45);
            this.slider_yellow.TabIndex = 14;
            this.slider_yellow.TickFrequency = 0;
            this.slider_yellow.Scroll += new System.EventHandler(this.cmykSlide);
            // 
            // slider_magenta
            // 
            this.slider_magenta.Location = new System.Drawing.Point(445, 159);
            this.slider_magenta.Maximum = 100;
            this.slider_magenta.Name = "slider_magenta";
            this.slider_magenta.Size = new System.Drawing.Size(236, 45);
            this.slider_magenta.TabIndex = 13;
            this.slider_magenta.TickFrequency = 0;
            this.slider_magenta.Scroll += new System.EventHandler(this.cmykSlide);
            // 
            // slider_cyan
            // 
            this.slider_cyan.AutoSize = false;
            this.slider_cyan.Location = new System.Drawing.Point(445, 108);
            this.slider_cyan.Maximum = 100;
            this.slider_cyan.Name = "slider_cyan";
            this.slider_cyan.Size = new System.Drawing.Size(236, 45);
            this.slider_cyan.TabIndex = 12;
            this.slider_cyan.TickFrequency = 0;
            this.slider_cyan.Scroll += new System.EventHandler(this.cmykSlide);
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_key.ForeColor = System.Drawing.Color.Black;
            this.label_key.Location = new System.Drawing.Point(687, 259);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(52, 31);
            this.label_key.TabIndex = 23;
            // 
            // slider_key
            // 
            this.slider_key.Location = new System.Drawing.Point(445, 261);
            this.slider_key.Maximum = 100;
            this.slider_key.Name = "slider_key";
            this.slider_key.Size = new System.Drawing.Size(236, 45);
            this.slider_key.TabIndex = 21;
            this.slider_key.TickFrequency = 0;
            this.slider_key.Scroll += new System.EventHandler(this.cmykSlide);
            // 
            // label_cmyk
            // 
            this.label_cmyk.AutoSize = true;
            this.label_cmyk.ForeColor = System.Drawing.Color.Red;
            this.label_cmyk.Location = new System.Drawing.Point(539, 309);
            this.label_cmyk.Name = "label_cmyk";
            this.label_cmyk.Size = new System.Drawing.Size(79, 13);
            this.label_cmyk.TabIndex = 24;
            this.label_cmyk.Text = "cmyk(%,%,%,%)";
            // 
            // ColorConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_cmyk);
            this.Controls.Add(this.label_key);
            this.Controls.Add(label8);
            this.Controls.Add(this.slider_key);
            this.Controls.Add(this.label_yellow);
            this.Controls.Add(this.label_magenta);
            this.Controls.Add(this.label_cyan);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(this.slider_yellow);
            this.Controls.Add(this.slider_magenta);
            this.Controls.Add(this.slider_cyan);
            this.Controls.Add(this.label_rgb);
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.label_red);
            this.Controls.Add(blueLabel);
            this.Controls.Add(greenLabel);
            this.Controls.Add(redLabel);
            this.Controls.Add(this.slider_blue);
            this.Controls.Add(this.slider_green);
            this.Controls.Add(this.slider_red);
            this.Controls.Add(this.color_panel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "ColorConverter";
            this.Text = "ColorConverter";
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_magenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.TrackBar slider_red;
        private System.Windows.Forms.TrackBar slider_green;
        private System.Windows.Forms.TrackBar slider_blue;
        public System.Windows.Forms.Label label_red;
        public System.Windows.Forms.Label label_green;
        public System.Windows.Forms.Label label_blue;
        public System.Windows.Forms.Label label_rgb;
        public System.Windows.Forms.Label label_yellow;
        public System.Windows.Forms.Label label_magenta;
        public System.Windows.Forms.Label label_cyan;
        private System.Windows.Forms.TrackBar slider_yellow;
        private System.Windows.Forms.TrackBar slider_magenta;
        private System.Windows.Forms.TrackBar slider_cyan;
        public System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TrackBar slider_key;
        public System.Windows.Forms.Label label_cmyk;
    }
}