namespace Курсовая
{
    partial class OrdersAddForm
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ONumtextBox = new System.Windows.Forms.TextBox();
            this.OrderDTP = new System.Windows.Forms.DateTimePicker();
            this.CustomerCombobox = new System.Windows.Forms.ComboBox();
            this.ResourceCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(178, 136);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(308, 136);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Покупатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Товар";
            // 
            // ONumtextBox
            // 
            this.ONumtextBox.Location = new System.Drawing.Point(43, 38);
            this.ONumtextBox.Name = "ONumtextBox";
            this.ONumtextBox.Size = new System.Drawing.Size(100, 20);
            this.ONumtextBox.TabIndex = 8;
            this.ONumtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ONumtextBox_KeyPress);
            // 
            // OrderDTP
            // 
            this.OrderDTP.Location = new System.Drawing.Point(295, 38);
            this.OrderDTP.Name = "OrderDTP";
            this.OrderDTP.Size = new System.Drawing.Size(138, 20);
            this.OrderDTP.TabIndex = 9;
            // 
            // CustomerCombobox
            // 
            this.CustomerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCombobox.FormattingEnabled = true;
            this.CustomerCombobox.Location = new System.Drawing.Point(43, 96);
            this.CustomerCombobox.Name = "CustomerCombobox";
            this.CustomerCombobox.Size = new System.Drawing.Size(226, 21);
            this.CustomerCombobox.TabIndex = 10;
            // 
            // ResourceCombobox
            // 
            this.ResourceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResourceCombobox.FormattingEnabled = true;
            this.ResourceCombobox.Location = new System.Drawing.Point(295, 96);
            this.ResourceCombobox.Name = "ResourceCombobox";
            this.ResourceCombobox.Size = new System.Drawing.Size(226, 21);
            this.ResourceCombobox.TabIndex = 11;
            // 
            // OrdersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 174);
            this.Controls.Add(this.ResourceCombobox);
            this.Controls.Add(this.CustomerCombobox);
            this.Controls.Add(this.OrderDTP);
            this.Controls.Add(this.ONumtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа в реестр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersAddForm_FormClosing);
            this.Shown += new System.EventHandler(this.OrdersAddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ONumtextBox;
        private System.Windows.Forms.DateTimePicker OrderDTP;
        private System.Windows.Forms.ComboBox CustomerCombobox;
        private System.Windows.Forms.ComboBox ResourceCombobox;
    }
}