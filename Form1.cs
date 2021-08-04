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

        public Utilite()
        {
            InitializeComponent();
            random = new Random();
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
    }
}
