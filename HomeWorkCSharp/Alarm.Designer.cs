namespace HomeWorkCSharp
{
    partial class Alarm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt秒 = new System.Windows.Forms.TextBox();
            this.btnAlarmSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt時 = new System.Windows.Forms.TextBox();
            this.txt分 = new System.Windows.Forms.TextBox();
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            this.labTimeNow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt秒);
            this.groupBox1.Controls.Add(this.btnAlarmSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt時);
            this.groupBox1.Controls.Add(this.txt分);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(97, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(339, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // txt秒
            // 
            this.txt秒.Location = new System.Drawing.Point(255, 67);
            this.txt秒.Name = "txt秒";
            this.txt秒.Size = new System.Drawing.Size(82, 33);
            this.txt秒.TabIndex = 5;
            // 
            // btnAlarmSet
            // 
            this.btnAlarmSet.Location = new System.Drawing.Point(98, 123);
            this.btnAlarmSet.Name = "btnAlarmSet";
            this.btnAlarmSet.Size = new System.Drawing.Size(154, 39);
            this.btnAlarmSet.TabIndex = 4;
            this.btnAlarmSet.Text = "設定鬧鐘時間";
            this.btnAlarmSet.UseVisualStyleBackColor = true;
            this.btnAlarmSet.Click += new System.EventHandler(this.btnAlarmSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(219, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(97, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "點";
            // 
            // txt時
            // 
            this.txt時.Location = new System.Drawing.Point(9, 67);
            this.txt時.Name = "txt時";
            this.txt時.Size = new System.Drawing.Size(82, 33);
            this.txt時.TabIndex = 1;
            // 
            // txt分
            // 
            this.txt分.Location = new System.Drawing.Point(132, 67);
            this.txt分.Name = "txt分";
            this.txt分.Size = new System.Drawing.Size(82, 33);
            this.txt分.TabIndex = 0;
            // 
            // timeNow
            // 
            this.timeNow.Interval = 1000;
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // labTimeNow
            // 
            this.labTimeNow.AutoSize = true;
            this.labTimeNow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTimeNow.Location = new System.Drawing.Point(117, 47);
            this.labTimeNow.Name = "labTimeNow";
            this.labTimeNow.Size = new System.Drawing.Size(90, 24);
            this.labTimeNow.TabIndex = 1;
            this.labTimeNow.Text = "現在時間:";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.labTimeNow);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlarmSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt時;
        private System.Windows.Forms.Timer timeNow;
        private System.Windows.Forms.Label labTimeNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt秒;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt分;
    }
}