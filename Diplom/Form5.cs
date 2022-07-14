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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void каталог_заболеванийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_заболеванийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Область_заболевания". При необходимости она может быть перемещена или удалена.
            this.область_заболеванияTableAdapter.Fill(this.aptecaDataSet.Область_заболевания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptecaDataSet.Каталог_заболеваний". При необходимости она может быть перемещена или удалена.
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button5.Visible = false;
        }

        private void каталог_заболеванийBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_заболеванийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);

        }

        //Закрыть
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Добавить запись
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            button5.Visible = true;
          //  iDDTextBox.Clear();
            тип_заболеванияComboBox.Text="";
            название_заболеванияTextBox.Clear();
            симптомыTextBox.Clear();
            iDDTextBox.ReadOnly = true;
          //  тип_заболеванияComboBox.ReadOnly = false;
            название_заболеванияTextBox.ReadOnly = false;
            симптомыTextBox.ReadOnly = false;
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            this.каталог_заболеванийBindingSource.AddNew();
        }

        //ОК
        private void button6_Click(object sender, EventArgs e)
        {
            /*  if ((кодTextBox.Text.Length == 0 || категорияComboBox.Text.Length == 0 || наименованиеTextBox1.Text.Length == 0))
            { MessageBox.Show("Заполните все поля!"); return; }
            if (категорияComboBox.Text != "Городская служба" && категорияComboBox.Text != "Государственное учреждение" && категорияComboBox.Text != "Частное лицо")
            { MessageBox.Show("Корректно заполните поля!"); return; }*/

            this.Validate();
            this.каталог_заболеванийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptecaDataSet);
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);
            this.каталог_заболеванийBindingSource.MoveLast();
            this.каталог_заболеванийTableAdapter.Fill(this.aptecaDataSet.Каталог_заболеваний);

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button5.Visible = false;

            iDDTextBox.ReadOnly = true;
          //  тип_заболеванияTextBox.ReadOnly = true;
            название_заболеванияTextBox.ReadOnly = true;
            симптомыTextBox.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            каталог_заболеванийBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            каталог_заболеванийBindingSource.MovePrevious();
        }
    }
}
