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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                using (linasoftEntities db = new linasoftEntities())
                {
                    string username = textBox1.Text;
                    var person = db.personels.FirstOrDefault(x => x.username == username);

                    if (person != null && PasswordHasher.Verify(textBox2.Text, person.password))
                    {
                        // Upgrade legacy plain-text passwords to a hash on first successful login.
                        if (!PasswordHasher.IsHashed(person.password))
                        {
                            person.password = PasswordHasher.Hash(textBox2.Text);
                            db.SaveChanges();
                        }

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
                        MessageBox.Show("Invalid username or password");
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

