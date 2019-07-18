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
    public partial class CustomerViewForm : Form
    {
        public CustomerViewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            CustomerViewForm.ActiveForm.Close();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.customers". При необходимости она может быть перемещена или удалена.
            //this.customersTableAdapter.Fill(this.dataSet1.customers);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CustomerAddForm a = new CustomerAddForm("Редактирование клиента",
                dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                true);
            a.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void CustomerViewForm_Activated(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.dataSet1.customers);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string cell = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.customersTableAdapter customersTA =
                    new DataSet1TableAdapters.customersTableAdapter();
                customersTA.DeleteQuery(Convert.ToInt32(cell));
                CustomerViewForm_Activated(sender, e);
            }
        }
    }
}
