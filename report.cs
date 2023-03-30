using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace linapot
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }
        static int client_id=0;
        static int personel_id=0;
        static int type = 0;
        static int reason = 0;






        private void report_Load(object sender, EventArgs e)
        {          
            loadclient_bx();
            loadperson_bx();
            loadtype_bx();
            loadreason_bx();
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            dateTimePicker2.Value = DateTime.Now;
        }

        private void loadperson_bx()
        {

            var personel = new personel();
            using (linasoftEntities db = new linasoftEntities())
            {

                foreach (var item in db.personels.Where(a => a.name != null))
                {
                    person_bx.DataSource = db.personels.ToList();
                    person_bx.DisplayMember = "username";
                    person_bx.ValueMember = "personel_id";
                    person_bx.Text = item.name;
                    person_bx.SelectedIndex = -1;

                }
            }

        }
        private void loadclient_bx()
        {

            var client = new client();
            using (linasoftEntities db = new linasoftEntities())
            {

                foreach (var item in db.clients.Where(a => a.name != null))
                {
                    client_bx.DataSource = db.clients.ToList();
                    client_bx.DisplayMember = "name";
                    client_bx.ValueMember = "client_id";
                    client_bx.Text = item.name;
                    client_bx.SelectedIndex = -1;

                }
            }

        }
        private void loadreason_bx()
        {


            

            var inte = new interaction();
            using (linasoftEntities db = new linasoftEntities())
            {


                var obj = db.interactions.GroupBy(x => x.reasonexp).Select(x => x.FirstOrDefault());


                reason_bx.DataSource = obj.ToList();
                reason_bx.DisplayMember = "reasonexp";
                reason_bx.ValueMember = "reason";
                reason_bx.SelectedIndex = -1;
            }

        }
        private void loadtype_bx()
        {
            using (linasoftEntities db = new linasoftEntities())
            {


                var obj = db.interactions.GroupBy(x => x.typeexp).Select(x => x.FirstOrDefault());


                type_bx.DataSource = obj.ToList();
                type_bx.DisplayMember = "typeexp";
                type_bx.ValueMember = "type";
                type_bx.SelectedIndex = -1;



            }

        }
        private void person_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            personel obj = person_bx.SelectedItem as personel;
            if (obj != null)
            {
                personel_id = obj.personel_id;
            }
            else
            {
                personel_id = 0;
            }

        }

        private void reason_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            interaction obj = reason_bx.SelectedItem as interaction;
            if (obj != null)
            {
                reason = obj.reason;
            }
            else
            {
                reason = 0;
            }

        }

        private void type_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            interaction obj = type_bx.SelectedItem as interaction;
            if (obj != null)
            {
                type = obj.type;
            }
            else
            {
                type = 0;
            }

        }

        private void client_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            client obj = client_bx.SelectedItem as client;
            if (obj != null)
            {
                client_id = obj.client_id;
            }
            else
            {
                client_id = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<data_grid> re, ty, p_id, c_id,date;
            using (linasoftEntities db = new linasoftEntities())
            {
                if (reason == 0)
                {
                    re = db.data_grid.Where(x => x.reason != 0).ToList();
                }
                else
                {
                    re = db.data_grid.Where(x => x.reason == reason).ToList();
                }
                if (type == 0)
                {
                    ty = db.data_grid.Where(x => x.type!= 0).ToList();
                }
                else
                {
                    ty = db.data_grid.Where(x => x.type == type).ToList();
                }
                if (personel_id == 0)
                {
                    p_id= db.data_grid.Where(x => x.personel_id != 0).ToList();
                }
                else
                {
                    p_id= db.data_grid.Where(x => x.personel_id == personel_id).ToList();
                }
                if (client_id == 0)
                {
                    c_id= db.data_grid.Where(x => x.client_id != 0).ToList();
                }
                else
                {
                    c_id= db.data_grid.Where(x => x.client_id == client_id).ToList();
                }
                date=db.data_grid.Where(x=>x.date >= dateTimePicker1.Value && x.date<=dateTimePicker2.Value).ToList();
                dataGridView1.DataSource = p_id.Intersect(c_id.Intersect(re.Intersect(ty.Intersect(date)))).ToList();
                
            }
        }
    }
}
