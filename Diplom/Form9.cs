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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void аптеки_приходBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_приходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.aptecaDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_приход". При необходимости она может быть перемещена или удалена.
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);
            //Добавляем новую строчку 
            this.аптеки_приходBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Составить приход
        private void button1_Click(object sender, EventArgs e)
        {
            if (название_аптекиComboBox.Text.Length == 0 || препаратComboBox.Text.Length == 0 || количествоTextBox.Text.Length == 0 || стоимостьTextBox.Text.Length == 0 || поставщикComboBox.Text.Length == 0 || дата_приходаDateTimePicker.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            this.Validate();
            this.аптеки_приходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);
            this.аптеки_приходBindingSource.MoveLast();
            Close();
        }
    }
}
