namespace WindowsFormsApp2
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.LftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.ProfitButton = new System.Windows.Forms.Button();
            this.TaxButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.AskButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.BonusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Январь, 2021";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LftButton
            // 
            this.LftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LftButton.Location = new System.Drawing.Point(12, 12);
            this.LftButton.Name = "LftButton";
            this.LftButton.Size = new System.Drawing.Size(75, 61);
            this.LftButton.TabIndex = 1;
            this.LftButton.Text = "<";
            this.LftButton.UseVisualStyleBackColor = true;
            this.LftButton.Click += new System.EventHandler(this.LftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton.Location = new System.Drawing.Point(535, 12);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 61);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // ProfitButton
            // 
            this.ProfitButton.Enabled = false;
            this.ProfitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfitButton.Location = new System.Drawing.Point(12, 79);
            this.ProfitButton.Name = "ProfitButton";
            this.ProfitButton.Size = new System.Drawing.Size(598, 60);
            this.ProfitButton.TabIndex = 3;
            this.ProfitButton.Text = "Доход за месяц: 0р";
            this.ProfitButton.UseVisualStyleBackColor = true;
            // 
            // TaxButton
            // 
            this.TaxButton.Enabled = false;
            this.TaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaxButton.Location = new System.Drawing.Point(12, 146);
            this.TaxButton.Name = "TaxButton";
            this.TaxButton.Size = new System.Drawing.Size(598, 60);
            this.TaxButton.TabIndex = 4;
            this.TaxButton.Text = "Предварительный налог: 0р";
            this.TaxButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.ProductName,
            this.Price,
            this.Customer});
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(598, 317);
            this.dataGridView1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(420, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Задолженность: 0р";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AskButton
            // 
            this.AskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskButton.Location = new System.Drawing.Point(311, 601);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(299, 60);
            this.AskButton.TabIndex = 7;
            this.AskButton.Text = "Задать вопрос";
            this.AskButton.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.DefaultCellStyle = dataGridViewCellStyle6;
            this.Date.HeaderText = "дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название товара";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Сумма сделки";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Покупатель";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 125;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(12, 675);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(598, 60);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Новая продажа";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(441, 212);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(169, 60);
            this.PayButton.TabIndex = 9;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = true;
            // 
            // BonusButton
            // 
            this.BonusButton.Enabled = false;
            this.BonusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonusButton.Location = new System.Drawing.Point(12, 601);
            this.BonusButton.Name = "BonusButton";
            this.BonusButton.Size = new System.Drawing.Size(293, 60);
            this.BonusButton.TabIndex = 10;
            this.BonusButton.Text = "Бонус на оплату налога: 10000р";
            this.BonusButton.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 753);
            this.Controls.Add(this.BonusButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AskButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TaxButton);
            this.Controls.Add(this.ProfitButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LftButton);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 800);
            this.MinimumSize = new System.Drawing.Size(640, 800);
            this.Name = "UserForm";
            this.Text = "Плати налог";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button ProfitButton;
        private System.Windows.Forms.Button TaxButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button BonusButton;
    }
}