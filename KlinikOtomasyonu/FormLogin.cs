using KlinikOtomasyonu.DAL;
using System;
using System.Windows.Forms;

namespace KlinikOtomasyonu
{
    public partial class FormLogin : Form
    {
        SQLLib sql = new SQLLib();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;
            string kontrol = sql.SQLSelectValue("SELECT COUNT(*) FROM TBL_KULLANICI WHERE KULLANICI_KODU='" + kullaniciAdi + "' AND SIFRE ='" + sifre + "'");
            int parsedKontrol = 0;
            _ = int.TryParse(kontrol, out parsedKontrol);
            if (parsedKontrol>0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                DialogResult res =  MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
                if (res==DialogResult.OK)
                {
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
