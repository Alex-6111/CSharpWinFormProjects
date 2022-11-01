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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBox1.Location = new System.Drawing.Point(74, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 0;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім'я";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Прізвище";

            this.textBox2.Location = new System.Drawing.Point(74, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " e-mail";

            this.textBox3.Location = new System.Drawing.Point(74, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 4;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Моб. тел.";

            this.textBox4.Location = new System.Drawing.Point(74, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 20);
            this.textBox4.TabIndex = 6;

            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button1_KeyDown);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseDown);

            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(238, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(538, 381);
            this.listBox1.TabIndex = 9;

            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Редагувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button2_KeyDown);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseDown);

            this.button3.Location = new System.Drawing.Point(12, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button3_KeyDown);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseDown);

            this.button4.Location = new System.Drawing.Point(12, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "Імпорт TXT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button4_KeyDown);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button4_MouseDown);

            this.button5.Location = new System.Drawing.Point(12, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "Імпорт XML";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button5_KeyDown);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button5_MouseDown);

            this.button6.Location = new System.Drawing.Point(12, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "Експорт XML";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button6_KeyDown);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button6_MouseDown);

            this.button7.Location = new System.Drawing.Point(12, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 32);
            this.button7.TabIndex = 15;
            this.button7.Text = "Експорт TXT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button7_KeyDown);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button7_MouseDown);

            this.button8.Location = new System.Drawing.Point(12, 240);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 32);
            this.button8.TabIndex = 17;
            this.button8.Text = "Відмінити";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button8_KeyDown);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button8_MouseDown);

            this.button9.Location = new System.Drawing.Point(12, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 32);
            this.button9.TabIndex = 16;
            this.button9.Text = "Зберегти";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button9_KeyDown);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseDown);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

    }
}

