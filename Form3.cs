using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;
using System.Runtime.Remoting.Contexts;

namespace linapot
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        //declaring varaibles
        static int personel_id;
        Form1 f1 = new Form1();


        private void back_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(personel_id);
            f2.Show();
            this.Hide();
        }

        private void change_pass_Click(object sender, EventArgs e)

        {
            


            using (linasoftEntities db = new linasoftEntities())
            {
                var obj = db.personels.Where(x => x.personel_id == personel_id && x.password == textBox1.Text).FirstOrDefault();

                if (pass_txt.Text == rpass_txt.Text)
                {
                    if (obj != null)
                    {
                        obj.password = pass_txt.Text;
                        db.Entry(obj).State = System.Data.Entity.EntityState.Modified;                  
                        MessageBox.Show("password modified");
                        pass_txt.Text = rpass_txt.Text = textBox1.Text = "";
                        
                    }
                  
                }
                else
                {
                    MessageBox.Show("the passwords you entered do not match");
                    pass_txt.Text = rpass_txt.Text = "";
                }

                db.SaveChanges();
            }

        }
   
        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            

           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the picture to use as your profile pic";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;
            }

            using (linasoftEntities db = new linasoftEntities())
            {
                var obj = db.personels.Where(x => x.personel_id == personel_id).FirstOrDefault();

                if (obj != null)
                {

                    obj.profile_image = ConvertfileToByte(this.pictureBox1.ImageLocation);
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                          
                }
                if (obj.personel_id != 0)
                    db.SaveChanges();
                else
                {
                    obj.personel_id = personel_id;
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //form methods 
        private byte[] ConvertfileToByte(string path)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(path);
            long numbytes = finfo.Length;
            FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numbytes);
            return data;
        }

    }
}
    


