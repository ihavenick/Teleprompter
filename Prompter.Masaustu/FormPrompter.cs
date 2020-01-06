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
    public partial class FormPrompter : Form
    {
        PrompterAyar _prompterAyar;
        Font YazininFontu;
        public FormPrompter(PrompterAyar prompterAyar)
        {
            _prompterAyar = prompterAyar;
            InitializeComponent();
            YazininFontu = new Font(FontFamily.GenericSansSerif, _prompterAyar.yaziBoyut, FontStyle.Bold);
        }

        private void FormPrompter_Load(object sender, EventArgs e)
        {
            labelYazi.Font = YazininFontu;
            var t = new System.Threading.Thread(AnaLoop);
            t.Start();
            labelYazi.Location = new Point(labelYazi.Location.X, this.ClientSize.Height);
            this.Show();
            
        }

        public void AnaLoop()
        {
            while (_prompterAyar.uygulamaCalisiyormu)
            {
                MethodInvoker mi = delegate ()
                {
                    
                    if (_prompterAyar.ArkaPlanRengiKoyumu)
                    {
                        this.BackColor = Color.Black;
                        labelYazi.ForeColor = Color.White;
                        labelYazi.BackColor = System.Drawing.Color.Transparent;
                        labelYazi.FlatStyle =  FlatStyle.Flat;
                    }
                    else
                    {
                        this.BackColor = Color.White;
                        labelYazi.ForeColor = Color.Black;
                        labelYazi.FlatStyle = FlatStyle.Flat;
                        labelYazi.BackColor = System.Drawing.Color.Transparent;
                    }


                    if (_prompterAyar.otomatikAcikmi)
                    {
                        timerPrompter.Enabled = true;
                        timerPrompter.Start();

                    }
                    else
                    {
                        timerPrompter.Stop();
                    }

                    labelYazi.Font.Dispose();
                    labelYazi.Font = new Font(FontFamily.GenericSansSerif, _prompterAyar.yaziBoyut, FontStyle.Bold);

                    labelYazi.Text = _prompterAyar.prompterLabel;
                    btnUst.Height = _prompterAyar.barBoyuttu;
                    btnAlt.Height = _prompterAyar.barBoyuttu;
                    

                };
                try
                {
                    this.Invoke(mi);
                }
                catch (Exception)
                {

                }
                
            }
        }

        public void YukariKaydir()
        {
            labelYazi.Location = new Point(labelYazi.Location.X, labelYazi.Location.Y - _prompterAyar.KaymaHizi);
        }

        public void AsagiKaydir()
        {
            labelYazi.Location = new Point(labelYazi.Location.X, labelYazi.Location.Y + _prompterAyar.KaymaHizi);
        }


        public void Reset()
        {
            labelYazi.Location = new Point(labelYazi.Location.X, this.ClientSize.Height);
        }

        public void Yukari()
        {
            btnUst.Location =  new Point(btnUst.Location.X,btnUst.Location.Y + 1);
        }

        public void Asagi()
        {
            btnUst.Location = new Point(btnUst.Location.X, btnUst.Location.Y - 1);
        }

        public Bitmap EkranGoruntusu()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            panelAna.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

            return bmp;
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.ScaleTransform(-1, 1);
        //    base.OnPaint(e);

            

        //    string text = "This will come out backwards";

           
        //  // float w = e.Graphics.MeasureString(text, YazininFontu).Width;
        //   // e.Graphics.DrawString(text, YazininFontu, Brushes.Black, -w, 0);
        //}

        private void timerPrompter_Tick(object sender, EventArgs e)
        {
                YukariKaydir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
