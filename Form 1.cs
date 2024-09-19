using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        private double sonuc = 0;
        private string islem = string.Empty;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add: // "+" tuşu
                case Keys.Oemplus: // "=" tuşu, bazı klavyelerde bu işarete basınca "+" olur
                    buttonAdd_Click(sender, e);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Subtract: // "-" tuşu
                case Keys.OemMinus: // "-" tuşu
                    buttonSubstract_Click(sender, e);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Multiply: // "*" tuşu
                    buttonMultiply_Click(sender, e);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Divide: // "/" tuşu
                case Keys.OemQuestion: // "/" tuşu
                    buttonDivide_Click(sender, e);
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Enter: // "Enter" tuşu
                    buttonEquals_Click(sender, e);
                    break;
                case Keys.C: // "Escape" tuşu
                    buttonClear_Click(sender, e);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double sayi))
            {
                sonuc += sayi;
                labelResult.Text = $"Sonuç: {sonuc}";
                textBoxInput.Clear();
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double sayi))
            {
                sonuc -= sayi;
                labelResult.Text = $"Sonuç: {sonuc}";
                textBoxInput.Clear();
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double sayi))
            {
                sonuc *= sayi;
                labelResult.Text = $"Sonuç: {sonuc}";
                textBoxInput.Clear();
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double sayi))
            {
                if (sayi != 0)
                {
                    sonuc /= sayi;
                    labelResult.Text = $"Sonuç: {sonuc}";
                }
                else
                {
                    labelResult.Text = "Hata: Bir sayı sıfıra bölünemez.";
                }
                textBoxInput.Clear();
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"Sonuç: {sonuc}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            sonuc = 0;
            islem = string.Empty;
            textBoxInput.Clear();
            labelResult.Text = "Sonuç: 0";
        }
    }
}
