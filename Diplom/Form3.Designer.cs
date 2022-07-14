namespace Diplom
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.aptecaDataSet = new Diplom.aptecaDataSet();
            this.каталог_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_лекарствTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter();
            this.tableAdapterManager = new Diplom.aptecaDataSetTableAdapters.TableAdapterManager();
            this.каталог_заболеванийTableAdapter = new Diplom.aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter();
            this.каталог_лекарствListBox = new System.Windows.Forms.ListBox();
            this.каталог_заболеванийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_заболеванийListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.Каталог_заболеванийTableAdapter = this.каталог_заболеванийTableAdapter;
            this.tableAdapterManager.Каталог_лекарствTableAdapter = this.каталог_лекарствTableAdapter;
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
            // каталог_лекарствListBox
            // 
            this.каталог_лекарствListBox.BackColor = System.Drawing.Color.White;
            this.каталог_лекарствListBox.DataSource = this.каталог_лекарствBindingSource;
            this.каталог_лекарствListBox.DisplayMember = "Наименование лекарства";
            this.каталог_лекарствListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.каталог_лекарствListBox.FormattingEnabled = true;
            this.каталог_лекарствListBox.ItemHeight = 16;
            this.каталог_лекарствListBox.Location = new System.Drawing.Point(271, 65);
            this.каталог_лекарствListBox.Name = "каталог_лекарствListBox";
            this.каталог_лекарствListBox.Size = new System.Drawing.Size(256, 308);
            this.каталог_лекарствListBox.TabIndex = 1;
            this.каталог_лекарствListBox.ValueMember = "IDD";
            // 
            // каталог_заболеванийBindingSource
            // 
            this.каталог_заболеванийBindingSource.DataMember = "Каталог заболеваний";
            this.каталог_заболеванийBindingSource.DataSource = this.aptecaDataSet;
            // 
            // каталог_заболеванийListBox
            // 
            this.каталог_заболеванийListBox.BackColor = System.Drawing.Color.White;
            this.каталог_заболеванийListBox.DataSource = this.каталог_заболеванийBindingSource;
            this.каталог_заболеванийListBox.DisplayMember = "Название заболевания";
            this.каталог_заболеванийListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.каталог_заболеванийListBox.FormattingEnabled = true;
            this.каталог_заболеванийListBox.ItemHeight = 16;
            this.каталог_заболеванийListBox.Location = new System.Drawing.Point(9, 65);
            this.каталог_заболеванийListBox.Name = "каталог_заболеванийListBox";
            this.каталог_заболеванийListBox.Size = new System.Drawing.Size(256, 308);
            this.каталог_заболеванийListBox.TabIndex = 2;
            this.каталог_заболеванийListBox.ValueMember = "IDD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Image = global::Diplom.Properties.Resources.tlb_logout_12;
            this.button1.Location = new System.Drawing.Point(9, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(518, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(9, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Поиск по заболеванию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(271, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Наличие препарата в аптеке";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Diplom.Properties.Resources.обработки_и_екарства_в_группе_в_составе_кучи_пи_ю_ьки_и_vit_76264140;
            this.ClientSize = new System.Drawing.Size(537, 429);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.каталог_заболеванийListBox);
            this.Controls.Add(this.каталог_лекарствListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подобрать лекарство";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_заболеванийBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private aptecaDataSet aptecaDataSet;
        private System.Windows.Forms.BindingSource каталог_лекарствBindingSource;
        private aptecaDataSetTableAdapters.Каталог_лекарствTableAdapter каталог_лекарствTableAdapter;
        private aptecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private aptecaDataSetTableAdapters.Каталог_заболеванийTableAdapter каталог_заболеванийTableAdapter;
        private System.Windows.Forms.ListBox каталог_лекарствListBox;
        private System.Windows.Forms.BindingSource каталог_заболеванийBindingSource;
        private System.Windows.Forms.ListBox каталог_заболеванийListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}