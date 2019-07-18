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
    public partial class CustomerAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, c_FIO, company, number, address;

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        public CustomerAddForm(string FormHeader, string c_FIO, string company, string number, string address, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.c_FIO = c_FIO;
            this.company = company;
            this.number = number;
            this.address = address;
            this.EditFlag = EditFlag;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text != "" && textBoxCompany.Text != "" && textBoxNum.Text != "" && textBoxAddress.Text != "")
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.customersTableAdapter customerTA = new DataSet1TableAdapters.customersTableAdapter();
                customerTA.Fill(newDataSet1.customers);

                if (EditFlag == false)
                {
                    customerTA.Insert(textBoxFIO.Text, textBoxCompany.Text, textBoxNum.Text, textBoxAddress.Text);
                }
                else
                {
                    customerTA.UpdateQuery(textBoxFIO.Text, textBoxCompany.Text, textBoxNum.Text, textBoxAddress.Text,
                        c_FIO, company, number, address);
                }
                SuccessFlag = true;
                WorkerAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFIO.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CustomerAddForm.ActiveForm.Close();
        }

        private void CustomerAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void CustomerAddForm_Shown(object sender, EventArgs e)
        {
            textBoxFIO.Text = "";
            textBoxFIO.Focus();
            SuccessFlag = false;
            OKBtn.Top = CustomerAddForm.ActiveForm.Height - OKBtn.Height * 3;
            CancelBtn.Top = CustomerAddForm.ActiveForm.Height - CancelBtn.Height * 3;
            OKBtn.Left = CustomerAddForm.ActiveForm.Width / 2 - OKBtn.Width - OKBtn.Width / 2;
            CancelBtn.Left = CustomerAddForm.ActiveForm.Width / 2 + CancelBtn.Width / 2;
            CustomerAddForm.ActiveForm.Text = FormHeader;
            textBoxFIO.Text = c_FIO;
            textBoxCompany.Text = company;
            textBoxNum.Text = number;
            textBoxAddress.Text = address;

        }
    }
}
