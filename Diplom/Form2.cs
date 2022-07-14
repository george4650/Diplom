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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Место_хранения". При необходимости она может быть перемещена или удалена.
            this.место_храненияTableAdapter.Fill(this.aptecaDataSet.Место_хранения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Противопоказания". При необходимости она может быть перемещена или удалена.
            this.противопоказанияTableAdapter.Fill(this.aptecaDataSet.Противопоказания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_заболеваний". При необходимости она может быть перемещена или удалена.
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Упаковка". При необходимости она может быть перемещена или удалена.
            this.упаковкаTableAdapter.Fill(this.aptecaDataSet.Упаковка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.aptecaDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);

        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            каталог_лекарствBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.ShowDialog();
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            каталог_лекарствBindingSource.MoveNext();
        }
    }
}
