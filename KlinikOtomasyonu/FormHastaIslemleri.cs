using KlinikOtomasyonu.DAL;
using System.Linq;
using System.Windows.Forms;

namespace KlinikOtomasyonu
{
    public partial class FormHastaIslemleri : Form
    {
        SQLLib sql = new SQLLib();
        public FormHastaIslemleri()
        {
            InitializeComponent();
        }

        private void FormHastaIslemleri_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'sOHATSDataSet.TBL_HASTAISLEM' table. You can move, or remove it, as needed.
            this.tBL_HASTAISLEMTableAdapter.Fill(this.sOHATSDataSet.TBL_HASTAISLEM);
        }

        private void btnDosynaNobul_Click(object sender, System.EventArgs e)
        {
            string dosyaNo = textBoxDosyaNo.Text;
            TBL_HASTA hasta = sql.DataTableToList<TBL_HASTA>(sql.SQLDataTable("SELECT * FROM TBL_HASTA  WHERE DOSYA_NO='" + dosyaNo + "' ")).FirstOrDefault();
            if (hasta!=null)
            {
                textBoxHastaAdi.Text = hasta.HASTA_ADI;
                textBoxHastaSoyadi.Text = hasta.HASTA_SOYADI;
                dateTimePickerSevkTarihi.Value= hasta.HASTA_SEVKTARIHI.Value;
            }

        }
    }
}
