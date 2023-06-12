namespace Form_homepage
{
    partial class Form_drawpaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_color = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_cursorsize = new System.Windows.Forms.Label();
            this.picturebox_nowcolor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_nowcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 405);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_color
            // 
            this.button_color.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_color.Location = new System.Drawing.Point(639, 12);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(79, 39);
            this.button_color.TabIndex = 1;
            this.button_color.Text = "顏色";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(652, 104);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 133);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_cursorsize
            // 
            this.label_cursorsize.AutoSize = true;
            this.label_cursorsize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_cursorsize.Location = new System.Drawing.Point(648, 240);
            this.label_cursorsize.Name = "label_cursorsize";
            this.label_cursorsize.Size = new System.Drawing.Size(18, 20);
            this.label_cursorsize.TabIndex = 3;
            this.label_cursorsize.Text = "1";
            // 
            // picturebox_nowcolor
            // 
            this.picturebox_nowcolor.BackColor = System.Drawing.Color.Black;
            this.picturebox_nowcolor.Location = new System.Drawing.Point(639, 57);
            this.picturebox_nowcolor.Name = "picturebox_nowcolor";
            this.picturebox_nowcolor.Size = new System.Drawing.Size(79, 41);
            this.picturebox_nowcolor.TabIndex = 5;
            this.picturebox_nowcolor.TabStop = false;
            // 
            // Form_drawpaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturebox_nowcolor);
            this.Controls.Add(this.label_cursorsize);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.panel1);
            this.Name = "Form_drawpaint";
            this.Text = "Form_drawpaint";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_nowcolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_cursorsize;
        private System.Windows.Forms.PictureBox picturebox_nowcolor;
    }
}