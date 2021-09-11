
namespace WindowsFormsApp1
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
            this.A_TB = new System.Windows.Forms.TextBox();
            this.A_L = new System.Windows.Forms.Label();
            this.B_L = new System.Windows.Forms.Label();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.CALC_B = new System.Windows.Forms.Button();
            this.RES_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(12, 100);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(87, 20);
            this.A_TB.TabIndex = 0;
            this.A_TB.TextChanged += new System.EventHandler(this.A_TB_TextChanged);
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(12, 64);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(56, 13);
            this.A_L.TabIndex = 1;
            this.A_L.Text = "ЧИСЛО А";
            this.A_L.Click += new System.EventHandler(this.A_L_Click);
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Location = new System.Drawing.Point(12, 135);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(56, 13);
            this.B_L.TabIndex = 2;
            this.B_L.Text = "ЧИСЛО Б";
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(12, 161);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(87, 20);
            this.B_TB.TabIndex = 3;
            // 
            // CALC_B
            // 
            this.CALC_B.Location = new System.Drawing.Point(12, 205);
            this.CALC_B.Name = "CALC_B";
            this.CALC_B.Size = new System.Drawing.Size(75, 23);
            this.CALC_B.TabIndex = 4;
            this.CALC_B.Text = "Результат братик";
            this.CALC_B.UseVisualStyleBackColor = true;
            this.CALC_B.Click += new System.EventHandler(this.CALC_B_Click);
            // 
            // RES_TB
            // 
            this.RES_TB.Location = new System.Drawing.Point(12, 243);
            this.RES_TB.Name = "RES_TB";
            this.RES_TB.Size = new System.Drawing.Size(87, 20);
            this.RES_TB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.RES_TB);
            this.Controls.Add(this.CALC_B);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.A_L);
            this.Controls.Add(this.A_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Button CALC_B;
        private System.Windows.Forms.TextBox RES_TB;
    }
}

