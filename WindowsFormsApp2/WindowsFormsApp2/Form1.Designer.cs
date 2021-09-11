
namespace WindowsFormsApp2
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
            this.A_TB = new System.Windows.Forms.TextBox();
            this.label_TB = new System.Windows.Forms.Label();
            this.label2_TB = new System.Windows.Forms.Label();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.knopka = new System.Windows.Forms.Button();
            this.RES_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.L_TB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(12, 75);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(124, 20);
            this.A_TB.TabIndex = 0;
            // 
            // label_TB
            // 
            this.label_TB.AutoSize = true;
            this.label_TB.Location = new System.Drawing.Point(12, 59);
            this.label_TB.Name = "label_TB";
            this.label_TB.Size = new System.Drawing.Size(14, 13);
            this.label_TB.TabIndex = 1;
            this.label_TB.Text = "A";
            this.label_TB.Click += new System.EventHandler(this.knopka_1_Click);
            // 
            // label2_TB
            // 
            this.label2_TB.AutoSize = true;
            this.label2_TB.Location = new System.Drawing.Point(12, 111);
            this.label2_TB.Name = "label2_TB";
            this.label2_TB.Size = new System.Drawing.Size(14, 13);
            this.label2_TB.TabIndex = 3;
            this.label2_TB.Text = "B";
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(15, 127);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(124, 20);
            this.B_TB.TabIndex = 2;
            // 
            // knopka
            // 
            this.knopka.Location = new System.Drawing.Point(15, 182);
            this.knopka.Name = "knopka";
            this.knopka.Size = new System.Drawing.Size(103, 24);
            this.knopka.TabIndex = 4;
            this.knopka.Text = "Тык";
            this.knopka.UseVisualStyleBackColor = true;
            this.knopka.Click += new System.EventHandler(this.knopka_Click);
            // 
            // RES_TB
            // 
            this.RES_TB.Location = new System.Drawing.Point(15, 212);
            this.RES_TB.Name = "RES_TB";
            this.RES_TB.Size = new System.Drawing.Size(124, 20);
            this.RES_TB.TabIndex = 5;
            this.RES_TB.TextChanged += new System.EventHandler(this.label3_TB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "L";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_TB
            // 
            this.L_TB.Location = new System.Drawing.Point(12, 26);
            this.L_TB.Name = "L_TB";
            this.L_TB.Size = new System.Drawing.Size(124, 20);
            this.L_TB.TabIndex = 6;
            this.L_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_TB);
            this.Controls.Add(this.RES_TB);
            this.Controls.Add(this.knopka);
            this.Controls.Add(this.label2_TB);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.label_TB);
            this.Controls.Add(this.A_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label label_TB;
        private System.Windows.Forms.Label label2_TB;
        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Button knopka;
        private System.Windows.Forms.TextBox RES_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox L_TB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

