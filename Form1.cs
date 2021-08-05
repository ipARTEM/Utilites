using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilites
{
    public partial class Utilite : Form
    {
        int count = 0;

        Random random;

        char[] specChars = new char[] { '@', '<', '>', '?', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '~' };

        Dictionary<string, double> metrica;

        public Utilite()
        {
            InitializeComponent();
            random = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1_000);
            metrica.Add("km", 1_000_000);
            metrica.Add("mile", 1609344);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты,\n содержит ряд небольших программ,\n которые могут пригодиться.", "О программе");

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            count++;
            labelCounter.Text = count.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            count--;
            labelCounter.Text = count.ToString();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            count=0;
            labelCounter.Text = count.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int num;
            num = random.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));

            labelRandom.Text=num.ToString();

            if(CBRandom.Checked)
            if (TBRandom.Text.IndexOf(num.ToString())==-1)
                TBRandom.AppendText(num.ToString() + Environment.NewLine);

        }

        private void BRandomCler_Click(object sender, EventArgs e)
        {
            TBRandom.Clear();

        }

        private void BRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TBRandom.Text);
        }

        private void TSMIInserDate_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortDateString()+Environment.NewLine);
        }

        private void TSMIInserTime_Click(object sender, EventArgs e)
        {
            RTBNotepad.AppendText(DateTime.Now.ToShortTimeString() + Environment.NewLine);
        }

        private void TSMISave_Click(object sender, EventArgs e)
        {
            try
            {
                RTBNotepad.SaveFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при сохранинии");
            }

            

        }

        void LoadNotepad()
        {
            try
            {
                RTBNotepad.LoadFile("notepad.rtf");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке");
            }
        }

        private void TSMIDownload_Click(object sender, EventArgs e)
        {
            LoadNotepad();
            

            
        }

        private void BCreatePassword_Click(object sender, EventArgs e)
        {
            if (CLBPass.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < NUDPassLeng.Value; i++)
            {
                int n = random.Next(0, CLBPass.CheckedItems.Count);
                string s = CLBPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += random.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(random.Next(65, 88)); 
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(random.Next(97, 122));
                        break;
                    default:
                        password +=specChars[random.Next(specChars.Length)];
                        break;
                }
                TBPassword.Text = password;

            }
        }

        private void NUDPassLeng_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[CBFrom.Text];
            double m2 = metrica[CBTo.Text];
            double n = Convert.ToDouble(TBFrom.Text);
            TBTo.Text = (n * m1 / m2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = CBFrom.Text;
            CBFrom.Text = CBTo.Text;
            CBTo.Text = t;

        }

        private void CBMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBMetric.Text)
            {
                case "Длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1_000);
                    metrica.Add("km", 1_000_000);
                    metrica.Add("mile", 1609344);

                    CBFrom.Items.Clear();
                    CBFrom.Items.Add("mm");
                    CBFrom.Items.Add("cm");
                    CBFrom.Items.Add("dm");
                    CBFrom.Items.Add("m");
                    CBFrom.Items.Add("km");
                    CBFrom.Items.Add("mile");

                    CBTo.Items.Clear();
                    CBTo.Items.Add("mm");
                    CBTo.Items.Add("cm");
                    CBTo.Items.Add("dm");
                    CBTo.Items.Add("m");
                    CBTo.Items.Add("km");
                    CBTo.Items.Add("mile");

                    CBFrom.Text = "mm";
                    CBTo.Text = "mm";

                    break;

                case "Вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1_000);
                    metrica.Add("t", 1_000_000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    

                    CBFrom.Items.Clear();
                    CBFrom.Items.Add("g");
                    CBFrom.Items.Add("kg");
                    CBFrom.Items.Add("t");
                    CBFrom.Items.Add("lb");
                    CBFrom.Items.Add("oz");

                    CBTo.Items.Clear();
                    CBTo.Items.Add("g");
                    CBTo.Items.Add("kg");
                    CBTo.Items.Add("t");
                    CBTo.Items.Add("lb");
                    CBTo.Items.Add("oz");
                  

                    CBFrom.Text = "g";
                    CBTo.Text = "g";

                    break;

                default:
                    break;
            }
        }
    }
}
