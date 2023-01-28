using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ozkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cTablo ct = new cTablo();

        private void LoadControl()
        {
            dqwTablo.DataSource = ct.PublicTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cGuncel cg = new cGuncel();
            cg.Temizle();
            LoadControl();


        }

        private void btnVeriGiris_Click(object sender, EventArgs e)
        {
            frmAdded frm = new frmAdded();
            this.Hide();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dqwTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAdded frm = new frmAdded();
            cGuncel cg = new cGuncel();

            cg.PersonelId = Convert.ToInt32(dqwTablo.CurrentRow.Cells[0].Value);
            cg.Name = dqwTablo.CurrentRow.Cells[1].Value.ToString();
            cg.SurName = dqwTablo.CurrentRow.Cells[2].Value.ToString();
            cg.GTEkle(cg);

            this.Hide();
            frm.Show();

        }
    }
}
