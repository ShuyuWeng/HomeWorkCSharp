namespace Lab_Frm
{
    partial class HelloFrom
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloFrom));
            this.txtName = new System.Windows.Forms.TextBox();
            this.FrmName = new System.Windows.Forms.Label();
            this.btnNameHi = new System.Windows.Forms.Button();
            this.FrmNameEn = new System.Windows.Forms.Label();
            this.txtNameEN = new System.Windows.Forms.TextBox();
            this.FrmGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.FrmStarSign = new System.Windows.Forms.Label();
            this.txtStarSign = new System.Windows.Forms.TextBox();
            this.FrmChiZodiac = new System.Windows.Forms.Label();
            this.txtChiZodiac = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNameHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 0;
            // 
            // FrmName
            // 
            this.FrmName.AutoSize = true;
            this.FrmName.BackColor = System.Drawing.Color.Transparent;
            this.FrmName.Location = new System.Drawing.Point(102, 42);
            this.FrmName.Name = "FrmName";
            this.FrmName.Size = new System.Drawing.Size(57, 20);
            this.FrmName.TabIndex = 2;
            this.FrmName.Text = "姓名：";
            // 
            // btnNameHi
            // 
            this.btnNameHi.AutoSize = true;
            this.btnNameHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNameHi.Location = new System.Drawing.Point(280, 286);
            this.btnNameHi.Name = "btnNameHi";
            this.btnNameHi.Size = new System.Drawing.Size(101, 49);
            this.btnNameHi.TabIndex = 3;
            this.btnNameHi.Text = "say Hi   ";
            this.btnNameHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameHi.UseVisualStyleBackColor = true;
            this.btnNameHi.Click += new System.EventHandler(this.btnNameHi_Click);
            // 
            // FrmNameEn
            // 
            this.FrmNameEn.AutoSize = true;
            this.FrmNameEn.BackColor = System.Drawing.Color.Transparent;
            this.FrmNameEn.Location = new System.Drawing.Point(102, 87);
            this.FrmNameEn.Name = "FrmNameEn";
            this.FrmNameEn.Size = new System.Drawing.Size(89, 20);
            this.FrmNameEn.TabIndex = 5;
            this.FrmNameEn.Text = "英文姓名：";
            // 
            // txtNameEN
            // 
            this.txtNameEN.Location = new System.Drawing.Point(239, 87);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(100, 29);
            this.txtNameEN.TabIndex = 4;
            // 
            // FrmGender
            // 
            this.FrmGender.AutoSize = true;
            this.FrmGender.BackColor = System.Drawing.Color.Transparent;
            this.FrmGender.Location = new System.Drawing.Point(102, 132);
            this.FrmGender.Name = "FrmGender";
            this.FrmGender.Size = new System.Drawing.Size(57, 20);
            this.FrmGender.TabIndex = 7;
            this.FrmGender.Text = "性別：";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(239, 132);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 29);
            this.txtGender.TabIndex = 6;
            // 
            // FrmStarSign
            // 
            this.FrmStarSign.AutoSize = true;
            this.FrmStarSign.BackColor = System.Drawing.Color.Transparent;
            this.FrmStarSign.Location = new System.Drawing.Point(102, 179);
            this.FrmStarSign.Name = "FrmStarSign";
            this.FrmStarSign.Size = new System.Drawing.Size(57, 20);
            this.FrmStarSign.TabIndex = 9;
            this.FrmStarSign.Text = "星座：";
            // 
            // txtStarSign
            // 
            this.txtStarSign.Location = new System.Drawing.Point(239, 179);
            this.txtStarSign.Name = "txtStarSign";
            this.txtStarSign.Size = new System.Drawing.Size(100, 29);
            this.txtStarSign.TabIndex = 8;
            // 
            // FrmChiZodiac
            // 
            this.FrmChiZodiac.AutoSize = true;
            this.FrmChiZodiac.BackColor = System.Drawing.Color.Transparent;
            this.FrmChiZodiac.Location = new System.Drawing.Point(102, 221);
            this.FrmChiZodiac.Name = "FrmChiZodiac";
            this.FrmChiZodiac.Size = new System.Drawing.Size(57, 20);
            this.FrmChiZodiac.TabIndex = 11;
            this.FrmChiZodiac.Text = "生肖：";
            // 
            // txtChiZodiac
            // 
            this.txtChiZodiac.Location = new System.Drawing.Point(239, 221);
            this.txtChiZodiac.Name = "txtChiZodiac";
            this.txtChiZodiac.Size = new System.Drawing.Size(100, 29);
            this.txtChiZodiac.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(98, 291);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnNameHello
            // 
            this.btnNameHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNameHello.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameHello.Location = new System.Drawing.Point(137, 286);
            this.btnNameHello.Name = "btnNameHello";
            this.btnNameHello.Size = new System.Drawing.Size(123, 50);
            this.btnNameHello.TabIndex = 13;
            this.btnNameHello.Text = "say Hello";
            this.btnNameHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameHello.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNameHello.UseVisualStyleBackColor = true;
            this.btnNameHello.Click += new System.EventHandler(this.btnNameHello_Click);
            // 
            // HelloFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 448);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNameHi);
            this.Controls.Add(this.btnNameHello);
            this.Controls.Add(this.FrmChiZodiac);
            this.Controls.Add(this.txtChiZodiac);
            this.Controls.Add(this.FrmStarSign);
            this.Controls.Add(this.txtStarSign);
            this.Controls.Add(this.FrmGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.FrmNameEn);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.FrmName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HelloFrom";
            this.Text = "Hello Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label FrmName;
        private System.Windows.Forms.Button btnNameHi;
        private System.Windows.Forms.Label FrmNameEn;
        private System.Windows.Forms.TextBox txtNameEN;
        private System.Windows.Forms.Label FrmGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label FrmStarSign;
        private System.Windows.Forms.TextBox txtStarSign;
        private System.Windows.Forms.Label FrmChiZodiac;
        private System.Windows.Forms.TextBox txtChiZodiac;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNameHello;
    }
}

