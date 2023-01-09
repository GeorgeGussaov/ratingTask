namespace ratingTask
{
    partial class FormMonthConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMonthNumber = new System.Windows.Forms.TextBox();
            this.textBoxMonthName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.listBoxInMonthDaysCnt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(58, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер месяца:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(250, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Месяц:";
            // 
            // textBoxMonthNumber
            // 
            this.textBoxMonthNumber.Location = new System.Drawing.Point(61, 132);
            this.textBoxMonthNumber.Name = "textBoxMonthNumber";
            this.textBoxMonthNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonthNumber.TabIndex = 2;
            // 
            // textBoxMonthName
            // 
            this.textBoxMonthName.Location = new System.Drawing.Point(253, 132);
            this.textBoxMonthName.Name = "textBoxMonthName";
            this.textBoxMonthName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonthName.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(165, 183);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(93, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Активировать";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // listBoxInMonthDaysCnt
            // 
            this.listBoxInMonthDaysCnt.FormattingEnabled = true;
            this.listBoxInMonthDaysCnt.Location = new System.Drawing.Point(61, 262);
            this.listBoxInMonthDaysCnt.Name = "listBoxInMonthDaysCnt";
            this.listBoxInMonthDaysCnt.Size = new System.Drawing.Size(289, 95);
            this.listBoxInMonthDaysCnt.TabIndex = 7;
            // 
            // FormMonthConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.listBoxInMonthDaysCnt);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxMonthName);
            this.Controls.Add(this.textBoxMonthNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMonthConverter";
            this.Text = "MonthConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMonthNumber;
        private System.Windows.Forms.TextBox textBoxMonthName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ListBox listBoxInMonthDaysCnt;
    }
}

