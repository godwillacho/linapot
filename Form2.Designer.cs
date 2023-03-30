namespace linapot
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
            this.clientname_btn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_rem = new System.Windows.Forms.RadioButton();
            this.btn_phy = new System.Windows.Forms.RadioButton();
            this.btn_phone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_orther = new System.Windows.Forms.RadioButton();
            this.btn_bug = new System.Windows.Forms.RadioButton();
            this.btn_feat = new System.Windows.Forms.RadioButton();
            this.btn_train = new System.Windows.Forms.RadioButton();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profile_btn = new System.Windows.Forms.Button();
            this.Detail_btn = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientname_btn
            // 
            this.clientname_btn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clientname_btn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientname_btn.FormattingEnabled = true;
            this.clientname_btn.Location = new System.Drawing.Point(25, 72);
            this.clientname_btn.Name = "clientname_btn";
            this.clientname_btn.Size = new System.Drawing.Size(258, 21);
            this.clientname_btn.TabIndex = 1;
            this.clientname_btn.SelectedIndexChanged += new System.EventHandler(this.clientname_btn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rem);
            this.groupBox1.Controls.Add(this.btn_phy);
            this.groupBox1.Controls.Add(this.btn_phone);
            this.groupBox1.Location = new System.Drawing.Point(25, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "means of interaction";
            // 
            // btn_rem
            // 
            this.btn_rem.AutoSize = true;
            this.btn_rem.Location = new System.Drawing.Point(79, 41);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(113, 17);
            this.btn_rem.TabIndex = 2;
            this.btn_rem.TabStop = true;
            this.btn_rem.Text = "remote connection";
            this.btn_rem.UseVisualStyleBackColor = true;
            // 
            // btn_phy
            // 
            this.btn_phy.AutoSize = true;
            this.btn_phy.Location = new System.Drawing.Point(149, 18);
            this.btn_phy.Name = "btn_phy";
            this.btn_phy.Size = new System.Drawing.Size(103, 17);
            this.btn_phy.TabIndex = 1;
            this.btn_phy.TabStop = true;
            this.btn_phy.Text = "physical meeting";
            this.btn_phy.UseVisualStyleBackColor = true;
            // 
            // btn_phone
            // 
            this.btn_phone.AutoSize = true;
            this.btn_phone.Location = new System.Drawing.Point(12, 18);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(75, 17);
            this.btn_phone.TabIndex = 0;
            this.btn_phone.TabStop = true;
            this.btn_phone.Text = "Phone call";
            this.btn_phone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_orther);
            this.groupBox2.Controls.Add(this.btn_bug);
            this.groupBox2.Controls.Add(this.btn_feat);
            this.groupBox2.Controls.Add(this.btn_train);
            this.groupBox2.Location = new System.Drawing.Point(25, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "reason for interaction";
            // 
            // btn_orther
            // 
            this.btn_orther.AutoSize = true;
            this.btn_orther.Location = new System.Drawing.Point(139, 49);
            this.btn_orther.Name = "btn_orther";
            this.btn_orther.Size = new System.Drawing.Size(54, 17);
            this.btn_orther.TabIndex = 3;
            this.btn_orther.TabStop = true;
            this.btn_orther.Text = "Orther";
            this.btn_orther.UseVisualStyleBackColor = true;
            // 
            // btn_bug
            // 
            this.btn_bug.AutoSize = true;
            this.btn_bug.Location = new System.Drawing.Point(11, 49);
            this.btn_bug.Name = "btn_bug";
            this.btn_bug.Size = new System.Drawing.Size(57, 17);
            this.btn_bug.TabIndex = 2;
            this.btn_bug.TabStop = true;
            this.btn_bug.Text = "Bug fix";
            this.btn_bug.UseVisualStyleBackColor = true;
            // 
            // btn_feat
            // 
            this.btn_feat.AutoSize = true;
            this.btn_feat.Location = new System.Drawing.Point(139, 19);
            this.btn_feat.Name = "btn_feat";
            this.btn_feat.Size = new System.Drawing.Size(99, 17);
            this.btn_feat.TabIndex = 1;
            this.btn_feat.TabStop = true;
            this.btn_feat.Text = "Feature request";
            this.btn_feat.UseVisualStyleBackColor = true;
            // 
            // btn_train
            // 
            this.btn_train.AutoSize = true;
            this.btn_train.Location = new System.Drawing.Point(11, 19);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(101, 17);
            this.btn_train.TabIndex = 0;
            this.btn_train.TabStop = true;
            this.btn_train.Text = "Training request";
            this.btn_train.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.save_btn.Location = new System.Drawing.Point(25, 415);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(72, 25);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clear_btn.Location = new System.Drawing.Point(191, 415);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(72, 25);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(22, 47);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(79, 13);
            this.labe.TabIndex = 9;
            this.labe.Text = "company name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Details";
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.profile_btn.Location = new System.Drawing.Point(3, 0);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(237, 23);
            this.profile_btn.TabIndex = 11;
            this.profile_btn.Text = "Profile manager";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // Detail_btn
            // 
            this.Detail_btn.Location = new System.Drawing.Point(25, 302);
            this.Detail_btn.Multiline = true;
            this.Detail_btn.Name = "Detail_btn";
            this.Detail_btn.Size = new System.Drawing.Size(204, 94);
            this.Detail_btn.TabIndex = 12;
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_name,
            this.location,
            this.Reason_,
            this.Type_,
            this.date,
            this.location_id,
            this.type_id,
            this.reason_id,
            this.username,
            this.i_id,
            this.personel_id,
            this.c_id});
            this.datagrid.DataSource = this.datagridBindingSource;
            this.datagrid.Location = new System.Drawing.Point(301, 12);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(363, 384);
            this.datagrid.TabIndex = 13;
            this.datagrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagrid_MouseDoubleClick);
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "c_name";
            this.client_name.HeaderText = "client_name";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "l_name";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // Reason_
            // 
            this.Reason_.DataPropertyName = "reasonexp";
            this.Reason_.HeaderText = "Reason";
            this.Reason_.Name = "Reason_";
            this.Reason_.ReadOnly = true;
            // 
            // Type_
            // 
            this.Type_.DataPropertyName = "typeexp";
            this.Type_.HeaderText = "Type";
            this.Type_.Name = "Type_";
            this.Type_.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // location_id
            // 
            this.location_id.DataPropertyName = "location_id";
            this.location_id.HeaderText = "location_id";
            this.location_id.Name = "location_id";
            this.location_id.ReadOnly = true;
            this.location_id.Visible = false;
            // 
            // type_id
            // 
            this.type_id.DataPropertyName = "type";
            this.type_id.HeaderText = "type_id";
            this.type_id.Name = "type_id";
            this.type_id.ReadOnly = true;
            this.type_id.Visible = false;
            // 
            // reason_id
            // 
            this.reason_id.DataPropertyName = "reason";
            this.reason_id.HeaderText = "reason_id";
            this.reason_id.Name = "reason_id";
            this.reason_id.ReadOnly = true;
            this.reason_id.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // i_id
            // 
            this.i_id.DataPropertyName = "id";
            this.i_id.HeaderText = "id";
            this.i_id.Name = "i_id";
            this.i_id.ReadOnly = true;
            this.i_id.Visible = false;
            // 
            // personel_id
            // 
            this.personel_id.DataPropertyName = "personel_id";
            this.personel_id.HeaderText = "personel_id";
            this.personel_id.Name = "personel_id";
            this.personel_id.ReadOnly = true;
            this.personel_id.Visible = false;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "client_id";
            this.c_id.HeaderText = "client id";
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Visible = false;
            // 
            // datagridBindingSource
            // 
            this.datagridBindingSource.DataSource = typeof(linapot.data_grid);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 443);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.Detail_btn);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientname_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox clientname_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_rem;
        private System.Windows.Forms.RadioButton btn_phy;
        private System.Windows.Forms.RadioButton btn_phone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btn_orther;
        private System.Windows.Forms.RadioButton btn_bug;
        private System.Windows.Forms.RadioButton btn_feat;
        private System.Windows.Forms.RadioButton btn_train;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button profile_btn;
    
        private System.Windows.Forms.TextBox Detail_btn;

        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.BindingSource datagridBindingSource;
    }
}