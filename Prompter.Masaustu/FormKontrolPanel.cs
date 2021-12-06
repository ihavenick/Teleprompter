using System;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    public partial class FormKontrolPanel : Form
    {
        private readonly FormPrompter _gelenForm;
        private readonly PrompterAyar _prompterAyar;

        public FormKontrolPanel(PrompterAyar prompterAyar, FormPrompter gelenform)
        {
            _prompterAyar = prompterAyar;
            _gelenForm = gelenform;
            InitializeComponent();
            MouseWheel += FormKontrolPanel_MouseWheel;
            richTextBox1.MouseWheel += FormKontrolPanel_MouseWheel;
        }

        private void FormKontrolPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            var numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            if (numberOfTextLinesToMove < 0)
            {
                if (_prompterAyar.KaymaHizi < 30) _prompterAyar.KaymaHizi++;
            }
            else if (numberOfTextLinesToMove > 0)
            {
                if (_prompterAyar.KaymaHizi > 1) _prompterAyar.KaymaHizi--;
            }

            nHız.Value = _prompterAyar.KaymaHizi;
        }

        private void FormKontrolPanel_Load(object sender, EventArgs e)
        {
            _gelenForm.Show();
            _gelenForm.Hide();
        }


        public void OburEkraniKopyala()
        {
            try
            {
                var bmp = _gelenForm.EkranGoruntusu();

                pbImage.Image = bmp;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
            }
        }

        private void cbArkaPlan_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                _prompterAyar.ArkaPlanRengiKoyumu = true;
            else
                _prompterAyar.ArkaPlanRengiKoyumu = false;
        }

        private void FormKontrolPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            _prompterAyar.uygulamaCalisiyormu = false;
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var sayi = sender as NumericUpDown;
            _prompterAyar.yaziBoyut = Convert.ToSingle(sayi.Value);
        }

        private void cbOtomatik_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                _prompterAyar.otomatikAcikmi = true;
            else
                _prompterAyar.otomatikAcikmi = false;
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            _gelenForm.YukariKaydir();
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            _gelenForm.AsagiKaydir();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as RichTextBox;
            _prompterAyar.prompterLabel = textbox.Text;
        }

        private void timerEkran_Tick(object sender, EventArgs e)
        {
            OburEkraniKopyala();
        }

        private void nHız_ValueChanged(object sender, EventArgs e)
        {
            var sayi = sender as NumericUpDown;
            _prompterAyar.KaymaHizi = Convert.ToInt32(sayi.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _gelenForm.Reset();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            _gelenForm.Asagi();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            _gelenForm.Yukari();
        }
    }
}