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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

     

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.aptecaDataSet.DataTable1);
            this.dataTable1TableAdapter.ВыбранноеЛекарство(aptecaDataSet.DataTable1, data.Lekarstvo);
            for (int i = 0; i < dataTable1DataGridView.RowCount - 1; i++)
            {
                if (dataTable1DataGridView[7, i].Value.ToString() == "")
                    dataTable1DataGridView[7, i].Value = 0;
            }
        }
    }
}
