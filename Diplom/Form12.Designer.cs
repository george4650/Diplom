namespace Diplom
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDDLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label дата_приемаLabel;
            System.Windows.Forms.Label должностьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Diplom.aptecaDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.зарплатаTextBox = new System.Windows.Forms.TextBox();
            this.дата_приемаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.должностьComboBox = new System.Windows.Forms.ComboBox();
            iDDLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            дата_приемаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.BackColor = System.Drawing.Color.White;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iDDLabel.Location = new System.Drawing.Point(87, 32);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(42, 20);
            iDDLabel.TabIndex = 1;
            iDDLabel.Text = "IDD:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.BackColor = System.Drawing.Color.White;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            имяLabel.Location = new System.Drawing.Point(85, 74);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(44, 20);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.BackColor = System.Drawing.Color.White;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            фамилияLabel.Location = new System.Drawing.Point(44, 116);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(85, 20);
            фамилияLabel.TabIndex = 5;
            фамилияLabel.Text = "Фамилия:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.BackColor = System.Drawing.Color.White;
            зарплатаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            зарплатаLabel.Location = new System.Drawing.Point(41, 197);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(88, 20);
            зарплатаLabel.TabIndex = 9;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // дата_приемаLabel
            // 
            дата_приемаLabel.AutoSize = true;
            дата_приемаLabel.BackColor = System.Drawing.Color.White;
            дата_приемаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            дата_приемаLabel.Location = new System.Drawing.Point(17, 237);
            дата_приемаLabel.Name = "дата_приемаLabel";
            дата_приемаLabel.Size = new System.Drawing.Size(112, 20);
            дата_приемаLabel.TabIndex = 11;
            дата_приемаLabel.Text = "Дата приема:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            должностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            должностьLabel.Location = new System.Drawing.Point(29, 160);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(99, 20);
            должностьLabel.TabIndex = 20;
            должностьLabel.Text = "Должность:";
            // 
            // aptecaDataSet
            // 
            this.aptecaDataSet.DataSetName = "aptecaDataSet";
            this.aptecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Diplom.aptecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аптеки_приходTableAdapter = null;
            this.tableAdapterManager.Аптеки_расходTableAdapter = null;
            this.tableAdapterManager.АптекиTableAdapter = null;
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = null;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = null;
            this.tableAdapterManager.Место_храненияTableAdapter = null;
            this.tableAdapterManager.Область_заболеванияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПроизводительTableAdapter = null;
            this.tableAdapterManager.ПротивопоказанияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.УпаковкаTableAdapter = null;
            // 
            // iDDTextBox
            // 
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iDDTextBox.Location = new System.Drawing.Point(134, 29);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(230, 26);
            this.iDDTextBox.TabIndex = 2;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.имяTextBox.Location = new System.Drawing.Point(134, 71);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(230, 26);
            this.имяTextBox.TabIndex = 4;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.фамилияTextBox.Location = new System.Drawing.Point(134, 113);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(230, 26);
            this.фамилияTextBox.TabIndex = 6;
            // 
            // зарплатаTextBox
            // 
            this.зарплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Зарплата", true));
            this.зарплатаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.зарплатаTextBox.Location = new System.Drawing.Point(134, 194);
            this.зарплатаTextBox.Name = "зарплатаTextBox";
            this.зарплатаTextBox.Size = new System.Drawing.Size(230, 26);
            this.зарплатаTextBox.TabIndex = 10;
            // 
            // дата_приемаDateTimePicker
            // 
            this.дата_приемаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "Дата приема", true));
            this.дата_приемаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.дата_приемаDateTimePicker.Location = new System.Drawing.Point(134, 233);
            this.дата_приемаDateTimePicker.Name = "дата_приемаDateTimePicker";
            this.дата_приемаDateTimePicker.Size = new System.Drawing.Size(230, 26);
            this.дата_приемаDateTimePicker.TabIndex = 12;
            this.дата_приемаDateTimePicker.Value = new System.DateTime(2022, 2, 7, 21, 34, 35, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(205, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 25);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(10, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // должностьComboBox
            // 
            this.должностьComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Должность", true));
            this.должностьComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.должностьComboBox.FormattingEnabled = true;
            this.должностьComboBox.Items.AddRange(new object[] {
            "Фармацевт",
            "Провизор",
            "Санитар",
            "Складовщик",
            "Секретарь"});
            this.должностьComboBox.Location = new System.Drawing.Point(134, 155);
            this.должностьComboBox.Name = "должностьComboBox";
            this.должностьComboBox.Size = new System.Drawing.Size(230, 28);
            this.должностьComboBox.TabIndex = 21;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources._1644884239_40_kartinkin_net_p_meditsinskie_kartinki_42_Nq7QR;
            this.ClientSize = new System.Drawing.Size(381, 345);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.iDDTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.зарплатаTextBox);
            this.Controls.Add(дата_приемаLabel);
            this.Controls.Add(this.дата_приемаDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private aptecaDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox зарплатаTextBox;
        private System.Windows.Forms.DateTimePicker дата_приемаDateTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox должностьComboBox;
    }
}