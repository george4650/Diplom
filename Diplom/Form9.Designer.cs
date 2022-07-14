namespace Diplom
{
    partial class Form9
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
            System.Windows.Forms.Label название_аптекиLabel;
            System.Windows.Forms.Label препаратLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label дата_приходаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label поставщикLabel;
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.аптеки_приходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптеки_приходTableAdapter = new Diplom.aptecaDataSetTableAdapters.Аптеки_приходTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.название_аптекиComboBox = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.препаратComboBox = new System.Windows.Forms.ComboBox();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталогЛекарствBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_приходаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.поставщикComboBox = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.каталогЛекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.аптекиTableAdapter = new Diplom.aptecaDataSetTableAdapters.АптекиTableAdapter();
            this.поставщикиTableAdapter = new Diplom.aptecaDataSetTableAdapters.ПоставщикиTableAdapter();
            this.dataTable1TableAdapter1 = new Diplom.aptecaDataSetTableAdapters.DataTable1TableAdapter();
            iDDLabel = new System.Windows.Forms.Label();
            название_аптекиLabel = new System.Windows.Forms.Label();
            препаратLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            дата_приходаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            поставщикLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_приходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогЛекарствBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогЛекарствBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.BackColor = System.Drawing.Color.White;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            iDDLabel.Location = new System.Drawing.Point(102, 41);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(37, 18);
            iDDLabel.TabIndex = 1;
            iDDLabel.Text = "IDD:";
            // 
            // название_аптекиLabel
            // 
            название_аптекиLabel.AutoSize = true;
            название_аптекиLabel.BackColor = System.Drawing.Color.White;
            название_аптекиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            название_аптекиLabel.Location = new System.Drawing.Point(5, 72);
            название_аптекиLabel.Name = "название_аптекиLabel";
            название_аптекиLabel.Size = new System.Drawing.Size(130, 18);
            название_аптекиLabel.TabIndex = 3;
            название_аптекиLabel.Text = "Название аптеки:";
            // 
            // препаратLabel
            // 
            препаратLabel.AutoSize = true;
            препаратLabel.BackColor = System.Drawing.Color.White;
            препаратLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            препаратLabel.Location = new System.Drawing.Point(55, 104);
            препаратLabel.Name = "препаратLabel";
            препаратLabel.Size = new System.Drawing.Size(78, 18);
            препаратLabel.TabIndex = 5;
            препаратLabel.Text = "Препарат:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.BackColor = System.Drawing.Color.White;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            количествоLabel.Location = new System.Drawing.Point(41, 136);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(96, 18);
            количествоLabel.TabIndex = 7;
            количествоLabel.Text = "Количество:";
            // 
            // дата_приходаLabel
            // 
            дата_приходаLabel.AutoSize = true;
            дата_приходаLabel.BackColor = System.Drawing.Color.White;
            дата_приходаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            дата_приходаLabel.Location = new System.Drawing.Point(-3, 229);
            дата_приходаLabel.Name = "дата_приходаLabel";
            дата_приходаLabel.Size = new System.Drawing.Size(139, 18);
            дата_приходаLabel.TabIndex = 9;
            дата_приходаLabel.Text = "Дата поступления:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.BackColor = System.Drawing.Color.White;
            стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            стоимостьLabel.Location = new System.Drawing.Point(49, 166);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(90, 18);
            стоимостьLabel.TabIndex = 11;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // поставщикLabel
            // 
            поставщикLabel.AutoSize = true;
            поставщикLabel.BackColor = System.Drawing.Color.White;
            поставщикLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            поставщикLabel.Location = new System.Drawing.Point(47, 196);
            поставщикLabel.Name = "поставщикLabel";
            поставщикLabel.Size = new System.Drawing.Size(90, 18);
            поставщикLabel.TabIndex = 13;
            поставщикLabel.Text = "Поставщик:";
            // 
            // aptecaDataSet
            // 
            this.aptecaDataSet.DataSetName = "aptecaDataSet";
            this.aptecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аптеки_приходBindingSource
            // 
            this.аптеки_приходBindingSource.DataMember = "Аптеки приход";
            this.аптеки_приходBindingSource.DataSource = this.aptecaDataSet;
            // 
            // аптеки_приходTableAdapter
            // 
            this.аптеки_приходTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Diplom.aptecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аптеки_приходTableAdapter = this.аптеки_приходTableAdapter;
            this.tableAdapterManager.Аптеки_расходTableAdapter = null;
            this.tableAdapterManager.АптекиTableAdapter = null;
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = null;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = null;
            this.tableAdapterManager.Место_храненияTableAdapter = null;
            this.tableAdapterManager.Область_заболеванияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПроизводительTableAdapter = null;
            this.tableAdapterManager.ПротивопоказанияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УпаковкаTableAdapter = null;
            // 
            // iDDTextBox
            // 
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(144, 39);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(200, 24);
            this.iDDTextBox.TabIndex = 2;
            // 
            // название_аптекиComboBox
            // 
            this.название_аптекиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_приходBindingSource, "Название аптеки", true));
            this.название_аптекиComboBox.DataSource = this.аптекиBindingSource1;
            this.название_аптекиComboBox.DisplayMember = "Наименование аптеки";
            this.название_аптекиComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.название_аптекиComboBox.FormattingEnabled = true;
            this.название_аптекиComboBox.Location = new System.Drawing.Point(144, 69);
            this.название_аптекиComboBox.Name = "название_аптекиComboBox";
            this.название_аптекиComboBox.Size = new System.Drawing.Size(200, 26);
            this.название_аптекиComboBox.TabIndex = 4;
            this.название_аптекиComboBox.ValueMember = "IDD";
            // 
            // аптекиBindingSource1
            // 
            this.аптекиBindingSource1.DataMember = "Аптеки";
            this.аптекиBindingSource1.DataSource = this.aptecaDataSet;
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // препаратComboBox
            // 
            this.препаратComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_приходBindingSource, "Препарат", true));
            this.препаратComboBox.DataSource = this.каталог_лекарствBindingSource;
            this.препаратComboBox.DisplayMember = "Наименование лекарства";
            this.препаратComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.препаратComboBox.FormattingEnabled = true;
            this.препаратComboBox.Location = new System.Drawing.Point(144, 101);
            this.препаратComboBox.Name = "препаратComboBox";
            this.препаратComboBox.Size = new System.Drawing.Size(200, 26);
            this.препаратComboBox.TabIndex = 6;
            this.препаратComboBox.ValueMember = "IDD";
            // 
            // каталог_лекарствBindingSource
            // 
            this.каталог_лекарствBindingSource.DataMember = "Каталог лекарств";
            this.каталог_лекарствBindingSource.DataSource = this.aptecaDataSet;
            // 
            // каталогЛекарствBindingSource1
            // 
            this.каталогЛекарствBindingSource1.DataMember = "Каталог лекарств";
            this.каталогЛекарствBindingSource1.DataSource = this.aptecaDataSet;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.количествоTextBox.Location = new System.Drawing.Point(144, 133);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(200, 24);
            this.количествоTextBox.TabIndex = 8;
            // 
            // дата_приходаDateTimePicker
            // 
            this.дата_приходаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.аптеки_приходBindingSource, "Дата прихода", true));
            this.дата_приходаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.дата_приходаDateTimePicker.Location = new System.Drawing.Point(144, 225);
            this.дата_приходаDateTimePicker.Name = "дата_приходаDateTimePicker";
            this.дата_приходаDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.дата_приходаDateTimePicker.TabIndex = 10;
            this.дата_приходаDateTimePicker.Value = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.стоимостьTextBox.Location = new System.Drawing.Point(144, 163);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 24);
            this.стоимостьTextBox.TabIndex = 12;
            // 
            // поставщикComboBox
            // 
            this.поставщикComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_приходBindingSource, "Поставщик", true));
            this.поставщикComboBox.DataSource = this.поставщикиBindingSource1;
            this.поставщикComboBox.DisplayMember = "Наименование поставщика";
            this.поставщикComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.поставщикComboBox.FormattingEnabled = true;
            this.поставщикComboBox.Location = new System.Drawing.Point(144, 193);
            this.поставщикComboBox.Name = "поставщикComboBox";
            this.поставщикComboBox.Size = new System.Drawing.Size(200, 26);
            this.поставщикComboBox.TabIndex = 14;
            this.поставщикComboBox.ValueMember = "IDD";
            // 
            // поставщикиBindingSource1
            // 
            this.поставщикиBindingSource1.DataMember = "Поставщики";
            this.поставщикиBindingSource1.DataSource = this.aptecaDataSet;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(209, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // каталогЛекарствBindingSource
            // 
            this.каталогЛекарствBindingSource.DataMember = "Каталог лекарств";
            this.каталогЛекарствBindingSource.DataSource = this.aptecaDataSet;
            // 
            // каталог_лекарствTableAdapter
            // 
            this.каталог_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.рассчет_ChxgZ;
            this.ClientSize = new System.Drawing.Size(364, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.iDDTextBox);
            this.Controls.Add(название_аптекиLabel);
            this.Controls.Add(this.название_аптекиComboBox);
            this.Controls.Add(препаратLabel);
            this.Controls.Add(this.препаратComboBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(дата_приходаLabel);
            this.Controls.Add(this.дата_приходаDateTimePicker);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(поставщикLabel);
            this.Controls.Add(this.поставщикComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Составить приход";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_приходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогЛекарствBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогЛекарствBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource аптеки_приходBindingSource;
        private aptecaDataSetTableAdapters.Аптеки_приходTableAdapter аптеки_приходTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.ComboBox название_аптекиComboBox;
        private System.Windows.Forms.ComboBox препаратComboBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_приходаDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.ComboBox поставщикComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource каталогЛекарствBindingSource;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private System.Windows.Forms.BindingSource каталогЛекарствBindingSource1;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private aptecaDataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private aptecaDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource аптекиBindingSource1;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private System.Windows.Forms.BindingSource поставщикиBindingSource1;
        private aptecaDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
    }
}