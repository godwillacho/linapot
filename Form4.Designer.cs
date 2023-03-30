namespace linapot
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
            this.create_personel = new System.Windows.Forms.Button();
            this.client_btn = new System.Windows.Forms.Button();
            this.work_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_personel
            // 
            this.create_personel.BackgroundImage = global::linapot.Properties.Resources.profilepicture;
            this.create_personel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.create_personel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create_personel.Location = new System.Drawing.Point(386, 65);
            this.create_personel.Name = "create_personel";
            this.create_personel.Size = new System.Drawing.Size(226, 177);
            this.create_personel.TabIndex = 1;
            this.create_personel.Text = "Create Personel";
            this.create_personel.UseVisualStyleBackColor = true;
            this.create_personel.Click += new System.EventHandler(this.create_personel_Click);
            // 
            // client_btn
            // 
            this.client_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.client_btn.BackgroundImage = global::linapot.Properties.Resources.client;
            this.client_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.client_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.client_btn.Location = new System.Drawing.Point(151, 65);
            this.client_btn.Name = "client_btn";
            this.client_btn.Size = new System.Drawing.Size(215, 177);
            this.client_btn.TabIndex = 0;
            this.client_btn.Text = "Create Client";
            this.client_btn.UseVisualStyleBackColor = false;
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // work_btn
            // 
            this.work_btn.Location = new System.Drawing.Point(33, 22);
            this.work_btn.Name = "work_btn";
            this.work_btn.Size = new System.Drawing.Size(89, 41);
            this.work_btn.TabIndex = 2;
            this.work_btn.Text = "WorkStation";
            this.work_btn.UseVisualStyleBackColor = true;
            this.work_btn.Click += new System.EventHandler(this.work_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.Location = new System.Drawing.Point(267, 248);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(214, 141);
            this.report_btn.TabIndex = 3;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.work_btn);
            this.Controls.Add(this.create_personel);
            this.Controls.Add(this.client_btn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button client_btn;
        private System.Windows.Forms.Button create_personel;
        private System.Windows.Forms.Button work_btn;
        private System.Windows.Forms.Button report_btn;
    }
}