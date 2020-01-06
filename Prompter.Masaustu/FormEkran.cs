using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    public partial class FormEkran : Form
    {
        FormPrompter formPrompter;
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

                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

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
