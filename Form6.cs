using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace linapot
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            Form4 admin = new Form4();
            admin.Show();
            this.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox2.Text=textBox3.Text= "";
          
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null)
            {
                var person = new personel();
                person.name = textBox1.Text;
                person.surname = textBox2.Text;
                person.username = textBox3.Text;
                person.password = "hello";
                person.profile_image = null;
                using (linasoftEntities db = new linasoftEntities())
                {
                    db.personels.Add(person);
                    db.SaveChanges();
                    MessageBox.Show("Personel created");
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("please fill in the required info");
            }
           
        }
    }
}
