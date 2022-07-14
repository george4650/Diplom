
namespace Diplom
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.аптеки_расходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптеки_расходTableAdapter = new Diplom.aptecaDataSetTableAdapters.Аптеки_расходTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.дата_расходаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимость_продажиTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.препаратComboBox = new System.Windows.Forms.ComboBox();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптекаComboBox = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.аптекиTableAdapter = new Diplom.aptecaDataSetTableAdapters.АптекиTableAdapter();
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
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            iDDLabel.Location = new System.Drawing.Point(129, 52);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(37, 18);
            iDDLabel.TabIndex = 23;
            iDDLabel.Text = "IDD:";
            // 
            // препаратLabel
            // 
            препаратLabel.AutoSize = true;
            препаратLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            препаратLabel.Location = new System.Drawing.Point(88, 82);
            препаратLabel.Name = "препаратLabel";
            препаратLabel.Size = new System.Drawing.Size(78, 18);
            препаратLabel.TabIndex = 24;
            препаратLabel.Text = "Препарат:";
            // 
            // аптекаLabel
            // 
            аптекаLabel.AutoSize = true;
            аптекаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            аптекаLabel.Location = new System.Drawing.Point(106, 112);
            аптекаLabel.Name = "аптекаLabel";
            аптекаLabel.Size = new System.Drawing.Size(60, 18);
            аптекаLabel.TabIndex = 25;
            аптекаLabel.Text = "Аптека:";
            // 
            // дата_расходаLabel
            // 
            дата_расходаLabel.AutoSize = true;
            дата_расходаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            дата_расходаLabel.Location = new System.Drawing.Point(54, 143);
            дата_расходаLabel.Name = "дата_расходаLabel";
            дата_расходаLabel.Size = new System.Drawing.Size(112, 18);
            дата_расходаLabel.TabIndex = 26;
            дата_расходаLabel.Text = "Дата продажи:";
            // 
            // стоимость_продажиLabel
            // 
            стоимость_продажиLabel.AutoSize = true;
            стоимость_продажиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            стоимость_продажиLabel.Location = new System.Drawing.Point(11, 172);
            стоимость_продажиLabel.Name = "стоимость_продажиLabel";
            стоимость_продажиLabel.Size = new System.Drawing.Size(155, 18);
            стоимость_продажиLabel.TabIndex = 27;
            стоимость_продажиLabel.Text = "Стоимость продажи:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            количествоLabel.Location = new System.Drawing.Point(70, 202);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(96, 18);
            количествоLabel.TabIndex = 28;
            количествоLabel.Text = "Количество:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(97, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "⯈";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(186, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Добавить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(55, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "⯇";
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
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(172, 49);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(226, 24);
            this.iDDTextBox.TabIndex = 24;
            // 
            // дата_расходаDateTimePicker
            // 
            this.дата_расходаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.аптеки_расходBindingSource, "Дата расхода", true));
            this.дата_расходаDateTimePicker.Enabled = false;
            this.дата_расходаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.дата_расходаDateTimePicker.Location = new System.Drawing.Point(172, 139);
            this.дата_расходаDateTimePicker.Name = "дата_расходаDateTimePicker";
            this.дата_расходаDateTimePicker.Size = new System.Drawing.Size(226, 24);
            this.дата_расходаDateTimePicker.TabIndex = 27;
            // 
            // стоимость_продажиTextBox
            // 
            this.стоимость_продажиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "Стоимость продажи", true));
            this.стоимость_продажиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.стоимость_продажиTextBox.Location = new System.Drawing.Point(172, 169);
            this.стоимость_продажиTextBox.Name = "стоимость_продажиTextBox";
            this.стоимость_продажиTextBox.ReadOnly = true;
            this.стоимость_продажиTextBox.Size = new System.Drawing.Size(226, 24);
            this.стоимость_продажиTextBox.TabIndex = 28;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аптеки_расходBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.количествоTextBox.Location = new System.Drawing.Point(172, 199);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.ReadOnly = true;
            this.количествоTextBox.Size = new System.Drawing.Size(226, 24);
            this.количествоTextBox.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Image = global::Diplom.Properties.Resources.tlb_logout_11;
            this.button4.Location = new System.Drawing.Point(356, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 37);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(141, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 37);
            this.button5.TabIndex = 30;
            this.button5.Text = "⯈|";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(20, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 37);
            this.button6.TabIndex = 31;
            this.button6.Text = "|⯇";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // препаратComboBox
            // 
            this.препаратComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аптеки_расходBindingSource, "Препарат", true));
            this.препаратComboBox.DataSource = this.каталог_лекарствBindingSource;
            this.препаратComboBox.DisplayMember = "Наименование лекарства";
            this.препаратComboBox.Enabled = false;
            this.препаратComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.препаратComboBox.FormattingEnabled = true;
            this.препаратComboBox.Location = new System.Drawing.Point(172, 77);
            this.препаратComboBox.Name = "препаратComboBox";
            this.препаратComboBox.Size = new System.Drawing.Size(226, 26);
            this.препаратComboBox.TabIndex = 32;
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
            this.аптекаComboBox.Enabled = false;
            this.аптекаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.аптекаComboBox.FormattingEnabled = true;
            this.аптекаComboBox.Location = new System.Drawing.Point(172, 107);
            this.аптекаComboBox.Name = "аптекаComboBox";
            this.аптекаComboBox.Size = new System.Drawing.Size(226, 26);
            this.аптекаComboBox.TabIndex = 33;
            this.аптекаComboBox.ValueMember = "IDD";
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.aptecaDataSet;
            // 
            // каталог_лекарствTableAdapter
            // 
            this.каталог_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.medicine_g338760d78_6401;
            this.ClientSize = new System.Drawing.Size(452, 323);
            this.Controls.Add(this.аптекаComboBox);
            this.Controls.Add(this.препаратComboBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(стоимость_продажиLabel);
            this.Controls.Add(this.стоимость_продажиTextBox);
            this.Controls.Add(дата_расходаLabel);
            this.Controls.Add(this.дата_расходаDateTimePicker);
            this.Controls.Add(аптекаLabel);
            this.Controls.Add(препаратLabel);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.iDDTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о расходах";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптеки_расходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource аптеки_расходBindingSource;
        private aptecaDataSetTableAdapters.Аптеки_расходTableAdapter аптеки_расходTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.DateTimePicker дата_расходаDateTimePicker;
        private System.Windows.Forms.TextBox стоимость_продажиTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox препаратComboBox;
        private System.Windows.Forms.ComboBox аптекаComboBox;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private aptecaDataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
    }
}