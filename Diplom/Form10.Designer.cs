namespace Diplom
{
    partial class Form10
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
            System.Windows.Forms.Label препаратLabel;
            System.Windows.Forms.Label аптекаLabel;
            System.Windows.Forms.Label дата_расходаLabel;
            System.Windows.Forms.Label стоимость_продажиLabel;
            System.Windows.Forms.Label количествоLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.аптеки_расходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптеки_расходTableAdapter = new Diplom.aptecaDataSetTableAdapters.Аптеки_расходTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.аптекиTableAdapter = new Diplom.aptecaDataSetTableAdapters.АптекиTableAdapter();
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.препаратComboBox = new System.Windows.Forms.ComboBox();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптекаComboBox = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_расходаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимость_продажиTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Diplom.aptecaDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDLabel = new System.Windows.Forms.Label();
            препаратLabel = new System.Windows.Forms.Label();
            аптекаLabel = new System.Windows.Forms.Label();
            дата_расходаLabel = new System.Windows.Forms.Label();
            стоимость_продажиLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_расходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            iDDLabel.Location = new System.Drawing.Point(126, 52);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(37, 18);
            iDDLabel.TabIndex = 21;
            iDDLabel.Text = "IDD:";
            // 
            // препаратLabel
            // 
            препаратLabel.AutoSize = true;
            препаратLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            препаратLabel.Location = new System.Drawing.Point(85, 82);
            препаратLabel.Name = "препаратLabel";
            препаратLabel.Size = new System.Drawing.Size(78, 18);
            препаратLabel.TabIndex = 23;
            препаратLabel.Text = "Препарат:";
            // 
            // аптекаLabel
            // 
            аптекаLabel.AutoSize = true;
            аптекаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            аптекаLabel.Location = new System.Drawing.Point(103, 114);
            аптекаLabel.Name = "аптекаLabel";
            аптекаLabel.Size = new System.Drawing.Size(60, 18);
            аптекаLabel.TabIndex = 25;
            аптекаLabel.Text = "Аптека:";
            // 
            // дата_расходаLabel
            // 
            дата_расходаLabel.AutoSize = true;
            дата_расходаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            дата_расходаLabel.Location = new System.Drawing.Point(51, 147);
            дата_расходаLabel.Name = "дата_расходаLabel";
            дата_расходаLabel.Size = new System.Drawing.Size(112, 18);
            дата_расходаLabel.TabIndex = 27;
            дата_расходаLabel.Text = "Дата продажи:";
            // 
            // стоимость_продажиLabel
            // 
            стоимость_продажиLabel.AutoSize = true;
            стоимость_продажиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            стоимость_продажиLabel.Location = new System.Drawing.Point(8, 176);
            стоимость_продажиLabel.Name = "стоимость_продажиLabel";
            стоимость_продажиLabel.Size = new System.Drawing.Size(155, 18);
            стоимость_продажиLabel.TabIndex = 29;
            стоимость_продажиLabel.Text = "Стоимость продажи:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            количествоLabel.Location = new System.Drawing.Point(67, 206);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(96, 18);
            количествоLabel.TabIndex = 31;
            количествоLabel.Text = "Количество:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(248, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 25);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(41, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aptecaDataSet
            // 
            this.aptecaDataSet.DataSetName = "aptecaDataSet";
            this.aptecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аптеки_расходBindingSource
            // 
            this.аптеки_расходBindingSource.DataMember = "Аптеки расход";
            this.аптеки_расходBindingSource.DataSource = this.aptecaDataSet;
            // 
            // аптеки_расходTableAdapter
            // 
            this.аптеки_расходTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Diplom.aptecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аптеки_приходTableAdapter = null;
            this.tableAdapterManager.Аптеки_расходTableAdapter = this.аптеки_расходTableAdapter;
            this.tableAdapterManager.АптекиTableAdapter = this.аптекиTableAdapter;
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = null;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = this.каталог_лекарствTableAdapter;
            this.tableAdapterManager.Место_храненияTableAdapter = null;
            this.tableAdapterManager.Область_заболеванияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
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
            // iDDTextBox
            // 
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(169, 49);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(200, 24);
            this.iDDTextBox.TabIndex = 22;
            // 
            // препаратComboBox
            // 
            this.препаратComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_расходBindingSource, "Препарат", true));
            this.препаратComboBox.DataSource = this.каталог_лекарствBindingSource;
            this.препаратComboBox.DisplayMember = "Наименование лекарства";
            this.препаратComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.препаратComboBox.FormattingEnabled = true;
            this.препаратComboBox.Location = new System.Drawing.Point(169, 79);
            this.препаратComboBox.Name = "препаратComboBox";
            this.препаратComboBox.Size = new System.Drawing.Size(200, 26);
            this.препаратComboBox.TabIndex = 24;
            this.препаратComboBox.ValueMember = "IDD";
            // 
            // каталог_лекарствBindingSource
            // 
            this.каталог_лекарствBindingSource.DataMember = "Каталог лекарств";
            this.каталог_лекарствBindingSource.DataSource = this.aptecaDataSet;
            // 
            // аптекаComboBox
            // 
            this.аптекаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_расходBindingSource, "Аптека", true));
            this.аптекаComboBox.DataSource = this.аптекиBindingSource;
            this.аптекаComboBox.DisplayMember = "Наименование аптеки";
            this.аптекаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.аптекаComboBox.FormattingEnabled = true;
            this.аптекаComboBox.Location = new System.Drawing.Point(169, 111);
            this.аптекаComboBox.Name = "аптекаComboBox";
            this.аптекаComboBox.Size = new System.Drawing.Size(200, 26);
            this.аптекаComboBox.TabIndex = 26;
            this.аптекаComboBox.ValueMember = "IDD";
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // дата_расходаDateTimePicker
            // 
            this.дата_расходаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.аптеки_расходBindingSource, "Дата расхода", true));
            this.дата_расходаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.дата_расходаDateTimePicker.Location = new System.Drawing.Point(169, 143);
            this.дата_расходаDateTimePicker.Name = "дата_расходаDateTimePicker";
            this.дата_расходаDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.дата_расходаDateTimePicker.TabIndex = 28;
            // 
            // стоимость_продажиTextBox
            // 
            this.стоимость_продажиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "Стоимость продажи", true));
            this.стоимость_продажиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.стоимость_продажиTextBox.Location = new System.Drawing.Point(169, 173);
            this.стоимость_продажиTextBox.Name = "стоимость_продажиTextBox";
            this.стоимость_продажиTextBox.Size = new System.Drawing.Size(200, 24);
            this.стоимость_продажиTextBox.TabIndex = 30;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.количествоTextBox.Location = new System.Drawing.Point(169, 203);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(200, 24);
            this.количествоTextBox.TabIndex = 32;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.aptecaDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(389, 30);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.Size = new System.Drawing.Size(850, 220);
            this.dataTable1DataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDD";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование лекарства";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование лекарства";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Упаковка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Упаковка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Место хранения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Место хранения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Название заболевания";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название заболевания";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Противопоказания";
            this.dataGridViewTextBoxColumn7.HeaderText = "Противопоказания";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn8.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.качество_лекарств2;
            this.ClientSize = new System.Drawing.Size(381, 335);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.iDDTextBox);
            this.Controls.Add(препаратLabel);
            this.Controls.Add(this.препаратComboBox);
            this.Controls.Add(аптекаLabel);
            this.Controls.Add(this.аптекаComboBox);
            this.Controls.Add(дата_расходаLabel);
            this.Controls.Add(this.дата_расходаDateTimePicker);
            this.Controls.Add(стоимость_продажиLabel);
            this.Controls.Add(this.стоимость_продажиTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Составить расход";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_расходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource аптеки_расходBindingSource;
        private aptecaDataSetTableAdapters.Аптеки_расходTableAdapter аптеки_расходTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.ComboBox препаратComboBox;
        private System.Windows.Forms.ComboBox аптекаComboBox;
        private System.Windows.Forms.DateTimePicker дата_расходаDateTimePicker;
        private System.Windows.Forms.TextBox стоимость_продажиTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private aptecaDataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private aptecaDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}