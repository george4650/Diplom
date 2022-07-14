namespace Diplom
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.аптеки_приходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптеки_приходTableAdapter = new Diplom.aptecaDataSetTableAdapters.Аптеки_приходTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.аптекиTableAdapter = new Diplom.aptecaDataSetTableAdapters.АптекиTableAdapter();
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.поставщикиTableAdapter = new Diplom.aptecaDataSetTableAdapters.ПоставщикиTableAdapter();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.название_аптекиComboBox = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.препаратComboBox = new System.Windows.Forms.ComboBox();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_приходаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.поставщикComboBox = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDDLabel = new System.Windows.Forms.Label();
            название_аптекиLabel = new System.Windows.Forms.Label();
            препаратLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            дата_приходаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            поставщикLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_приходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            iDDLabel.Location = new System.Drawing.Point(115, 49);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(37, 18);
            iDDLabel.TabIndex = 40;
            iDDLabel.Text = "IDD:";
            // 
            // название_аптекиLabel
            // 
            название_аптекиLabel.AutoSize = true;
            название_аптекиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            название_аптекиLabel.Location = new System.Drawing.Point(22, 75);
            название_аптекиLabel.Name = "название_аптекиLabel";
            название_аптекиLabel.Size = new System.Drawing.Size(130, 18);
            название_аптекиLabel.TabIndex = 42;
            название_аптекиLabel.Text = "Название аптеки:";
            // 
            // препаратLabel
            // 
            препаратLabel.AutoSize = true;
            препаратLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            препаратLabel.Location = new System.Drawing.Point(74, 102);
            препаратLabel.Name = "препаратLabel";
            препаратLabel.Size = new System.Drawing.Size(78, 18);
            препаратLabel.TabIndex = 44;
            препаратLabel.Text = "Препарат:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            количествоLabel.Location = new System.Drawing.Point(56, 129);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(96, 18);
            количествоLabel.TabIndex = 46;
            количествоLabel.Text = "Количество:";
            // 
            // дата_приходаLabel
            // 
            дата_приходаLabel.AutoSize = true;
            дата_приходаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            дата_приходаLabel.Location = new System.Drawing.Point(13, 210);
            дата_приходаLabel.Name = "дата_приходаLabel";
            дата_приходаLabel.Size = new System.Drawing.Size(139, 18);
            дата_приходаLabel.TabIndex = 48;
            дата_приходаLabel.Text = "Дата поступления:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            стоимостьLabel.Location = new System.Drawing.Point(62, 155);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(90, 18);
            стоимостьLabel.TabIndex = 50;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // поставщикLabel
            // 
            поставщикLabel.AutoSize = true;
            поставщикLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            поставщикLabel.Location = new System.Drawing.Point(62, 181);
            поставщикLabel.Name = "поставщикLabel";
            поставщикLabel.Size = new System.Drawing.Size(90, 18);
            поставщикLabel.TabIndex = 52;
            поставщикLabel.Text = "Поставщик:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(22, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 37);
            this.button7.TabIndex = 39;
            this.button7.Text = "|⯇";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(143, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 37);
            this.button8.TabIndex = 38;
            this.button8.Text = "⯈|";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button9.Image = global::Diplom.Properties.Resources.tlb_logout_11;
            this.button9.Location = new System.Drawing.Point(358, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 37);
            this.button9.TabIndex = 37;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button10.Location = new System.Drawing.Point(99, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 37);
            this.button10.TabIndex = 36;
            this.button10.Text = "⯈";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button11.Location = new System.Drawing.Point(188, 262);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(158, 37);
            this.button11.TabIndex = 35;
            this.button11.Text = "Добавить запись";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button12.Location = new System.Drawing.Point(57, 262);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 37);
            this.button12.TabIndex = 34;
            this.button12.Text = "⯇";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
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
            this.tableAdapterManager.АптекиTableAdapter = this.аптекиTableAdapter;
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = null;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = this.каталог_лекарствTableAdapter;
            this.tableAdapterManager.Место_храненияTableAdapter = null;
            this.tableAdapterManager.Область_заболеванияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.ПроизводительTableAdapter = null;
            this.tableAdapterManager.ПротивопоказанияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УпаковкаTableAdapter = null;
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // каталог_лекарствTableAdapter
            // 
            this.каталог_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // iDDTextBox
            // 
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(155, 46);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(245, 24);
            this.iDDTextBox.TabIndex = 41;
            // 
            // название_аптекиComboBox
            // 
            this.название_аптекиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_приходBindingSource, "Название аптеки", true));
            this.название_аптекиComboBox.DataSource = this.аптекиBindingSource;
            this.название_аптекиComboBox.DisplayMember = "Наименование аптеки";
            this.название_аптекиComboBox.Enabled = false;
            this.название_аптекиComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.название_аптекиComboBox.FormattingEnabled = true;
            this.название_аптекиComboBox.Location = new System.Drawing.Point(155, 72);
            this.название_аптекиComboBox.Name = "название_аптекиComboBox";
            this.название_аптекиComboBox.Size = new System.Drawing.Size(245, 26);
            this.название_аптекиComboBox.TabIndex = 43;
            this.название_аптекиComboBox.ValueMember = "IDD";
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
            this.препаратComboBox.Enabled = false;
            this.препаратComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.препаратComboBox.FormattingEnabled = true;
            this.препаратComboBox.Location = new System.Drawing.Point(155, 99);
            this.препаратComboBox.Name = "препаратComboBox";
            this.препаратComboBox.Size = new System.Drawing.Size(245, 26);
            this.препаратComboBox.TabIndex = 45;
            this.препаратComboBox.ValueMember = "IDD";
            // 
            // каталог_лекарствBindingSource
            // 
            this.каталог_лекарствBindingSource.DataMember = "Каталог лекарств";
            this.каталог_лекарствBindingSource.DataSource = this.aptecaDataSet;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.количествоTextBox.Location = new System.Drawing.Point(155, 126);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.ReadOnly = true;
            this.количествоTextBox.Size = new System.Drawing.Size(245, 24);
            this.количествоTextBox.TabIndex = 47;
            // 
            // дата_приходаDateTimePicker
            // 
            this.дата_приходаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.аптеки_приходBindingSource, "Дата прихода", true));
            this.дата_приходаDateTimePicker.Enabled = false;
            this.дата_приходаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.дата_приходаDateTimePicker.Location = new System.Drawing.Point(155, 206);
            this.дата_приходаDateTimePicker.Name = "дата_приходаDateTimePicker";
            this.дата_приходаDateTimePicker.Size = new System.Drawing.Size(245, 24);
            this.дата_приходаDateTimePicker.TabIndex = 49;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_приходBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.стоимостьTextBox.Location = new System.Drawing.Point(155, 152);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.ReadOnly = true;
            this.стоимостьTextBox.Size = new System.Drawing.Size(245, 24);
            this.стоимостьTextBox.TabIndex = 51;
            // 
            // поставщикComboBox
            // 
            this.поставщикComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_приходBindingSource, "Поставщик", true));
            this.поставщикComboBox.DataSource = this.поставщикиBindingSource;
            this.поставщикComboBox.DisplayMember = "Наименование поставщика";
            this.поставщикComboBox.Enabled = false;
            this.поставщикComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.поставщикComboBox.FormattingEnabled = true;
            this.поставщикComboBox.Location = new System.Drawing.Point(155, 178);
            this.поставщикComboBox.Name = "поставщикComboBox";
            this.поставщикComboBox.Size = new System.Drawing.Size(245, 26);
            this.поставщикComboBox.TabIndex = 53;
            this.поставщикComboBox.ValueMember = "IDD";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.medicine_g338760d78_640;
            this.ClientSize = new System.Drawing.Size(452, 323);
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
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о приходах";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_приходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource аптеки_приходBindingSource;
        private aptecaDataSetTableAdapters.Аптеки_приходTableAdapter аптеки_приходTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private aptecaDataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.ComboBox название_аптекиComboBox;
        private System.Windows.Forms.ComboBox препаратComboBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_приходаDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.ComboBox поставщикComboBox;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private aptecaDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
    }
}