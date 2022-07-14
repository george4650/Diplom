
namespace Diplom
{
    partial class Form5
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
            System.Windows.Forms.Label тип_заболеванияLabel;
            System.Windows.Forms.Label название_заболеванияLabel;
            System.Windows.Forms.Label симптомыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.каталог_заболеванийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.каталог_заболеванийTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter();
            this.iDDTextBox = new System.Windows.Forms.TextBox();
            this.название_заболеванияTextBox = new System.Windows.Forms.TextBox();
            this.симптомыTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.областьЗаболеванияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.область_заболеванияTableAdapter = new Diplom.aptecaDataSetTableAdapters.Область_заболеванияTableAdapter();
            this.тип_заболеванияComboBox = new System.Windows.Forms.ComboBox();
            this.область_заболеванияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDDLabel = new System.Windows.Forms.Label();
            тип_заболеванияLabel = new System.Windows.Forms.Label();
            название_заболеванияLabel = new System.Windows.Forms.Label();
            симптомыLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.областьЗаболеванияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_заболеванияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDLabel
            // 
            iDDLabel.AutoSize = true;
            iDDLabel.BackColor = System.Drawing.Color.White;
            iDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            iDDLabel.Location = new System.Drawing.Point(106, 46);
            iDDLabel.Name = "iDDLabel";
            iDDLabel.Size = new System.Drawing.Size(37, 18);
            iDDLabel.TabIndex = 1;
            iDDLabel.Text = "IDD:";
            // 
            // тип_заболеванияLabel
            // 
            тип_заболеванияLabel.AutoSize = true;
            тип_заболеванияLabel.BackColor = System.Drawing.Color.White;
            тип_заболеванияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            тип_заболеванияLabel.Location = new System.Drawing.Point(37, 81);
            тип_заболеванияLabel.Name = "тип_заболеванияLabel";
            тип_заболеванияLabel.Size = new System.Drawing.Size(132, 18);
            тип_заболеванияLabel.TabIndex = 3;
            тип_заболеванияLabel.Text = "Тип заболевания:";
            // 
            // название_заболеванияLabel
            // 
            название_заболеванияLabel.AutoSize = true;
            название_заболеванияLabel.BackColor = System.Drawing.Color.White;
            название_заболеванияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            название_заболеванияLabel.Location = new System.Drawing.Point(6, 116);
            название_заболеванияLabel.Name = "название_заболеванияLabel";
            название_заболеванияLabel.Size = new System.Drawing.Size(174, 18);
            название_заболеванияLabel.TabIndex = 5;
            название_заболеванияLabel.Text = "Название заболевания:";
            // 
            // симптомыLabel
            // 
            симптомыLabel.AutoSize = true;
            симптомыLabel.BackColor = System.Drawing.Color.White;
            симптомыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            симптомыLabel.Location = new System.Drawing.Point(71, 152);
            симптомыLabel.Name = "симптомыLabel";
            симптомыLabel.Size = new System.Drawing.Size(88, 18);
            симптомыLabel.TabIndex = 7;
            симптомыLabel.Text = "Симптомы:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(62, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "⯈";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(131, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "Добавить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(15, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "⯇";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // каталог_заболеванийBindingSource
            // 
            this.каталог_заболеванийBindingSource.DataMember = "Каталог заболеваний";
            this.каталог_заболеванийBindingSource.DataSource = this.aptecaDataSet;
            // 
            // aptecaDataSet
            // 
            this.aptecaDataSet.DataSetName = "aptecaDataSet";
            this.aptecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Diplom.aptecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аптеки_приходTableAdapter = null;
            this.tableAdapterManager.Аптеки_расходTableAdapter = null;
            this.tableAdapterManager.АптекиTableAdapter = null;
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = this.каталог_заболеванийTableAdapter;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = null;
            this.tableAdapterManager.Место_храненияTableAdapter = null;
            this.tableAdapterManager.Область_заболеванияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПроизводительTableAdapter = null;
            this.tableAdapterManager.ПротивопоказанияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УпаковкаTableAdapter = null;
            // 
            // каталог_заболеванийTableAdapter
            // 
            this.каталог_заболеванийTableAdapter.ClearBeforeFill = true;
            // 
            // iDDTextBox
            // 
            this.iDDTextBox.BackColor = System.Drawing.Color.White;
            this.iDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталог_заболеванийBindingSource, "IDD", true));
            this.iDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDDTextBox.Location = new System.Drawing.Point(184, 43);
            this.iDDTextBox.Name = "iDDTextBox";
            this.iDDTextBox.ReadOnly = true;
            this.iDDTextBox.Size = new System.Drawing.Size(272, 24);
            this.iDDTextBox.TabIndex = 2;
            // 
            // название_заболеванияTextBox
            // 
            this.название_заболеванияTextBox.BackColor = System.Drawing.Color.White;
            this.название_заболеванияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталог_заболеванийBindingSource, "Название заболевания", true));
            this.название_заболеванияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.название_заболеванияTextBox.Location = new System.Drawing.Point(184, 113);
            this.название_заболеванияTextBox.Name = "название_заболеванияTextBox";
            this.название_заболеванияTextBox.ReadOnly = true;
            this.название_заболеванияTextBox.Size = new System.Drawing.Size(272, 24);
            this.название_заболеванияTextBox.TabIndex = 2;
            // 
            // симптомыTextBox
            // 
            this.симптомыTextBox.BackColor = System.Drawing.Color.White;
            this.симптомыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каталог_заболеванийBindingSource, "Симптомы", true));
            this.симптомыTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.симптомыTextBox.Location = new System.Drawing.Point(184, 149);
            this.симптомыTextBox.Multiline = true;
            this.симптомыTextBox.Name = "симптомыTextBox";
            this.симптомыTextBox.ReadOnly = true;
            this.симптомыTextBox.Size = new System.Drawing.Size(272, 64);
            this.симптомыTextBox.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Image = global::Diplom.Properties.Resources.tlb_logout_11;
            this.button4.Location = new System.Drawing.Point(357, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 35);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(291, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 29);
            this.button5.TabIndex = 34;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Form5_Load);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(40, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 29);
            this.button6.TabIndex = 33;
            this.button6.Text = "ОК";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // областьЗаболеванияBindingSource
            // 
            this.областьЗаболеванияBindingSource.DataMember = "Область заболевания";
            this.областьЗаболеванияBindingSource.DataSource = this.aptecaDataSet;
            // 
            // область_заболеванияTableAdapter
            // 
            this.область_заболеванияTableAdapter.ClearBeforeFill = true;
            // 
            // тип_заболеванияComboBox
            // 
            this.тип_заболеванияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталог_заболеванийBindingSource, "Тип заболевания", true));
            this.тип_заболеванияComboBox.DataSource = this.область_заболеванияBindingSource;
            this.тип_заболеванияComboBox.DisplayMember = "Область";
            this.тип_заболеванияComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.тип_заболеванияComboBox.FormattingEnabled = true;
            this.тип_заболеванияComboBox.Location = new System.Drawing.Point(184, 78);
            this.тип_заболеванияComboBox.Name = "тип_заболеванияComboBox";
            this.тип_заболеванияComboBox.Size = new System.Drawing.Size(272, 26);
            this.тип_заболеванияComboBox.TabIndex = 35;
            this.тип_заболеванияComboBox.ValueMember = "IDD";
            // 
            // область_заболеванияBindingSource
            // 
            this.область_заболеванияBindingSource.DataMember = "Область заболевания";
            this.область_заболеванияBindingSource.DataSource = this.aptecaDataSet;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.corona_gfeece6654_6402;
            this.ClientSize = new System.Drawing.Size(476, 282);
            this.Controls.Add(this.тип_заболеванияComboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(симптомыLabel);
            this.Controls.Add(this.симптомыTextBox);
            this.Controls.Add(название_заболеванияLabel);
            this.Controls.Add(this.название_заболеванияTextBox);
            this.Controls.Add(тип_заболеванияLabel);
            this.Controls.Add(iDDLabel);
            this.Controls.Add(this.iDDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список заболеваний";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.областьЗаболеванияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_заболеванияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource каталог_заболеванийBindingSource;
        private aptecaDataSet aptecaDataSet;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter каталог_заболеванийTableAdapter;
        private System.Windows.Forms.TextBox iDDTextBox;
        private System.Windows.Forms.TextBox название_заболеванияTextBox;
        private System.Windows.Forms.TextBox симптомыTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource областьЗаболеванияBindingSource;
        private aptecaDataSetTableAdapters.Область_заболеванияTableAdapter область_заболеванияTableAdapter;
        private System.Windows.Forms.ComboBox тип_заболеванияComboBox;
        private System.Windows.Forms.BindingSource область_заболеванияBindingSource;
    }
}