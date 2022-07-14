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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aptecaDataSet.Сотрудники);

            //Рассчёт итоговой зарплаты
            int koll = 0;
            for (int j = 0; j < сотрудникиDataGridView.RowCount; j++)
            {
                koll += Convert.ToInt32(сотрудникиDataGridView[4, j].Value);
            }
            textBox1.Text = Convert.ToString(koll); //Вывод общей з/п
          
        }

        private void сотрудникиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Добавить
        private void button2_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            fr12.ShowDialog();
            this.сотрудникиTableAdapter.Fill(this.aptecaDataSet.Сотрудники);

            //Рассчёт итоговой зарплаты
            int koll = 0;
            for (int j = 0; j < сотрудникиDataGridView.RowCount; j++)
            {
                koll += Convert.ToInt32(сотрудникиDataGridView[4, j].Value);
            }
            textBox1.Text = Convert.ToString(koll); //Вывод общей з/п
        }

        //Уволить сотрудника
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Удаление записи", "Подвердите удаление записи",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                data.kod = Convert.ToInt32(сотрудникиDataGridView[0, сотрудникиDataGridView.CurrentCell.RowIndex].Value);
                //Удаляем текущую запись
                this.сотрудникиTableAdapter.УдалитьСотрудника(data.kod);
                
                //Запоминаем текущую запись
                int row, col;
                row = сотрудникиDataGridView.CurrentCell.RowIndex;
                col = сотрудникиDataGridView.CurrentCell.ColumnIndex;
                this.сотрудникиTableAdapter.Fill(this.aptecaDataSet.Сотрудники);
                сотрудникиDataGridView.CurrentCell = сотрудникиDataGridView[col, row];

                //Рассчёт итоговой зарплаты
                int koll = 0;
                for (int j = 0; j < сотрудникиDataGridView.RowCount - 1; j++)
                {
                    koll += Convert.ToInt32(сотрудникиDataGridView[4, j].Value);
                }
                textBox1.Text = Convert.ToString(koll); //Вывод общей з/п
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
