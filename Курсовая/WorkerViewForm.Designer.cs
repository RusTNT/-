namespace Курсовая
{
    partial class WorkerViewForm
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
            this.components = new System.ComponentModel.Container();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.worker_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerfioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerbornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Курсовая.DataSet1();
            this.workerTableAdapter = new Курсовая.DataSet1TableAdapters.workerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(330, 265);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerloginDataGridViewTextBoxColumn,
            this.workerpasswordDataGridViewTextBoxColumn,
            this.workertypeDataGridViewTextBoxColumn,
            this.workerfioDataGridViewTextBoxColumn,
            this.workerbornDataGridViewTextBoxColumn,
            this.worker_id});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(440, 215);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(86, 265);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // worker_id
            // 
            this.worker_id.DataPropertyName = "worker_id";
            this.worker_id.HeaderText = "worker_id";
            this.worker_id.Name = "worker_id";
            this.worker_id.ReadOnly = true;
            this.worker_id.Visible = false;
            // 
            // workerloginDataGridViewTextBoxColumn
            // 
            this.workerloginDataGridViewTextBoxColumn.DataPropertyName = "worker_login";
            this.workerloginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.workerloginDataGridViewTextBoxColumn.Name = "workerloginDataGridViewTextBoxColumn";
            this.workerloginDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerloginDataGridViewTextBoxColumn.Width = 60;
            // 
            // workerpasswordDataGridViewTextBoxColumn
            // 
            this.workerpasswordDataGridViewTextBoxColumn.DataPropertyName = "worker_password";
            this.workerpasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.workerpasswordDataGridViewTextBoxColumn.Name = "workerpasswordDataGridViewTextBoxColumn";
            this.workerpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerpasswordDataGridViewTextBoxColumn.Width = 60;
            // 
            // workertypeDataGridViewTextBoxColumn
            // 
            this.workertypeDataGridViewTextBoxColumn.DataPropertyName = "worker_type";
            this.workertypeDataGridViewTextBoxColumn.HeaderText = "Права";
            this.workertypeDataGridViewTextBoxColumn.Name = "workertypeDataGridViewTextBoxColumn";
            this.workertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workertypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // workerfioDataGridViewTextBoxColumn
            // 
            this.workerfioDataGridViewTextBoxColumn.DataPropertyName = "worker_fio";
            this.workerfioDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.workerfioDataGridViewTextBoxColumn.Name = "workerfioDataGridViewTextBoxColumn";
            this.workerfioDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerfioDataGridViewTextBoxColumn.Width = 120;
            // 
            // workerbornDataGridViewTextBoxColumn
            // 
            this.workerbornDataGridViewTextBoxColumn.DataPropertyName = "worker_born";
            this.workerbornDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.workerbornDataGridViewTextBoxColumn.Name = "workerbornDataGridViewTextBoxColumn";
            this.workerbornDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerbornDataGridViewTextBoxColumn.Width = 120;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // WorkerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр сотрудников";
            this.Activated += new System.EventHandler(this.WorkerViewForm_Activated);
            this.Load += new System.EventHandler(this.WorkerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private DataSet1TableAdapters.workerTableAdapter workerTableAdapter;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerfioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerbornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_id;
    }
}