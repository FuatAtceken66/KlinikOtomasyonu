using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikOtomasyonu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormLogin formLogin = new FormLogin();
            DialogResult status =  formLogin.ShowDialog();
            if (status == DialogResult.OK)
            {
                this.Enabled = true;

            }
        }

        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHastaIslemleri formHastaIslemleri = new FormHastaIslemleri();
            formHastaIslemleri.TopLevel = false;
            panel1.Controls.Add(formHastaIslemleri);
            formHastaIslemleri.Show();
        }
    }
}
