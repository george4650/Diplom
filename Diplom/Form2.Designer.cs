namespace Diplom
{
    partial class Form2
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
            System.Windows.Forms.Label наименование_лекарстваLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label упаковкаLabel;
            System.Windows.Forms.Label место_храненияLabel;
            System.Windows.Forms.Label заболеваниеLabel;
            System.Windows.Forms.Label противопоказанияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.наименование_лекарстваTextBox = new System.Windows.Forms.TextBox();
            this.каталог_лекарствListBox = new System.Windows.Forms.ListBox();
            this.производительComboBox = new System.Windows.Forms.ComboBox();
            this.производительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.упаковкаComboBox = new System.Windows.Forms.ComboBox();
            this.упаковкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.место_храненияComboBox = new System.Windows.Forms.ComboBox();
            this.место_храненияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заболеваниеComboBox = new System.Windows.Forms.ComboBox();
            this.каталог_заболеванийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.противопоказанияComboBox = new System.Windows.Forms.ComboBox();
            this.противопоказанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производительTableAdapter = new Diplom.aptecaDataSetTableAdapters.ПроизводительTableAdapter();
            this.упаковкаTableAdapter = new Diplom.aptecaDataSetTableAdapters.УпаковкаTableAdapter();
            this.каталог_заболеванийTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter();
            this.противопоказанияTableAdapter = new Diplom.aptecaDataSetTableAdapters.ПротивопоказанияTableAdapter();
            this.место_храненияTableAdapter = new Diplom.aptecaDataSetTableAdapters.Место_храненияTableAdapter();
            iDDLabel = new System.Windows.Forms.Label();
            наименование_лекарстваLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            упаковкаLabel = new System.Windows.Forms.Label();
            место_храненияLabel = new System.Windows.Forms.Label();
            заболеваниеLabel = new System.Windows.Forms.Label();
            противопоказанияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.место_храненияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.противопоказанияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            iDDLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            iDDLabel.ForeColor = System.Drawing.Color.Black;
            iDDLabel.Location = new System.Drawing.Point(157, 63);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(44, 19);
            iDDLabel.TabIndex = 5;
            iDDLabel.Text = "IDD:";
            // 
            // наименование_лекарстваLabel
            // 
            наименование_лекарстваLabel.AutoSize = true;
            наименование_лекарстваLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            наименование_лекарстваLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            наименование_лекарстваLabel.ForeColor = System.Drawing.Color.Black;
            наименование_лекарстваLabel.Location = new System.Drawing.Point(-1, 90);
            наименование_лекарстваLabel.Name = "наименование_лекарстваLabel";
            наименование_лекарстваLabel.Size = new System.Drawing.Size(202, 19);
            наименование_лекарстваLabel.TabIndex = 7;
            наименование_лекарстваLabel.Text = "Наименование лекарства:";
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            производительLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            производительLabel.ForeColor = System.Drawing.Color.Black;
            производительLabel.Location = new System.Drawing.Point(71, 118);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(130, 19);
            производительLabel.TabIndex = 9;
            производительLabel.Text = "Производитель:";
            // 
            // упаковкаLabel
            // 
            упаковкаLabel.AutoSize = true;
            упаковкаLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            упаковкаLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            упаковкаLabel.ForeColor = System.Drawing.Color.Black;
            упаковкаLabel.Location = new System.Drawing.Point(117, 144);
            упаковкаLabel.Name = "упаковкаLabel";
            упаковкаLabel.Size = new System.Drawing.Size(84, 19);
            упаковкаLabel.TabIndex = 11;
            упаковкаLabel.Text = "Упаковка:";
            // 
            // место_храненияLabel
            // 
            место_храненияLabel.AutoSize = true;
            место_храненияLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            место_храненияLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            место_храненияLabel.ForeColor = System.Drawing.Color.Black;
            место_храненияLabel.Location = new System.Drawing.Point(65, 170);
            место_храненияLabel.Name = "место_храненияLabel";
            место_храненияLabel.Size = new System.Drawing.Size(136, 19);
            место_храненияLabel.TabIndex = 13;
            место_храненияLabel.Text = "Место хранения:";
            // 
            // заболеваниеLabel
            // 
            заболеваниеLabel.AutoSize = true;
            заболеваниеLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            заболеваниеLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            заболеваниеLabel.ForeColor = System.Drawing.Color.Black;
            заболеваниеLabel.Location = new System.Drawing.Point(95, 196);
            заболеваниеLabel.Name = "заболеваниеLabel";
            заболеваниеLabel.Size = new System.Drawing.Size(106, 19);
            заболеваниеLabel.TabIndex = 15;
            заболеваниеLabel.Text = "Заболевание:";
            // 
            // противопоказанияLabel
            // 
            противопоказанияLabel.AutoSize = true;
            противопоказанияLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            противопоказанияLabel.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic);
            противопоказанияLabel.ForeColor = System.Drawing.Color.Black;
            противопоказанияLabel.Location = new System.Drawing.Point(43, 225);
            противопоказанияLabel.Name = "противопоказанияLabel";
            противопоказанияLabel.Size = new System.Drawing.Size(158, 19);
            противопоказанияLabel.TabIndex = 17;
            противопоказанияLabel.Text = "Противопоказания:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(58, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "⯇";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(203, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(121, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "⯈";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Image = global::Diplom.Properties.Resources.tlb_logout_11;
            this.button4.Location = new System.Drawing.Point(426, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 35);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // aptecaDataSet
            // 
            this.aptecaDataSet.DataSetName = "aptecaDataSet";
            this.aptecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталог_лекарствBindingSource
            // 
            this.каталог_лекарствBindingSource.DataMember = "Каталог лекарств";
            this.каталог_лекарствBindingSource.DataSource = this.aptecaDataSet;
            // 
            // каталог_лекарствTableAdapter
            // 
            this.каталог_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Diplom.aptecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аптеки_приходTableAdapter = null;
            this.tableAdapterManager.Аптеки_расходTableAdapter = null;
            this.tableAdapterManager.АптекиTableAdapter = null;
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
            // iDDTextBox
            // 
            this.iDDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталог_лекарствBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(203, 60);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(217, 24);
            this.iDDTextBox.TabIndex = 19;
            // 
            // наименование_лекарстваTextBox
            // 
            this.наименование_лекарстваTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.наименование_лекарстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталог_лекарствBindingSource, "Наименование лекарства", true));
            this.наименование_лекарстваTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.наименование_лекарстваTextBox.Location = new System.Drawing.Point(203, 87);
            this.наименование_лекарстваTextBox.Name = "наименование_лекарстваTextBox";
            this.наименование_лекарстваTextBox.ReadOnly = true;
            this.наименование_лекарстваTextBox.Size = new System.Drawing.Size(217, 24);
            this.наименование_лекарстваTextBox.TabIndex = 20;
            // 
            // каталог_лекарствListBox
            // 
            this.каталог_лекарствListBox.DataSource = this.каталог_лекарствBindingSource;
            this.каталог_лекарствListBox.DisplayMember = "Наименование лекарства";
            this.каталог_лекарствListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.каталог_лекарствListBox.FormattingEnabled = true;
            this.каталог_лекарствListBox.ItemHeight = 19;
            this.каталог_лекарствListBox.Location = new System.Drawing.Point(426, 60);
            this.каталог_лекарствListBox.Name = "каталог_лекарствListBox";
            this.каталог_лекарствListBox.Size = new System.Drawing.Size(181, 213);
            this.каталог_лекарствListBox.TabIndex = 25;
            this.каталог_лекарствListBox.ValueMember = "IDD";
            // 
            // производительComboBox
            // 
            this.производительComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_лекарствBindingSource, "Производитель", true));
            this.производительComboBox.DataSource = this.производительBindingSource;
            this.производительComboBox.DisplayMember = "Наименование";
            this.производительComboBox.Enabled = false;
            this.производительComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.производительComboBox.FormattingEnabled = true;
            this.производительComboBox.Location = new System.Drawing.Point(203, 113);
            this.производительComboBox.Name = "производительComboBox";
            this.производительComboBox.Size = new System.Drawing.Size(217, 24);
            this.производительComboBox.TabIndex = 30;
            this.производительComboBox.ValueMember = "ID";
            // 
            // производительBindingSource
            // 
            this.производительBindingSource.DataMember = "Производитель";
            this.производительBindingSource.DataSource = this.aptecaDataSet;
            // 
            // упаковкаComboBox
            // 
            this.упаковкаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_лекарствBindingSource, "Упаковка", true));
            this.упаковкаComboBox.DataSource = this.упаковкаBindingSource;
            this.упаковкаComboBox.DisplayMember = "Упаковка";
            this.упаковкаComboBox.Enabled = false;
            this.упаковкаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.упаковкаComboBox.FormattingEnabled = true;
            this.упаковкаComboBox.Location = new System.Drawing.Point(203, 140);
            this.упаковкаComboBox.Name = "упаковкаComboBox";
            this.упаковкаComboBox.Size = new System.Drawing.Size(217, 24);
            this.упаковкаComboBox.TabIndex = 32;
            this.упаковкаComboBox.ValueMember = "IDD";
            // 
            // упаковкаBindingSource
            // 
            this.упаковкаBindingSource.DataMember = "Упаковка";
            this.упаковкаBindingSource.DataSource = this.aptecaDataSet;
            // 
            // место_храненияComboBox
            // 
            this.место_храненияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_лекарствBindingSource, "Место хранения", true));
            this.место_храненияComboBox.DataSource = this.место_храненияBindingSource;
            this.место_храненияComboBox.DisplayMember = "Место хранения";
            this.место_храненияComboBox.Enabled = false;
            this.место_храненияComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.место_храненияComboBox.FormattingEnabled = true;
            this.место_храненияComboBox.Location = new System.Drawing.Point(203, 167);
            this.место_храненияComboBox.Name = "место_храненияComboBox";
            this.место_храненияComboBox.Size = new System.Drawing.Size(217, 24);
            this.место_храненияComboBox.TabIndex = 34;
            this.место_храненияComboBox.ValueMember = "IDD";
            // 
            // место_храненияBindingSource
            // 
            this.место_храненияBindingSource.DataMember = "Место хранения";
            this.место_храненияBindingSource.DataSource = this.aptecaDataSet;
            // 
            // заболеваниеComboBox
            // 
            this.заболеваниеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_лекарствBindingSource, "Заболевание", true));
            this.заболеваниеComboBox.DataSource = this.каталог_заболеванийBindingSource;
            this.заболеваниеComboBox.DisplayMember = "Название заболевания";
            this.заболеваниеComboBox.Enabled = false;
            this.заболеваниеComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.заболеваниеComboBox.FormattingEnabled = true;
            this.заболеваниеComboBox.Location = new System.Drawing.Point(203, 194);
            this.заболеваниеComboBox.Name = "заболеваниеComboBox";
            this.заболеваниеComboBox.Size = new System.Drawing.Size(217, 24);
            this.заболеваниеComboBox.TabIndex = 36;
            this.заболеваниеComboBox.ValueMember = "IDD";
            // 
            // каталог_заболеванийBindingSource
            // 
            this.каталог_заболеванийBindingSource.DataMember = "Каталог заболеваний";
            this.каталог_заболеванийBindingSource.DataSource = this.aptecaDataSet;
            // 
            // противопоказанияComboBox
            // 
            this.противопоказанияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_лекарствBindingSource, "Противопоказания", true));
            this.противопоказанияComboBox.DataSource = this.противопоказанияBindingSource;
            this.противопоказанияComboBox.DisplayMember = "Противопоказания";
            this.противопоказанияComboBox.Enabled = false;
            this.противопоказанияComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.противопоказанияComboBox.FormattingEnabled = true;
            this.противопоказанияComboBox.Location = new System.Drawing.Point(203, 221);
            this.противопоказанияComboBox.Name = "противопоказанияComboBox";
            this.противопоказанияComboBox.Size = new System.Drawing.Size(217, 24);
            this.противопоказанияComboBox.TabIndex = 38;
            this.противопоказанияComboBox.ValueMember = "IDD";
            // 
            // противопоказанияBindingSource
            // 
            this.противопоказанияBindingSource.DataMember = "Противопоказания";
            this.противопоказанияBindingSource.DataSource = this.aptecaDataSet;
            // 
            // производительTableAdapter
            // 
            this.производительTableAdapter.ClearBeforeFill = true;
            // 
            // упаковкаTableAdapter
            // 
            this.упаковкаTableAdapter.ClearBeforeFill = true;
            // 
            // каталог_заболеванийTableAdapter
            // 
            this.каталог_заболеванийTableAdapter.ClearBeforeFill = true;
            // 
            // противопоказанияTableAdapter
            // 
            this.противопоказанияTableAdapter.ClearBeforeFill = true;
            // 
            // место_храненияTableAdapter
            // 
            this.место_храненияTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.vmuyk4lo9vq_Nakrw;
            this.ClientSize = new System.Drawing.Size(659, 383);
            this.Controls.Add(this.производительComboBox);
            this.Controls.Add(this.упаковкаComboBox);
            this.Controls.Add(this.место_храненияComboBox);
            this.Controls.Add(this.заболеваниеComboBox);
            this.Controls.Add(this.противопоказанияComboBox);
            this.Controls.Add(this.каталог_лекарствListBox);
            this.Controls.Add(this.наименование_лекарстваTextBox);
            this.Controls.Add(this.iDDTextBox);
            this.Controls.Add(противопоказанияLabel);
            this.Controls.Add(заболеваниеLabel);
            this.Controls.Add(место_храненияLabel);
            this.Controls.Add(упаковкаLabel);
            this.Controls.Add(производительLabel);
            this.Controls.Add(наименование_лекарстваLabel);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Каталог лекарств";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.упаковкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.место_храненияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.противопоказанияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.TextBox наименование_лекарстваTextBox;
        private System.Windows.Forms.ListBox каталог_лекарствListBox;
        private System.Windows.Forms.ComboBox производительComboBox;
        private System.Windows.Forms.ComboBox упаковкаComboBox;
        private System.Windows.Forms.ComboBox место_храненияComboBox;
        private System.Windows.Forms.ComboBox заболеваниеComboBox;
        private System.Windows.Forms.ComboBox противопоказанияComboBox;
        private System.Windows.Forms.BindingSource производительBindingSource;
        private aptecaDataSetTableAdapters.ПроизводительTableAdapter производительTableAdapter;
        private System.Windows.Forms.BindingSource упаковкаBindingSource;
        private aptecaDataSetTableAdapters.УпаковкаTableAdapter упаковкаTableAdapter;
        private System.Windows.Forms.BindingSource каталог_заболеванийBindingSource;
        private aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter каталог_заболеванийTableAdapter;
        private System.Windows.Forms.BindingSource противопоказанияBindingSource;
        private aptecaDataSetTableAdapters.ПротивопоказанияTableAdapter противопоказанияTableAdapter;
        private System.Windows.Forms.BindingSource место_храненияBindingSource;
        private aptecaDataSetTableAdapters.Место_храненияTableAdapter место_храненияTableAdapter;
    }
}