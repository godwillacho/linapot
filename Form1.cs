using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linapot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        //initialising variables
        public static int id;
        
        //onclick button
        private void button1_Click(object sender, EventArgs e)
        {
            var context = new linasoftEntities();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
               

                using (linasoftEntities db = new linasoftEntities())
                {
                   var  person = context.personels.FirstOrDefault(x => x.username == textBox1.Text && x.password==textBox2.Text);
                    if (person != null)
                    {
                        if (person.personel_id == 1)
                        {
                            Form4 admin = new Form4();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                            Form2 home = new Form2(person.personel_id);
                            home.Show();
                            this.Hide();
                            textBox1.Text = textBox2.Text = "";
                        }
                        id = Convert.ToInt32(person.personel_id);

                    }                  
                    else
                    {
                        MessageBox.Show("your username and do not match or exist");
                        textBox1.Text = textBox2.Text = "";
                    }
                    
                }
              
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("enter your username ");
                    textBox1.Clear();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("enter your password ");
                    textBox2.Clear();
                }
            }

    
    }
    }

