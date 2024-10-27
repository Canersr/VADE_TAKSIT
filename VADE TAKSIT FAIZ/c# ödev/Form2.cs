using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__ödev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Int32 i;
        private void Form2_Load(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
           // MessageBox.Show(Form1.tarih.ToString());


            for (int i = 1; i <= Form1.taksitsayisi; i++)
            {
                DateTime taksittarihi = Form1.tarih.AddMonths(i); //taksit tarihinin aylara göre şimdiden başlayıp seçilen aya kadar olan seçimini almak için kullandık

                switch (taksittarihi.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        taksittarihi = taksittarihi.AddDays(-1);
                        break;
                    case DayOfWeek.Sunday:
                        taksittarihi = taksittarihi.AddDays(-2);
                        break;
                }
                listBox1.Items.Add(taksittarihi.ToLongDateString() + "\t-->" + Form1.tutar.ToString("C2"));
                label1.Text = "Toplamda " + listBox1.Items.Count + " ay taksitlendirilmiştir.";
            }

            label1.Text = "Toplamda " + listBox1.Items.Count + " ay taksitlendirilmiştir.";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.kontrol = true;

          
            
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                form1.ResetDateTimePicker();
            }

        
    }
}
