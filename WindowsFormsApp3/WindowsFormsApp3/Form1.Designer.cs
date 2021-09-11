
namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x1_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.y2_TB = new System.Windows.Forms.Label();
            this.y4_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x2_TB = new System.Windows.Forms.TextBox();
            this.y1_TB = new System.Windows.Forms.Label();
            this.y3_TB = new System.Windows.Forms.TextBox();
            this.CULC_A = new System.Windows.Forms.Button();
            this.RES_A = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CULC_B = new System.Windows.Forms.Button();
            this.RES_B = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // x1_TB
            // 
            this.x1_TB.Location = new System.Drawing.Point(12, 61);
            this.x1_TB.Name = "x1_TB";
            this.x1_TB.Size = new System.Drawing.Size(111, 20);
            this.x1_TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число X1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // y2_TB
            // 
            this.y2_TB.AutoSize = true;
            this.y2_TB.Location = new System.Drawing.Point(12, 168);
            this.y2_TB.Name = "y2_TB";
            this.y2_TB.Size = new System.Drawing.Size(55, 13);
            this.y2_TB.TabIndex = 3;
            this.y2_TB.Text = "Число Y2";
            // 
            // y4_TB
            // 
            this.y4_TB.Location = new System.Drawing.Point(12, 183);
            this.y4_TB.Name = "y4_TB";
            this.y4_TB.Size = new System.Drawing.Size(111, 20);
            this.y4_TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Число X2";
            // 
            // x2_TB
            // 
            this.x2_TB.Location = new System.Drawing.Point(12, 145);
            this.x2_TB.Name = "x2_TB";
            this.x2_TB.Size = new System.Drawing.Size(111, 20);
            this.x2_TB.TabIndex = 4;
            // 
            // y1_TB
            // 
            this.y1_TB.AutoSize = true;
            this.y1_TB.Location = new System.Drawing.Point(12, 90);
            this.y1_TB.Name = "y1_TB";
            this.y1_TB.Size = new System.Drawing.Size(55, 13);
            this.y1_TB.TabIndex = 7;
            this.y1_TB.Text = "Число Y1";
            // 
            // y3_TB
            // 
            this.y3_TB.Location = new System.Drawing.Point(12, 106);
            this.y3_TB.Name = "y3_TB";
            this.y3_TB.Size = new System.Drawing.Size(111, 20);
            this.y3_TB.TabIndex = 6;
            // 
            // CULC_A
            // 
            this.CULC_A.Location = new System.Drawing.Point(32, 209);
            this.CULC_A.Name = "CULC_A";
            this.CULC_A.Size = new System.Drawing.Size(76, 21);
            this.CULC_A.TabIndex = 8;
            this.CULC_A.Text = "Тыкс";
            this.CULC_A.UseVisualStyleBackColor = true;
            this.CULC_A.Click += new System.EventHandler(this.CULC_B_Click);
            // 
            // RES_A
            // 
            this.RES_A.Location = new System.Drawing.Point(15, 236);
            this.RES_A.Name = "RES_A";
            this.RES_A.Size = new System.Drawing.Size(111, 20);
            this.RES_A.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 71);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CULC_B
            // 
            this.CULC_B.Location = new System.Drawing.Point(32, 262);
            this.CULC_B.Name = "CULC_B";
            this.CULC_B.Size = new System.Drawing.Size(76, 21);
            this.CULC_B.TabIndex = 11;
            this.CULC_B.Text = "Тыкс";
            this.CULC_B.UseVisualStyleBackColor = true;
            this.CULC_B.Click += new System.EventHandler(this.CULC_B_Click_1);
            // 
            // RES_B
            // 
            this.RES_B.Location = new System.Drawing.Point(15, 289);
            this.RES_B.Name = "RES_B";
            this.RES_B.Size = new System.Drawing.Size(111, 20);
            this.RES_B.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RES_B);
            this.Controls.Add(this.CULC_B);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RES_A);
            this.Controls.Add(this.CULC_A);
            this.Controls.Add(this.y1_TB);
            this.Controls.Add(this.y3_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2_TB);
            this.Controls.Add(this.y2_TB);
            this.Controls.Add(this.y4_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label y2_TB;
        private System.Windows.Forms.TextBox y4_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x2_TB;
        private System.Windows.Forms.Label y1_TB;
        private System.Windows.Forms.TextBox y3_TB;
        private System.Windows.Forms.Button CULC_A;
        private System.Windows.Forms.TextBox RES_A;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CULC_B;
        private System.Windows.Forms.TextBox RES_B;
    }
}

