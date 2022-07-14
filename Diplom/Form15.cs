using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        //    this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.aptecaDataSet.DataTable1);

            for (int i=0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1[7, i].Value.ToString() == "")
                    dataGridView1[7, i].Value = 0;
            }
        }
    }
}
