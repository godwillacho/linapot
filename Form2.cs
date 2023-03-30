using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linapot
{
    public partial class Form2 : Form
    {
       
        public Form2(int p_id)
        {
            InitializeComponent();
            id = p_id;
           
        }

        //loading form components
        private void Form2_Load(object sender, EventArgs e)
        {

            fillcombobox();
            loaddatagrid(id);
        }
        private void fillcombobox()
        {


            var client = new client();
            using (linasoftEntities db = new linasoftEntities())
            {

                foreach (var item in db.clients.Where(a => a.name != null))
                {
                    clientname_btn.DataSource = db.clients.ToList();


                    clientname_btn.DisplayMember = "name";
                    clientname_btn.ValueMember = "client_id";
                    clientname_btn.Text = item.name;
                    clientname_btn.SelectedIndex = -1;

                }

            }
        }
        void loaddatagrid(int p_id)
        {

            using (linasoftEntities db = new linasoftEntities())
            {
                datagrid.DataSource = db.data_grid.Where(x => x.personel_id == p_id).ToList();

            }
        }


        //initialising varaibles
        static int id;
        static int reasons;
        static int types;
        static int client_id;
        Form1 h = new Form1(); 
        static int interaction_id;
        private object data_gridTableAdapter;

    //methods   
        private void reason()
        {
            if (btn_train.Checked)
            {
                reasons = 1;
            }

            else if (btn_bug.Checked)

                reasons = 2;

            else if (btn_feat.Checked)
            {
                reasons = 3;
            }
            else if (btn_orther.Checked)
            {
                reasons = 4;
            }
            else
            {
                MessageBox.Show("choose the reason for interaction");

            }
        }
        private void type()
        {
            if (btn_phone.Checked)
            {
                types = 1;
            }
            else if (btn_phy.Checked)
            {
                types = 2;
            }
            else if (btn_rem.Checked)
            {
                types = 3;
            }
            else
            {
                MessageBox.Show("select the type of interaction");
            }
        }
        void clear()
        {
            clientname_btn.SelectedItem = null;
            btn_bug.Checked = false;
            btn_feat.Checked = false;
            btn_orther.Checked = false;
            btn_phone.Checked = false;
            btn_phy.Checked = false;
            btn_rem.Checked = false;
            btn_train.Checked = false;
            Detail_btn.Text = "";

        }  
     
        //button onclicks 
        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            type();
            reason();
            String det = Detail_btn.Text.ToString();
            var inte = new interaction();
            inte.pesonel_id = id;
            inte.client_id = client_id;
            inte.type = types;
            inte.reason = reasons;
            inte.details = det;
            inte.date = DateTime.Now;
            inte.id = interaction_id;
            using (linasoftEntities db = new linasoftEntities())
            {
                             
                if (inte.pesonel_id != 0 && inte.type != 0 && inte.details != null && inte.reason !=0)
                {
                    if (inte.id == 0)
                    {
                        db.interactions.Add(inte);
                        MessageBox.Show("record created ");
                    }
                    else
                    {
                        db.Entry(inte).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("record has been updated ");
                       
                    }
                    db.SaveChanges();
                    loaddatagrid(inte.pesonel_id);
                    clear();
                    save_btn.Text = "Save";

                }
                else
                {
                    MessageBox.Show("could now save"+"\n"+inte.type+"\n"+inte.details+"\n"+ inte.reason+"\n"+inte.pesonel_id);
                }
               
            }
           
        }
        private void profile_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }


        private void clientname_btn_SelectedIndexChanged(object sender, EventArgs e)
        {
            client obj = clientname_btn.SelectedItem as client;
            if (obj != null)
            {
                client_id = obj.client_id;
            }
            
            
        }
  
        private void datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagrid.CurrentRow.Index != -1)
            {
                interaction_id = Convert.ToInt32(datagrid.CurrentRow.Cells["i_id"].Value);

            }
            using (linasoftEntities db = new linasoftEntities())
            {
                var obj = db.interactions.Where(x => x.id == interaction_id).FirstOrDefault();
                int val;
                List<client> list = new List<client>();

                val = obj.client_id;
                var cl = db.clients.Where(x => x.client_id == val).FirstOrDefault();
                list.Add(cl);
                int index = clientname_btn.FindString(cl.name);
                clientname_btn.SelectedIndex = index;


                if (obj.type == 1)
                {
                    btn_phone.Checked = true;
                }
                else if (obj.type == 3)
                {
                    btn_rem.Checked = true;
                }
                else
                {
                    btn_phy.Checked = true;
                }
                if (obj.reason == 2)
                {
                    btn_bug.Checked = true;
                }
                else if (obj.reason == 1)
                {
                    btn_train.Checked = true;
                }
                else if (obj.reason == 3)
                {
                    btn_feat.Checked = true;
                }
                else
                {
                    btn_orther.Checked = true;
                }
                Detail_btn.Text = obj.details.ToString();

            }
            save_btn.Text = "UPDATE";
            clear_btn.Enabled = false;
        }

       
       
    }
}


