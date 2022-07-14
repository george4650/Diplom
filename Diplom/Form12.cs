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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aptecaDataSet.Сотрудники);
            this.сотрудникиBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Добавить
        private void button1_Click(object sender, EventArgs e)
        {
            if (имяTextBox.Text.Length == 0 || фамилияTextBox.Text.Length == 0 || должностьComboBox.Text.Length == 0 || зарплатаTextBox.Text.Length == 0 || дата_приемаDateTimePicker.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);
            this.сотрудникиTableAdapter.Fill(this.aptecaDataSet.Сотрудники);
            this.сотрудникиBindingSource.MoveLast();
            Close();
        }
    }
}
