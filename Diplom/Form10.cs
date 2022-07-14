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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void аптеки_расходBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_расходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.aptecaDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_расход". При необходимости она может быть перемещена или удалена.
            this.аптеки_расходTableAdapter.Fill(this.aptecaDataSet.Аптеки_расход);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_заболеваний". При необходимости она может быть перемещена или удалена.
           // this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
          //  this.каталог_лекарствTableAdapter.CountLekarstv(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_расход". При необходимости она может быть перемещена или удалена.
            this.аптеки_расходTableAdapter.Fill(this.aptecaDataSet.Аптеки_расход);
            this.аптеки_расходBindingSource.AddNew();
            for (int i = 0; i < dataTable1DataGridView.RowCount - 1; i++)
            {
                if (dataTable1DataGridView[7, i].Value.ToString() == "")
                    dataTable1DataGridView[7, i].Value = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Добавить запись
        private void button1_Click(object sender, EventArgs e)
        {
            if (аптекаComboBox.Text.Length == 0 || препаратComboBox.Text.Length == 0 || количествоTextBox.Text.Length == 0 || дата_расходаDateTimePicker.Text.Length == 0 || стоимость_продажиTextBox.Text.Length == 0 || количествоTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            for (int i = 0; i < dataTable1DataGridView.RowCount - 1; i++)
            {
                if (dataTable1DataGridView[1, i].Value.ToString() == препаратComboBox.Text)
                {
                    if (Convert.ToInt32(dataTable1DataGridView[7, i].Value) - Convert.ToInt32(количествоTextBox.Text) < 0)
                    {
                        MessageBox.Show("Недостаточное количество на складе!","Невозможно продать", MessageBoxButtons.OK);
                        количествоTextBox.Text = "";
                        return;
                    }
                }
            }

            this.Validate();
            this.аптеки_расходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);
            this.аптеки_расходTableAdapter.Fill(this.aptecaDataSet.Аптеки_расход);
            this.аптеки_расходBindingSource.MoveLast();
            Close();
        }

        private void аптеки_расходBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_расходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }
    }
}
