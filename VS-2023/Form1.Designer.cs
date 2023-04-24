namespace VS_2023
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
            this.button_Borovets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Borovets
            // 
            this.button_Borovets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Borovets.Location = new System.Drawing.Point(30, 29);
            this.button_Borovets.Name = "button_Borovets";
            this.button_Borovets.Size = new System.Drawing.Size(120, 44);
            this.button_Borovets.TabIndex = 0;
            this.button_Borovets.Text = "Боровець";
            this.button_Borovets.UseVisualStyleBackColor = false;
            this.button_Borovets.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Borovets);
            this.Name = "Form1";
            this.Text = "спільний проєкт ПІ-20";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Borovets;
    }
}

