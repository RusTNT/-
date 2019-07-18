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
    public partial class WorkerViewForm : Form
    {
        public WorkerViewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            WorkerViewForm.ActiveForm.Close();
        }

        private void WorkerViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.worker". При необходимости она может быть перемещена или удалена.
            //this.workerTableAdapter.Fill(this.dataSet1.worker);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DateTime onlyDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            WorkerAddForm a = new WorkerAddForm("Редактирование данных о сотруднике", 
                dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                onlyDate, true);
            a.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void WorkerViewForm_Activated(object sender, EventArgs e)
        {
            this.workerTableAdapter.Fill(this.dataSet1.worker);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cell = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?",
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataSet1 newDataSet1 = new DataSet1();
                DataSet1TableAdapters.workerTableAdapter workerTA = new DataSet1TableAdapters.workerTableAdapter();
                workerTA.DeleteQuery(Convert.ToInt32(cell));
                WorkerViewForm_Activated(sender, e);
            }
        }
    }
}
