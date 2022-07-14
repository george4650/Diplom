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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void аптеки_расходBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аптеки_расходBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.aptecaDataSet.Аптеки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Аптеки_расход". При необходимости она может быть перемещена или удалена.
            this.аптеки_расходTableAdapter.Fill(this.aptecaDataSet.Аптеки_расход);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.ShowDialog();
            this.аптеки_расходTableAdapter.Fill(this.aptecaDataSet.Аптеки_расход);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            аптеки_расходBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            аптеки_расходBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            аптеки_расходBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            аптеки_расходBindingSource.MoveFirst();
        }
    }
}
