namespace CSharpWinFormProjects
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора
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
            this.YearRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonthRadio = new System.Windows.Forms.RadioButton();
            this.DayRadio = new System.Windows.Forms.RadioButton();
            this.minutesRadio = new System.Windows.Forms.RadioButton();
            this.secondsRadio = new System.Windows.Forms.RadioButton();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
           
            this.YearRadio.AutoSize = true;
            this.YearRadio.Location = new System.Drawing.Point(6, 19);
            this.YearRadio.Name = "YearRadio";
            this.YearRadio.Size = new System.Drawing.Size(62, 17);
            this.YearRadio.TabIndex = 0;
            this.YearRadio.TabStop = true;
            this.YearRadio.Text = "в годах";
            this.YearRadio.UseVisualStyleBackColor = true;
            
            this.groupBox1.Controls.Add(this.secondsRadio);
            this.groupBox1.Controls.Add(this.minutesRadio);
            this.groupBox1.Controls.Add(this.DayRadio);
            this.groupBox1.Controls.Add(this.MonthRadio);
            this.groupBox1.Controls.Add(this.YearRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Визначити в:";
            
            this.MonthRadio.AutoSize = true;
            this.MonthRadio.Location = new System.Drawing.Point(6, 42);
            this.MonthRadio.Name = "MonthRadio";
            this.MonthRadio.Size = new System.Drawing.Size(77, 17);
            this.MonthRadio.TabIndex = 1;
            this.MonthRadio.TabStop = true;
            this.MonthRadio.Text = "місяцях";
            this.MonthRadio.UseVisualStyleBackColor = true;
          
            this.DayRadio.AutoSize = true;
            this.DayRadio.Location = new System.Drawing.Point(6, 65);
            this.DayRadio.Name = "DayRadio";
            this.DayRadio.Size = new System.Drawing.Size(57, 17);
            this.DayRadio.TabIndex = 2;
            this.DayRadio.TabStop = true;
            this.DayRadio.Text = "днях";
            this.DayRadio.UseVisualStyleBackColor = true;
           
            this.minutesRadio.AutoSize = true;
            this.minutesRadio.Location = new System.Drawing.Point(6, 88);
            this.minutesRadio.Name = "minutesRadio";
            this.minutesRadio.Size = new System.Drawing.Size(75, 17);
            this.minutesRadio.TabIndex = 3;
            this.minutesRadio.TabStop = true;
            this.minutesRadio.Text = "хвилинах";
            this.minutesRadio.UseVisualStyleBackColor = true;
          
            this.secondsRadio.AutoSize = true;
            this.secondsRadio.Location = new System.Drawing.Point(6, 111);
            this.secondsRadio.Name = "secondsRadio";
            this.secondsRadio.Size = new System.Drawing.Size(80, 17);
            this.secondsRadio.TabIndex = 4;
            this.secondsRadio.TabStop = true;
            this.secondsRadio.Text = "секундах";
            this.secondsRadio.UseVisualStyleBackColor = true;
          
            this.textInput.Location = new System.Drawing.Point(151, 63);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(141, 20);
            this.textInput.TabIndex = 2;
            this.textInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            this.textOutput.Location = new System.Drawing.Point(151, 132);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(141, 20);
            this.textOutput.TabIndex = 3;
            this.textOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          
            this.btnOk.Location = new System.Drawing.Point(183, 97);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
          
            this.btnRes.Location = new System.Drawing.Point(183, 165);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 5;
            this.btnRes.Text = "Скинути";
            this.btnRes.UseVisualStyleBackColor = true;
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Визначення терміну \r\nдо вказаної дати";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(154, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Невірний формат дати!";
            this.label.Visible = false;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton YearRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondsRadio;
        private System.Windows.Forms.RadioButton minutesRadio;
        private System.Windows.Forms.RadioButton DayRadio;
        private System.Windows.Forms.RadioButton MonthRadio;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}

