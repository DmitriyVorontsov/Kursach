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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LogInnTextBox = new System.Windows.Forms.TextBox();
            this.LogPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.RegInnTextBox = new System.Windows.Forms.TextBox();
            this.RegFioTextBox = new System.Windows.Forms.TextBox();
            this.RegMailTextBox = new System.Windows.Forms.TextBox();
            this.RegPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LogPasswordTextBox);
            this.groupBox1.Controls.Add(this.LogInnTextBox);
            this.groupBox1.Controls.Add(this.ButtonLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вход";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(5, 305);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(180, 23);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LogInnTextBox
            // 
            this.LogInnTextBox.Location = new System.Drawing.Point(6, 60);
            this.LogInnTextBox.MaxLength = 12;
            this.LogInnTextBox.Name = "LogInnTextBox";
            this.LogInnTextBox.Size = new System.Drawing.Size(288, 22);
            this.LogInnTextBox.TabIndex = 1;
            // 
            // LogPasswordTextBox
            // 
            this.LogPasswordTextBox.Location = new System.Drawing.Point(6, 120);
            this.LogPasswordTextBox.MaxLength = 25;
            this.LogPasswordTextBox.Name = "LogPasswordTextBox";
            this.LogPasswordTextBox.Size = new System.Drawing.Size(288, 22);
            this.LogPasswordTextBox.TabIndex = 2;
            this.LogPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RegPasswordTextBox);
            this.groupBox2.Controls.Add(this.RegMailTextBox);
            this.groupBox2.Controls.Add(this.RegFioTextBox);
            this.groupBox2.Controls.Add(this.RegInnTextBox);
            this.groupBox2.Controls.Add(this.buttonReg);
            this.groupBox2.Location = new System.Drawing.Point(318, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистрация";
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(9, 305);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(180, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            // 
            // RegInnTextBox
            // 
            this.RegInnTextBox.Location = new System.Drawing.Point(6, 60);
            this.RegInnTextBox.MaxLength = 12;
            this.RegInnTextBox.Name = "RegInnTextBox";
            this.RegInnTextBox.Size = new System.Drawing.Size(278, 22);
            this.RegInnTextBox.TabIndex = 1;
            // 
            // RegFioTextBox
            // 
            this.RegFioTextBox.Location = new System.Drawing.Point(7, 120);
            this.RegFioTextBox.MaxLength = 25;
            this.RegFioTextBox.Name = "RegFioTextBox";
            this.RegFioTextBox.Size = new System.Drawing.Size(277, 22);
            this.RegFioTextBox.TabIndex = 2;
            this.RegFioTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // RegMailTextBox
            // 
            this.RegMailTextBox.Location = new System.Drawing.Point(6, 180);
            this.RegMailTextBox.MaxLength = 25;
            this.RegMailTextBox.Name = "RegMailTextBox";
            this.RegMailTextBox.Size = new System.Drawing.Size(278, 22);
            this.RegMailTextBox.TabIndex = 3;
            // 
            // RegPasswordTextBox
            // 
            this.RegPasswordTextBox.Location = new System.Drawing.Point(6, 240);
            this.RegPasswordTextBox.MaxLength = 25;
            this.RegPasswordTextBox.Name = "RegPasswordTextBox";
            this.RegPasswordTextBox.Size = new System.Drawing.Size(278, 22);
            this.RegPasswordTextBox.TabIndex = 4;
            this.RegPasswordTextBox.UseSystemPasswordChar = true;
            this.RegPasswordTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Электронная почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form1";
            this.Text = "Добро пожаловать";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogPasswordTextBox;
        private System.Windows.Forms.TextBox LogInnTextBox;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegPasswordTextBox;
        private System.Windows.Forms.TextBox RegMailTextBox;
        private System.Windows.Forms.TextBox RegFioTextBox;
        private System.Windows.Forms.TextBox RegInnTextBox;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

