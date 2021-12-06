using System;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    public partial class FormEkran : Form
    {
        private readonly FormPrompter formPrompter;

        public FormEkran(FormPrompter _formPrompter)
        {
            InitializeComponent();
            formPrompter = _formPrompter;
        }

        private void FormEkran_Load(object sender, EventArgs e)
        {
        }


        public void OburEkraniKopyala()
        {
            try
            {
                //Bitmap bmp = new Bitmap(formPrompter.Width, formPrompter.Height);
                //formPrompter.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                var bmp = formPrompter.EkranGoruntusu();

                //bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

                pbAna.Image = bmp;
                pbAna.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
            }
        }

        private void timerAna_Tick(object sender, EventArgs e)
        {
            OburEkraniKopyala();
        }

        private void FormEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}