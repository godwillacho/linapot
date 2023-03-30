namespace linapot
{
    partial class report
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
            this.button1 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.linasoftDataSet1 = new linapot.linasoftDataSet1();
            this.datagridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_gridTableAdapter = new linapot.linasoftDataSet1TableAdapters.data_gridTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type_bx = new System.Windows.Forms.ComboBox();
            this.person_bx = new System.Windows.Forms.ComboBox();
            this.reason_bx = new System.Windows.Forms.ComboBox();
            this.client_bx = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linasoftDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(309, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Make Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::linapot.Properties.Resources.back_button1;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(33, 25);
            this.back_btn.TabIndex = 20;
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // linasoftDataSet1
            // 
            this.linasoftDataSet1.DataSetName = "linasoftDataSet1";
            this.linasoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datagridBindingSource
            // 
            this.datagridBindingSource.DataMember = "data_grid";
            this.datagridBindingSource.DataSource = this.linasoftDataSet1;
            // 
            // data_gridTableAdapter
            // 
            this.data_gridTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.type_bx);
            this.panel1.Controls.Add(this.person_bx);
            this.panel1.Controls.Add(this.reason_bx);
            this.panel1.Controls.Add(this.client_bx);
            this.panel1.Location = new System.Drawing.Point(63, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 148);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "choose type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "choose reason ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "choose personel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose client";
            // 
            // type_bx
            // 
            this.type_bx.FormattingEnabled = true;
            this.type_bx.Location = new System.Drawing.Point(435, 115);
            this.type_bx.Name = "type_bx";
            this.type_bx.Size = new System.Drawing.Size(287, 21);
            this.type_bx.TabIndex = 3;
            this.type_bx.SelectedIndexChanged += new System.EventHandler(this.type_bx_SelectedIndexChanged);
            // 
            // person_bx
            // 
            this.person_bx.FormattingEnabled = true;
            this.person_bx.Location = new System.Drawing.Point(37, 115);
            this.person_bx.Name = "person_bx";
            this.person_bx.Size = new System.Drawing.Size(236, 21);
            this.person_bx.TabIndex = 2;
            this.person_bx.SelectedIndexChanged += new System.EventHandler(this.person_bx_SelectedIndexChanged);
            // 
            // reason_bx
            // 
            this.reason_bx.FormattingEnabled = true;
            this.reason_bx.Location = new System.Drawing.Point(435, 28);
            this.reason_bx.Name = "reason_bx";
            this.reason_bx.Size = new System.Drawing.Size(287, 21);
            this.reason_bx.TabIndex = 1;
            this.reason_bx.SelectedIndexChanged += new System.EventHandler(this.reason_bx_SelectedIndexChanged);
            // 
            // client_bx
            // 
            this.client_bx.FormattingEnabled = true;
            this.client_bx.Location = new System.Drawing.Point(37, 28);
            this.client_bx.Name = "client_bx";
            this.client_bx.Size = new System.Drawing.Size(236, 21);
            this.client_bx.TabIndex = 0;
            this.client_bx.SelectedIndexChanged += new System.EventHandler(this.client_bx_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.reasonexpDataGridViewTextBoxColumn,
            this.typeexpDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.locationidDataGridViewTextBoxColumn,
            this.personelidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datagridBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 178);
            this.dataGridView1.TabIndex = 36;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "c_name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "l_name";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "l_name";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // reasonexpDataGridViewTextBoxColumn
            // 
            this.reasonexpDataGridViewTextBoxColumn.DataPropertyName = "reasonexp";
            this.reasonexpDataGridViewTextBoxColumn.HeaderText = "reasonexp";
            this.reasonexpDataGridViewTextBoxColumn.Name = "reasonexpDataGridViewTextBoxColumn";
            this.reasonexpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeexpDataGridViewTextBoxColumn
            // 
            this.typeexpDataGridViewTextBoxColumn.DataPropertyName = "typeexp";
            this.typeexpDataGridViewTextBoxColumn.HeaderText = "typeexp";
            this.typeexpDataGridViewTextBoxColumn.Name = "typeexpDataGridViewTextBoxColumn";
            this.typeexpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationidDataGridViewTextBoxColumn
            // 
            this.locationidDataGridViewTextBoxColumn.DataPropertyName = "location_id";
            this.locationidDataGridViewTextBoxColumn.HeaderText = "location_id";
            this.locationidDataGridViewTextBoxColumn.Name = "locationidDataGridViewTextBoxColumn";
            this.locationidDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personel_id";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(435, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(287, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "To";
            // 
            // report
            // 
            this.AccessibleName = "report";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_btn);
            this.Name = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linasoftDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button button1;
        private linasoftDataSet1 linasoftDataSet1;
        private System.Windows.Forms.BindingSource datagridBindingSource;
        private linasoftDataSet1TableAdapters.data_gridTableAdapter data_gridTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_bx;
        private System.Windows.Forms.ComboBox person_bx;
        private System.Windows.Forms.ComboBox reason_bx;
        private System.Windows.Forms.ComboBox client_bx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}