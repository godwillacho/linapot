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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void work_btn_Click(object sender, EventArgs e)
        {
            Form2 work_station = new Form2(personel_id);
            work_station.Show();
        }
        int personel_id;
        private void client_btn_Click(object sender, EventArgs e)
        {
            Form5 create_client=new Form5();
            create_client.Show();
            this.Hide();
        }

        private void create_personel_Click(object sender, EventArgs e)
        {
            Form6 create_personel = new Form6();
            create_personel.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report r=new report();
            r.Show();
            this.Hide();

        }
    }
}
