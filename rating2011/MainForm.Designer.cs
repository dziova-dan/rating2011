namespace rating2011
{
    partial class MainForm
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
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.Location = new System.Drawing.Point(108, 121);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.Size = new System.Drawing.Size(120, 95);
            this.listBoxAvailable.TabIndex = 0;
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.Location = new System.Drawing.Point(578, 121);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(120, 95);
            this.listBoxBookings.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(359, 250);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Проверка";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.listBoxBookings);
            this.Controls.Add(this.listBoxAvailable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.ListBox listBoxBookings;
        private System.Windows.Forms.Button btnCheck;
    }
}

