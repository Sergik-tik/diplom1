namespace WindowsFormsApp4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nagruzkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dipDataSet = new WindowsFormsApp4.DipDataSet();
            this.dipDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nagruzkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nagruzkaTableAdapter = new WindowsFormsApp4.DipDataSetTableAdapters.NagruzkaTableAdapter();
            this.kursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruppaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korpusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kabinetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wremiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagruzkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studkolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kursDataGridViewTextBoxColumn,
            this.gruppaDataGridViewTextBoxColumn,
            this.korpusDataGridViewTextBoxColumn,
            this.kabinetDataGridViewTextBoxColumn,
            this.wremiDataGridViewTextBoxColumn,
            this.nagruzkaDataGridViewTextBoxColumn,
            this.studkolDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nagruzkaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // nagruzkaBindingSource
            // 
            this.nagruzkaBindingSource.DataSource = this.dipDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(852, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dipDataSet
            // 
            this.dipDataSet.DataSetName = "DipDataSet";
            this.dipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dipDataSetBindingSource1
            // 
            this.dipDataSetBindingSource1.DataSource = this.dipDataSet;
            this.dipDataSetBindingSource1.Position = 0;
            // 
            // nagruzkaBindingSource1
            // 
            this.nagruzkaBindingSource1.DataMember = "Nagruzka";
            this.nagruzkaBindingSource1.DataSource = this.dipDataSetBindingSource1;
            // 
            // nagruzkaTableAdapter
            // 
            this.nagruzkaTableAdapter.ClearBeforeFill = true;
            // 
            // kursDataGridViewTextBoxColumn
            // 
            this.kursDataGridViewTextBoxColumn.DataPropertyName = "kurs";
            this.kursDataGridViewTextBoxColumn.HeaderText = "kurs";
            this.kursDataGridViewTextBoxColumn.Name = "kursDataGridViewTextBoxColumn";
            // 
            // gruppaDataGridViewTextBoxColumn
            // 
            this.gruppaDataGridViewTextBoxColumn.DataPropertyName = "Gruppa";
            this.gruppaDataGridViewTextBoxColumn.HeaderText = "Gruppa";
            this.gruppaDataGridViewTextBoxColumn.Name = "gruppaDataGridViewTextBoxColumn";
            // 
            // korpusDataGridViewTextBoxColumn
            // 
            this.korpusDataGridViewTextBoxColumn.DataPropertyName = "Korpus";
            this.korpusDataGridViewTextBoxColumn.HeaderText = "Korpus";
            this.korpusDataGridViewTextBoxColumn.Name = "korpusDataGridViewTextBoxColumn";
            // 
            // kabinetDataGridViewTextBoxColumn
            // 
            this.kabinetDataGridViewTextBoxColumn.DataPropertyName = "Kabinet";
            this.kabinetDataGridViewTextBoxColumn.HeaderText = "Kabinet";
            this.kabinetDataGridViewTextBoxColumn.Name = "kabinetDataGridViewTextBoxColumn";
            // 
            // wremiDataGridViewTextBoxColumn
            // 
            this.wremiDataGridViewTextBoxColumn.DataPropertyName = "Wremi";
            this.wremiDataGridViewTextBoxColumn.HeaderText = "Wremi";
            this.wremiDataGridViewTextBoxColumn.Name = "wremiDataGridViewTextBoxColumn";
            // 
            // nagruzkaDataGridViewTextBoxColumn
            // 
            this.nagruzkaDataGridViewTextBoxColumn.DataPropertyName = "Nagruzka";
            this.nagruzkaDataGridViewTextBoxColumn.HeaderText = "Nagruzka";
            this.nagruzkaDataGridViewTextBoxColumn.Name = "nagruzkaDataGridViewTextBoxColumn";
            // 
            // studkolDataGridViewTextBoxColumn
            // 
            this.studkolDataGridViewTextBoxColumn.DataPropertyName = "Stud_kol";
            this.studkolDataGridViewTextBoxColumn.HeaderText = "Stud_kol";
            this.studkolDataGridViewTextBoxColumn.Name = "studkolDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 492);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Нагрузка";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagruzkaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dipDataSetBindingSource;
        private System.Windows.Forms.BindingSource nagruzkaBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource dipDataSetBindingSource1;
        private DipDataSet dipDataSet;
        private System.Windows.Forms.BindingSource nagruzkaBindingSource1;
        private DipDataSetTableAdapters.NagruzkaTableAdapter nagruzkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruppaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kabinetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wremiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagruzkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studkolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
    }
}