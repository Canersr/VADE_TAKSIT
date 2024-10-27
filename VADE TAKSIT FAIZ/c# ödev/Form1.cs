namespace c__ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        public void ResetDateTimePicker() //datetimepicker sıfırlamak için kullanılır.
        {
            dateTimePicker1.Value = DateTime.Now;
        }


        public static double miktar, taksitsayisi, tutar;
       public static DateTime tarih;
        DialogResult soru;
        public static bool kontrol;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==-1) 
            {
                MessageBox.Show("Taksit seçiniz");
                return;
            }
            if (comboBox1.SelectedIndex == 0) { taksitsayisi = 2; }
            if (comboBox1.SelectedIndex == 1) { taksitsayisi = 3; }
            if (comboBox1.SelectedIndex == 2) { taksitsayisi = 4; }
            if (comboBox1.SelectedIndex == 3) { taksitsayisi = 5; }
            if (comboBox1.SelectedIndex == 4) { taksitsayisi = 6; }
            if (comboBox1.SelectedIndex == 5) { taksitsayisi = 7; }
            if (comboBox1.SelectedIndex == 6) { taksitsayisi = 8; }

            miktar = Convert.ToDouble(textBox1.Text);
            tutar = miktar / taksitsayisi;
            tutar = Math.Round(tutar, 2);

            //FAIZLER
            if (comboBox1.SelectedIndex == 0) { tutar = tutar * 1.02; }
            if (comboBox1.SelectedIndex == 1) { tutar = tutar * 1.03; }
            if (comboBox1.SelectedIndex == 2) { tutar = tutar * 1.04; }
            if (comboBox1.SelectedIndex == 3) { tutar = tutar * 1.05; }
            if (comboBox1.SelectedIndex == 4) { tutar = tutar * 1.06; }                   
            if (comboBox1.SelectedIndex == 5) { tutar = tutar * 1.07; }
            if (comboBox1.SelectedIndex == 6) { tutar = tutar * 1.08; }
            //MessageBox.Show(Convert.ToString(tutar));

            DateTime seleceddate = dateTimePicker1.Value;
            
           tarih = seleceddate;

            
           soru = MessageBox.Show(miktar.ToString("C2") + " tutarındaki ödeme " + taksitsayisi.ToString() + " ay vadeye ayrılsın mı?",
            "Ödeme Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru==DialogResult.Yes)
            {
                Form2 goster = new Form2();
                goster.ShowDialog();
            }
           
            if (kontrol = true)
            { textBox1.Clear(); 
                comboBox1.SelectedIndex = -1;
            }








        }


    }
}
