using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cekilis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADAYLAR_TextChanged(object sender, EventArgs e)
        {
            lblcekilissayi.Text = ADAYLAR.Lines.Count().ToString();

            if(ADAYLAR.Lines.Count()>0)
            {
                nmiktar.Maximum=ADAYLAR.Lines.Count()-1;
            }
            else
            {
                nmiktar.Minimum = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtglist.ColumnCount = 2;
            dtglist.Columns[0].Name = "Sıra No";
            dtglist.Columns[1].Name = "Ad Soyad";
        }
        int _cekilisSay = 1;
        private void cekilisibaslat_Click(object sender, EventArgs e)
        {
            
            int cekilisSayisi = Convert.ToInt32(nmiktar.Text);
            List<string> ListAdaylar = new List<string>(ADAYLAR.Text.Split('\n'));

            if (ADAYLAR.Text=="")
            {
                MessageBox.Show("Adayları girmelisiniz");
            }
            else 
            { 
             Random uret=new Random();
            for (int i = 0; i<cekilisSayisi; i++)
                {
                   int kazananAday= uret.Next(0,ListAdaylar.Count);
                    dtglist.Rows.Add(_cekilisSay++, ListAdaylar[kazananAday]);
                    ListAdaylar.Remove(ListAdaylar[kazananAday]);
                }
            
            }
        }

        private void yenicekilis_Click(object sender, EventArgs e)
        {
            ADAYLAR.Clear();
            dtglist.Rows.Clear();
            _cekilisSay = 1;
            nmiktar.Value = 1;
        }

        private void nmiktar_ValueChanged(object sender, EventArgs e)
        {
            nmiktar.Maximum = ADAYLAR.Lines.Count();
        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
