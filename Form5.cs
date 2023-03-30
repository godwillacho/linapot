using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linapot
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            fillcombobox();
        }
        static int location_id;
        private void back_btn_Click(object sender, EventArgs e)
        {
            Form4 admin=new Form4();
            admin.Show();
            this.Hide();

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
        }
        private void fillcombobox()
        {
            using (linasoftEntities db = new linasoftEntities())
            {

                foreach (var item in db.locations.Where(a => a.name != null))
                {
                    comboBox1.DataSource = db.locations.ToList();


                    comboBox1.DisplayMember = "name";
                    comboBox1.ValueMember = "location_id";
                    comboBox1.Text = item.name;
                    comboBox1.SelectedIndex = -1;

                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            location obj = comboBox1.SelectedItem as location;
            if (obj != null)
            {
                location_id= obj.location_id;
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            client cl = new client();
            cl.name = textBox1.Text;
            cl.location_id = location_id;
            if (comboBox1.SelectedIndex != -1 && textBox1.Text != null)
            {
                using (linasoftEntities db = new linasoftEntities())
                {
                    db.clients.Add(cl);
                    db.SaveChanges();
                    MessageBox.Show("client succesfully created");
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                }
            }
            else
            {

                MessageBox.Show("please fill in the required info");
            }
        }
    }
}
