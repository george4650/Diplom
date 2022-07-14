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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void аптеки_приходBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_приходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.aptecaDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_приход". При необходимости она может быть перемещена или удалена.
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.aptecaDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_приход". При необходимости она может быть перемещена или удалена.
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);

        }

        //Закрыть
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          аптеки_приходBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MoveFirst();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
            this.аптеки_приходTableAdapter.Fill(this.aptecaDataSet.Аптеки_приход);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MoveNext();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            аптеки_приходBindingSource.MoveFirst();
        }

        private void аптеки_приходBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_приходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }
    }
}
