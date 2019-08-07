namespace Project
{
    partial class Form_converterOfClock
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBox_hours = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.label_minutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBox_hours
            // 
            this.tBox_hours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_hours.Location = new System.Drawing.Point(42, 96);
            this.tBox_hours.Name = "tBox_hours";
            this.tBox_hours.Size = new System.Drawing.Size(101, 30);
            this.tBox_hours.TabIndex = 0;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(224, 96);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(46, 33);
            this.button_convert.TabIndex = 1;
            this.button_convert.Text = "=";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(39, 23);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(332, 65);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Введите значение от 0 до 1000 (часы) для перевода его в минуты";
            // 
            // label_minutes
            // 
            this.label_minutes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_minutes.Location = new System.Drawing.Point(38, 144);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(333, 93);
            this.label_minutes.TabIndex = 4;
            // 
            // Form_converterOfClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 247);
            this.Controls.Add(this.label_minutes);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.tBox_hours);
            this.Name = "Form_converterOfClock";
            this.Text = "Конвертер перевода часов в минуты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_hours;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_minutes;
    }
}

