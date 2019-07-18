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
    public partial class OrdersAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, ONum, costum, res;
        public DateTime OrderDate;
        public int EditID;
        public OrdersAddForm(string FormHeader, string ONum, string costum, string res, DateTime OrderDate, bool EditFlag, int EditID)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.ONum = ONum;
            this.costum = costum;
            this.res = res;
            this.OrderDate = OrderDate;
            this.EditFlag = EditFlag;
            this.EditID = EditID;
        }

        private void ONumtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (ONumtextBox.Text !="" && CustomerCombobox.Text !="" && ResourceCombobox.Text !="")
            {
                string FIO = "";
                int i = 0, j = 0;

                FIO = CustomerCombobox.Text;


                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.customersTableAdapter customersTA = new DataSet1TableAdapters.customersTableAdapter();
                customersTA.Fill(newDataSet1.customers);
                DataSet1TableAdapters.resourcesTableAdapter resourcesTA = new DataSet1TableAdapters.resourcesTableAdapter();
                resourcesTA.Fill(newDataSet1.resources);
                DataSet1TableAdapters.ordersTableAdapter ordersTA = new DataSet1TableAdapters.ordersTableAdapter();
                ordersTA.Fill(newDataSet1.orders);

                DataTable CustomerTable = newDataSet1.customers;
                DataRow[] foundRowsCustomers;
                customersTA.Adapter.SelectCommand.CommandText = "SELECT customer_id FROM customers WHERE (customer_FIO='" + FIO + "')";
                customersTA.Fill(newDataSet1.customers);
                foundRowsCustomers = CustomerTable.Select();
                i = Convert.ToInt32(foundRowsCustomers[0]["customer_id"].ToString());

                DataTable ResourcesTable = newDataSet1.resources;
                DataRow[] foundRowsDetails;
                resourcesTA.Adapter.SelectCommand.CommandText = "SELECT resources_id FROM resources WHERE resources_name='" + ResourceCombobox.Text + "'";
                resourcesTA.Fill(newDataSet1.resources);
                foundRowsDetails = ResourcesTable.Select();
                j = Convert.ToInt32(foundRowsDetails[0]["resources_id"].ToString());
                if (EditFlag == false)
                {
                    ordersTA.Insert(ONumtextBox.Text, OrderDTP.Value.Date.ToString(), i, j);
                }
                else
                {
                    ordersTA.UpdateQuery(ONumtextBox.Text, OrderDTP.Value.Date.ToString(), i, j, EditID);
                }
                SuccessFlag = true;
                OrdersAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Должны быть заполнены все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ONumtextBox.Focus();
            }
        }

        private void OrdersAddForm_Shown(object sender, EventArgs e)
        {
            OrdersAddForm.ActiveForm.Text = FormHeader;
            ONumtextBox.Text = ONum;
            CustomerCombobox.Text = costum;
            ResourceCombobox.Text = res;
            OrderDTP.Value = OrderDate;


            DataSet1 newDataSet1 = new DataSet1();
            DataSet1TableAdapters.customersTableAdapter customersTA = new DataSet1TableAdapters.customersTableAdapter();
            customersTA.Fill(newDataSet1.customers);
            DataSet1TableAdapters.resourcesTableAdapter resourcesTA = new DataSet1TableAdapters.resourcesTableAdapter();
            resourcesTA.Fill(newDataSet1.resources);

            DataTable customersTable = newDataSet1.customers;
            DataRow[] foundRowsCustomers;
            foundRowsCustomers = customersTable.Select();
            foreach (DataRow rowCustomers in foundRowsCustomers)
            {
                CustomerCombobox.Items.Add(rowCustomers["customer_FIO"].ToString());
            }

            DataTable resourcesTable = newDataSet1.resources;
            DataRow[] foundRowsResources;
            foundRowsResources = resourcesTable.Select();
            foreach (DataRow rowResources in foundRowsResources)
            {
                ResourceCombobox.Items.Add(rowResources["resources_Name"].ToString());
            }
 
            SuccessFlag = false;
            OKBtn.Top = OrdersAddForm.ActiveForm.Height - OKBtn.Height * 3;
            CancelBtn.Top = OrdersAddForm.ActiveForm.Height - CancelBtn.Height * 3;
            OKBtn.Left = OrdersAddForm.ActiveForm.Width / 2 - OKBtn.Width - OKBtn.Width / 2;
            CancelBtn.Left = OrdersAddForm.ActiveForm.Width / 2 + CancelBtn.Width / 2;


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            OrdersAddForm.ActiveForm.Close();
        }

        private void OrdersAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }
    }
}
