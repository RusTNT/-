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
    public partial class ResourcesViewForm : Form
    {
        public ResourcesViewForm()
        {
            InitializeComponent();
        }

        private void ResourcesViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.resources". При необходимости она может быть перемещена или удалена.
            //this.resourcesTableAdapter.Fill(this.dataSet1.resources);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourcesViewForm.ActiveForm.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ResourcesAddForm a = new ResourcesAddForm("Редактирование товара",
                dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(), true);
            a.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void ResourcesViewForm_Activated(object sender, EventArgs e)
        {
            this.resourcesTableAdapter.Fill(this.dataSet1.resources);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string cell = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.resourcesTableAdapter resourcesTA =
                    new DataSet1TableAdapters.resourcesTableAdapter();
                resourcesTA.DeleteQuery(Convert.ToInt32(cell));
                ResourcesViewForm_Activated(sender, e);
            }
        }
    }
}
