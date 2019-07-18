using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Курсовая
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            if (Process.GetProcessesByName("Курсовая").Length > 1)
            {
                MessageBox.Show("Программа уже запущена");
                Process.GetCurrentProcess().Kill();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 newDataSet1 = new DataSet1();
            DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
            workerTA.Fill(newDataSet1.worker);
            workerTA.Adapter.SelectCommand.CommandText = "SELECT * FROM worker WHERE worker_login='" +
                login.Text.Trim() + "' and worker_password ='" + psswd.Text.Trim() + "'";
            workerTA.Fill(newDataSet1.worker);
            if (newDataSet1.worker.Rows.Count == 1)
            {
                this.Hide();
                Form1 a = new Form1(login.Text.Trim(), psswd.Text.Trim());
                a.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, обратитесь к Администратору");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            return;
        }
    }
}
