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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.aptecaDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.aptecaDataSet.DataTable1);
            //Выводим подходящие записи
            this.dataTable1TableAdapter.КаталогЛекарств(aptecaDataSet.DataTable1, data.zabolevanie);
            for (int i = 0; i < dataTable1DataGridView.RowCount - 1; i++)
            {
                if (dataTable1DataGridView[7, i].Value.ToString() == "")
                    dataTable1DataGridView[7, i].Value = 0;
            }


            int koll = -1; //Изначальное количество препаратов 
            for (int j = 0; j < dataTable1DataGridView.RowCount; j++)
            {
                koll++; //Увеличеваем кол-во лекарств на 1
            }
            textBox1.Text = Convert.ToString(koll); //Вывод кол-ва препаратов
        }

        //Выйти
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
