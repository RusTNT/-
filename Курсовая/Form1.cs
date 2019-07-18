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
    public partial class Form1 : Form
    {
        public string login, password;
        public bool OrderShowFlag = false;
        public Form1(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OrdersAddForm a = new OrdersAddForm("Добавление новой поставки", "", "", "", DateTime.Now, false, 0);
            a.ShowDialog();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            OrderDGV.Width = Form1.ActiveForm.Width - 33;
            OrderDGV.Height = Form1.ActiveForm.Height - 220;
            OrderCloseBtn.Top = Form1.ActiveForm.Height - 70;
            OrderEditBtn.Top = Form1.ActiveForm.Height - 70;
            OrderDeleteBtn.Top = Form1.ActiveForm.Height - 70;
            OrderEditBtn.Left = Form1.ActiveForm.Width / 2 - OrderDeleteBtn.Width / 2 - OrderEditBtn.Width - 70;
            OrderDeleteBtn.Left = Form1.ActiveForm.Width / 2 - OrderDeleteBtn.Width / 2;
            OrderCloseBtn.Left = Form1.ActiveForm.Width / 2 + OrderDeleteBtn.Width / 2 + OrderCloseBtn.Width;
            OrderDGV.Columns[0].Width = 150;
            OrderDGV.Columns[2].Width = OrderDGV.Width / 4 - 50;
            OrderDGV.Columns[3].Width = OrderDGV.Width / 4 - 75;
            OrderDGV.Columns[1].Width = OrderDGV.Width - (OrderDGV.Columns[0].Width +
                OrderDGV.Columns[2].Width + OrderDGV.Columns[3].Width + 40);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataSet1 newDataSet1 = new DataSet1();
            DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
            workerTA.Fill(newDataSet1.worker);
            workerTA.Adapter.SelectCommand.CommandText = "SELECT * FROM worker WHERE worker_login='" +
                login + "' and worker_password ='" + password + "'" + " and worker_type = 'Администратор'";
            workerTA.Fill(newDataSet1.worker);
            if (newDataSet1.worker.Rows.Count == 1)
            {
                WorkerAddForm a = new WorkerAddForm("Добавление нового сотрудника", "", "", "", "", DateTime.Now, false);
                a.ShowDialog();
            }
            else
            {

                MessageBox.Show("Действие доступно только администратору");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox6_Click(sender, e);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            pictureBox6_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CustomerAddForm a = new CustomerAddForm("Добавление нового клиента", "", "", "", "", false);
            a.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CustomerAddForm a = new CustomerAddForm("Добавление нового клиента", "", "", "", "", false);
            a.ShowDialog();
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            CustomerAddForm a = new CustomerAddForm("Добавление нового клиента", "", "", "", "", false);
            a.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ResourcesAddForm a = new ResourcesAddForm("Добавление нового товара", "", "", false);
            a.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ResourcesAddForm a = new ResourcesAddForm("Добавление нового товара", "", "", false);
            a.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ResourcesAddForm a = new ResourcesAddForm("Добавление нового товара", "", "", false);
            a.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DataSet1 newDataSet1 = new DataSet1();
            DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
            workerTA.Fill(newDataSet1.worker);
            workerTA.Adapter.SelectCommand.CommandText = "SELECT * FROM worker WHERE worker_login='" +
                login + "' and worker_password ='" + password + "'" + " and worker_type = 'Администратор'";
            workerTA.Fill(newDataSet1.worker);
            if (newDataSet1.worker.Rows.Count == 1)
            {
                WorkerViewForm a = new WorkerViewForm();
                a.ShowDialog();
            }
            else
            {

                MessageBox.Show("Действие доступно только администратору");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox9_Click(sender, e);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            pictureBox9_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CustomerViewForm a = new CustomerViewForm();
            a.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CustomerViewForm a = new CustomerViewForm();
            a.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            CustomerViewForm a = new CustomerViewForm();
            a.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ResourcesViewForm a = new ResourcesViewForm();
            a.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ResourcesViewForm a = new ResourcesViewForm();
            a.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ResourcesViewForm a = new ResourcesViewForm();
            a.ShowDialog();
        }

        private void OrderCloseBtn_Click(object sender, EventArgs e)
        {
            OrderDGV.Visible = false;
            OrderCloseBtn.Visible = false;
            OrderShowFlag = false;
            OrderDeleteBtn.Visible = false;
            OrderEditBtn.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OrderDGV.Width = Form1.ActiveForm.Width - 33;
            OrderDGV.Height = Form1.ActiveForm.Height - 220;
            OrderCloseBtn.Top = Form1.ActiveForm.Height - 70;
            OrderEditBtn.Top = Form1.ActiveForm.Height - 70;
            OrderDeleteBtn.Top = Form1.ActiveForm.Height - 70;
            OrderEditBtn.Left = Form1.ActiveForm.Width / 2 - OrderDeleteBtn.Width / 2 - OrderEditBtn.Width - 70;
            OrderDeleteBtn.Left = Form1.ActiveForm.Width / 2 - OrderDeleteBtn.Width / 2;
            OrderCloseBtn.Left = Form1.ActiveForm.Width / 2 + OrderDeleteBtn.Width / 2 + OrderCloseBtn.Width;
            OrderDGV.Columns[0].Width = 150;
            OrderDGV.Columns[2].Width = OrderDGV.Width / 4 - 50;
            OrderDGV.Columns[3].Width = OrderDGV.Width / 4 - 75;
            OrderDGV.Columns[1].Width = OrderDGV.Width - (OrderDGV.Columns[0].Width +
                OrderDGV.Columns[2].Width + OrderDGV.Columns[3].Width + 40);
            OrderDGV.Rows.Clear();

            DateTime onlyDate;

            DataSet1 newDataSet1 = new DataSet1();
            DataTable orderTable = newDataSet1.orders;
            DataSet1TableAdapters.ordersTableAdapter orderTA = new DataSet1TableAdapters.ordersTableAdapter();
            orderTA.Fill(newDataSet1.orders);
            orderTA.Adapter.SelectCommand.CommandText = "SELECT orders.order_num, customers.customer_FIO, resources.resources_name, orders.order_date, orders.order_id FROM orders INNER JOIN customers ON orders.customer_id = customers.customer_id INNER JOIN resources ON orders.resources_id = resources.resources_id ORDER BY orders.order_num DESC";
            orderTA.Fill(newDataSet1.orders);
            DataRow[] foundRowsOrders = orderTable.Select();
            foreach (DataRow rowOrders in foundRowsOrders)
            {
                onlyDate = DateTime.Parse(rowOrders["order_date"].ToString());
                OrderDGV.Rows.Add(rowOrders["order_num"].ToString(), rowOrders["customer_FIO"].ToString(),
                    rowOrders["resources_name"].ToString(), onlyDate.ToShortDateString(), rowOrders["order_id"].ToString());
            }
            OrderDGV.Visible = true;
            OrderCloseBtn.Visible = true;
            OrderShowFlag = true;
            OrderDeleteBtn.Visible = true;
            OrderEditBtn.Visible = true;
        }

        private void OrderEditBtn_Click(object sender, EventArgs e)
        {
            OrdersAddForm a = new OrdersAddForm("Изменение поставки", OrderDGV.CurrentRow.Cells[0].Value.ToString(),
                OrderDGV.CurrentRow.Cells[1].Value.ToString(),
                OrderDGV.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToDateTime(OrderDGV.CurrentRow.Cells[3].Value.ToString()), true, Convert.ToInt32(OrderDGV.CurrentRow.Cells[4].Value.ToString()));
            a.ShowDialog();

        }

        private void OrderDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderEditBtn_Click(sender, e);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (OrderShowFlag == true)
            {
                OrderDGV.Rows.Clear();
                DateTime onlyDate;
                DataSet1 newDataSet1 = new DataSet1();
                DataTable orderTable = newDataSet1.orders;
                DataSet1TableAdapters.ordersTableAdapter orderTA = new DataSet1TableAdapters.ordersTableAdapter();
                orderTA.Fill(newDataSet1.orders);
                orderTA.Adapter.SelectCommand.CommandText = "SELECT orders.order_num, customers.customer_FIO, resources.resources_name, orders.order_date, orders.order_id FROM orders INNER JOIN customers ON orders.customer_id = customers.customer_id INNER JOIN resources ON orders.resources_id = resources.resources_id ORDER BY orders.order_num DESC";
                orderTA.Fill(newDataSet1.orders);

                DataRow[] foundRowsOrders = orderTable.Select();
                foreach (DataRow rowOrders in foundRowsOrders)
                {
                    onlyDate = DateTime.Parse(rowOrders["order_date"].ToString());
                    OrderDGV.Rows.Add(rowOrders["order_num"].ToString(), rowOrders["customer_FIO"].ToString(),
                        rowOrders["resources_name"].ToString(), onlyDate.ToShortDateString(), rowOrders["order_id"].ToString());
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            return;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            return;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label7.Text = label7.Text + login;
            label14.Text = label14.Text + login;
            label20.Text = label20.Text + login;
            label17.Text = label17.Text + login;
            DataSet1 newDataSet1 = new DataSet1();
            DateTime onlyDate;
            DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
            workerTA.Fill(newDataSet1.worker);
            workerTA.Adapter.SelectCommand.CommandText = "SELECT * FROM worker WHERE worker_login='" +
                login + "' and worker_password ='" + password + "'";
            workerTA.Fill(newDataSet1.worker);
            DataTable workerTable = newDataSet1.worker;
            DataRow[] foundRowsWorkers = workerTable.Select();

            foreach (DataRow rowWork in foundRowsWorkers)
            {
                label10.Text =label10.Text + rowWork["worker_fio"].ToString();
                label13.Text = label10.Text;
                label16.Text = label10.Text;
                label19.Text = label10.Text;
                onlyDate = DateTime.Parse(rowWork["worker_born"].ToString());
                label11.Text = label11.Text + onlyDate.Date.ToString("yyyy-MM-dd");
                label12.Text = label11.Text;
                label15.Text = label11.Text;
                label18.Text = label11.Text;
            }
        }

        private void OrderDeleteBtn_Click(object sender, EventArgs e)
        {
            string cell = OrderDGV.CurrentRow.Cells[4].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DateTime onlyDate;

                DataSet1 newDataSet1 = new DataSet1();
                DataTable orderTable = newDataSet1.orders;
                DataSet1TableAdapters.ordersTableAdapter orderTA = new DataSet1TableAdapters.ordersTableAdapter();
                orderTA.Fill(newDataSet1.orders);
                orderTA.DeleteQuery(Convert.ToInt32(cell));

                orderTA.Fill(newDataSet1.orders);
                orderTA.Adapter.SelectCommand.CommandText = "SELECT orders.order_num, customers.customer_FIO, resources.resources_name, orders.order_date, orders.order_id FROM orders INNER JOIN customers ON orders.customer_id = customers.customer_id INNER JOIN resources ON orders.resources_id = resources.resources_id ORDER BY orders.order_num DESC";
                orderTA.Fill(newDataSet1.orders);

                OrderDGV.Rows.Clear();

                DataRow[] foundRowsOrders = orderTable.Select();
                foreach (DataRow rowOrders in foundRowsOrders)
                {
                    onlyDate = DateTime.Parse(rowOrders["order_date"].ToString());
                    OrderDGV.Rows.Add(rowOrders["order_num"].ToString(), rowOrders["customer_FIO"].ToString(),
                        rowOrders["resources_name"].ToString(), onlyDate.ToShortDateString(), rowOrders["order_id"].ToString());
                }
            }
        }
    }
}
