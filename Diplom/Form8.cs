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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_заболеваний". При необходимости она может быть перемещена или удалена.
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.aptecaDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Место_хранения". При необходимости она может быть перемещена или удалена.
            this.место_храненияTableAdapter.Fill(this.aptecaDataSet.Место_хранения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Упаковка". При необходимости она может быть перемещена или удалена.
            this.упаковкаTableAdapter.Fill(this.aptecaDataSet.Упаковка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Область_заболевания". При необходимости она может быть перемещена или удалена.
            this.область_заболеванияTableAdapter.Fill(this.aptecaDataSet.Область_заболевания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Противопоказания". При необходимости она может быть перемещена или удалена.
            this.противопоказанияTableAdapter.Fill(this.aptecaDataSet.Противопоказания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_лекарств". При необходимости она может быть перемещена или удалена.
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
          
            //Добавляем новую строчку 
            this.каталог_лекарствBindingSource.AddNew();

        }

        private void каталог_лекарствBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ОК
        private void button1_Click(object sender, EventArgs e)
        {
            /*  if ((кодTextBox.Text.Length == 0 || категорияComboBox.Text.Length == 0 || наименованиеTextBox1.Text.Length == 0))
              { MessageBox.Show("Заполните все поля!"); return; }
              if (категорияComboBox.Text != "Городская служба" && категорияComboBox.Text != "Государственное учреждение" && категорияComboBox.Text != "Частное лицо")
              { MessageBox.Show("Корректно заполните поля!"); return; }*/

            this.Validate();
            this.каталог_лекарствBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);
            this.каталог_лекарствTableAdapter.Fill(this.aptecaDataSet.Каталог_лекарств);
            this.каталог_лекарствBindingSource.MoveLast();
            Close();
        }
    }
}
