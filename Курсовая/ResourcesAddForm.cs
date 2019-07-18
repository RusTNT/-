using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class ResourcesAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, name, count;
        public ResourcesAddForm(string FormHeader, string name, string count, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.name = name;
            this.count = count;
            this.EditFlag = EditFlag;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxCount.Text != "")
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.resourcesTableAdapter resourcesTA = new DataSet1TableAdapters.resourcesTableAdapter();
                resourcesTA.Fill(newDataSet1.resources);
                if (EditFlag == false)
                {
                    resourcesTA.Insert(textBoxName.Text, textBoxCount.Text);
                }
                else
                {
                    resourcesTA.UpdateQuery(textBoxName.Text, textBoxCount.Text, name, count);
                }
                SuccessFlag = true;
                ResourcesAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
            }
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ResourcesAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void ResourcesAddForm_Shown(object sender, EventArgs e)
        {
            
            OKBtn.Top = ResourcesAddForm.ActiveForm.Height - OKBtn.Height * 3;
            CancelBtn.Top = ResourcesAddForm.ActiveForm.Height - CancelBtn.Height * 3;
            OKBtn.Left = ResourcesAddForm.ActiveForm.Width / 2 - OKBtn.Width - OKBtn.Width / 2;
            CancelBtn.Left = ResourcesAddForm.ActiveForm.Width / 2 + CancelBtn.Width / 2;
            ResourcesAddForm.ActiveForm.Text = FormHeader;
            textBoxName.Text = name;
            textBoxCount.Text = count;
            textBoxName.Focus();
            SuccessFlag = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ResourcesAddForm.ActiveForm.Close();
        }
    }
}
