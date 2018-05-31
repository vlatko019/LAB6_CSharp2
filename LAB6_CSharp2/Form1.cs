using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6_CSharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Snimi_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.StreamWriter Save = new System.IO.StreamWriter(saveFileDialog1.FileName);

                foreach (var item in Lista.Items)
                {
                    Save.WriteLine(item);
                }
                
                Save.Close();
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Proizvod P = new Proizvod();
            P.SetNaziv(Naziv.Text);
            P.SetBP(BP.Value);
            P.SetBPUP(PUP.Value);
            if (radioButton1.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.Narucen);
            } else if (radioButton2.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.USkladistu);
            } else if (radioButton3.Checked)
            {
                P.SetStatus(Proizvod.StatusProizvoda.UProdaji);
            }
            Lista.Items.Add(P.Get());
        }
    }
}
