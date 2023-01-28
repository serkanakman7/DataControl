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
    public partial class frmAdded : Form
    {
        public frmAdded()
        {
            InitializeComponent();
        }

        cTablo ct = new cTablo();

        private void LoadControl()
        {
            dqwAdTablo.DataSource = ct.PublicTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void frmAdded_Load(object sender, EventArgs e)
        {
            cGuncel cg = new cGuncel();
            cTablo ct = new cTablo();

            
            cg.VeriGetir(cg);

            if (cg.Id == 1)
            {

                txtId.Text = cg.PersonelId.ToString();
                txtName.Text = cg.Name;
                txtSurName.Text = cg.SurName;

                LoadControl();

                dqwAdTablo.Rows[0].Selected = false;
                dqwAdTablo.Rows[cg.PersonelId - 1].Selected = true;
            }
            else
            {
                LoadControl();
            }

            if ((txtName.Text)!="")
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnUpdate.Visible = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cPersonelBilgileri pb = new cPersonelBilgileri();
            cTablo ct = new cTablo();
            pb.Name = txtName.Text;
            pb.SurName = txtSurName.Text;

            ct.Add(pb);

            LoadControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cPersonelBilgileri pb = new cPersonelBilgileri();
            cTablo ct = new cTablo();

            pb.Name = txtName.Text;
            pb.SurName = txtSurName.Text;

            ct.Update(pb, Convert.ToInt32(txtId.Text));

            LoadControl();
        }

        private void dqwAdTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dqwAdTablo.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dqwAdTablo.CurrentRow.Cells[1].Value.ToString();
            txtSurName.Text = dqwAdTablo.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
