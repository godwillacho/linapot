namespace linapot
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rpass_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_pass = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rpass_txt
            // 
            this.rpass_txt.Location = new System.Drawing.Point(264, 182);
            this.rpass_txt.Name = "rpass_txt";
            this.rpass_txt.PasswordChar = '*';
            this.rpass_txt.Size = new System.Drawing.Size(297, 20);
            this.rpass_txt.TabIndex = 2;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(264, 113);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(297, 20);
            this.pass_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat new password";
            // 
            // change_pass
            // 
            this.change_pass.BackColor = System.Drawing.Color.DarkGreen;
            this.change_pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.change_pass.Location = new System.Drawing.Point(477, 237);
            this.change_pass.Name = "change_pass";
            this.change_pass.Size = new System.Drawing.Size(75, 23);
            this.change_pass.TabIndex = 8;
            this.change_pass.Text = "SAVE";
            this.change_pass.UseVisualStyleBackColor = false;
            this.change_pass.Click += new System.EventHandler(this.change_pass_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::linapot.Properties.Resources.back_button;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.Location = new System.Drawing.Point(22, 1);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(28, 29);
            this.back_btn.TabIndex = 9;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::linapot.Properties.Resources.profilepicture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(15, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "click to change profile pic";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label4_MouseClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.change_pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.rpass_txt);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox rpass_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button change_pass;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label4;
    }
}