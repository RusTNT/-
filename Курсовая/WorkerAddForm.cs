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
    public partial class WorkerAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, FIO, Login, Password, tipe;
        public DateTime BornDate;


        public WorkerAddForm(string FormHeader, string FIO, string Login, string Password, string tipe, DateTime BornDate, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.FIO = FIO;
            this.Login = Login;
            this.Password = Password;
            this.tipe = tipe;
            this.BornDate = BornDate;
            this.EditFlag = EditFlag;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            WorkerAddForm.ActiveForm.Close();
        }

        private void WorkerAddForm_Shown(object sender, EventArgs e)
        {
            FIOtextBox.Text = "";
            FIOtextBox.Focus();
            SuccessFlag = false;
            OKBtn.Top = WorkerAddForm.ActiveForm.Height - OKBtn.Height * 3;
            CancelBtn.Top = WorkerAddForm.ActiveForm.Height - CancelBtn.Height * 3;
            OKBtn.Left = WorkerAddForm.ActiveForm.Width / 2 - OKBtn.Width - OKBtn.Width / 2;
            CancelBtn.Left = WorkerAddForm.ActiveForm.Width / 2 + CancelBtn.Width / 2;
            WorkerAddForm.ActiveForm.Text = FormHeader;
            FIOtextBox.Text = FIO;
            LogintextBox.Text = Login;
            PsswdtextBox.Text = Password;
            comboBox1.Text = tipe;
            BornDTP.Value = BornDate;
            FIOtextBox.Focus();
            SuccessFlag = false;

        }

        private void WorkerAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (FIOtextBox.Text != "" && LogintextBox.Text != "" && PsswdtextBox.Text != "")
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
                workerTA.Fill(newDataSet1.worker);
                if (EditFlag == false)
                {
                    workerTA.Insert(LogintextBox.Text, PsswdtextBox.Text, comboBox1.Text, FIOtextBox.Text, BornDTP.Value.Date);
                }
                else
                {
                    workerTA.UpdateQuery(LogintextBox.Text, PsswdtextBox.Text, comboBox1.Text, FIOtextBox.Text, Convert.ToString(BornDTP.Value.Date),
                        Login, Password, tipe, FIO, Convert.ToString(BornDate));
                }
                SuccessFlag = true;
                WorkerAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FIOtextBox.Focus();
            }
        }
    }
}
