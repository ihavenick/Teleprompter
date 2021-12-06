using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Prompter.Masaustu
{
    public partial class FormPrompter : Form
    {
        private readonly PrompterAyar _prompterAyar;
        private readonly Font YazininFontu;

        public FormPrompter(PrompterAyar prompterAyar)
        {
            _prompterAyar = prompterAyar;
            InitializeComponent();
            YazininFontu = new Font(FontFamily.GenericSansSerif, _prompterAyar.yaziBoyut, FontStyle.Bold);
        }

        private void FormPrompter_Load(object sender, EventArgs e)
        {
            labelYazi.Font = YazininFontu;
            var t = new Thread(AnaLoop);
            t.Start();
            labelYazi.Location = new Point(labelYazi.Location.X, ClientSize.Height);
            Show();
        }

        public void AnaLoop()
        {
            while (_prompterAyar.uygulamaCalisiyormu)
            {
                MethodInvoker mi = delegate
                {
                    if (_prompterAyar.ArkaPlanRengiKoyumu)
                    {
                        BackColor = Color.Black;
                        labelYazi.ForeColor = Color.White;
                        labelYazi.BackColor = Color.Transparent;
                        labelYazi.FlatStyle = FlatStyle.Flat;
                    }
                    else
                    {
                        BackColor = Color.White;
                        labelYazi.ForeColor = Color.Black;
                        labelYazi.FlatStyle = FlatStyle.Flat;
                        labelYazi.BackColor = Color.Transparent;
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
                    Invoke(mi);
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
            labelYazi.Location = new Point(labelYazi.Location.X, ClientSize.Height);
        }

        public void Yukari()
        {
            btnUst.Location = new Point(btnUst.Location.X, btnUst.Location.Y + 1);
        }

        public void Asagi()
        {
            btnUst.Location = new Point(btnUst.Location.X, btnUst.Location.Y - 1);
        }

        public Bitmap EkranGoruntusu()
        {
            var bmp = new Bitmap(Width, Height);
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