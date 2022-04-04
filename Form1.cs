using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void BtnKonversi_Click(object sender, EventArgs e)
        {
            int selisih = 0;
            LblHasilKonversi.Text = "";
            if (TBoxInput.Text.Length > 0)
                selisih = Convert.ToInt16(Char.ToUpper(TBoxHurufAkhir.Text[0]) - Char.ToUpper(TBoxHurufAwal.Text[0]));
            
            for (int i = 0; i < TBoxInput.Text.Length; i++)
            {
                if(TBoxInput.Text[i] == ' ')
                {
                    LblHasilKonversi.Text += " ";
                }
                else if(Char.ToUpper(TBoxInput.Text[i]) + selisih < 65)
                {
                    LblHasilKonversi.Text += Convert.ToChar(Char.ToUpper(TBoxInput.Text[i]) + 26 + selisih);
                }
                else if(Char.ToUpper(TBoxInput.Text[i]) + selisih > 90)
                {
                    LblHasilKonversi.Text += Convert.ToChar(Char.ToUpper(TBoxInput.Text[i]) - 26 + selisih);
                }
                else
                {
                    LblHasilKonversi.Text += Convert.ToChar(Char.ToUpper(TBoxInput.Text[i]) + selisih);
                }
            }

            TBoxInput.Clear();
            TBoxHurufAwal.Clear();
            TBoxHurufAkhir.Clear();
            TBoxInput.Focus();
        }
    }
}
