using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace Faker
{
    public partial class LoadingForm : Form
    {
        WindowsMediaPlayer startBGM = new WindowsMediaPlayer();

        public LoadingForm()
        {

            startBGM.URL = "welcome.mp3";
            loadingimg = Properties.Resources.loading;
            InitializeComponent();
        }

        Image loadingimg;

        private void LoadingForm_Load(object sender, EventArgs e)
        {

            startBGM.controls.play();
            loadingtime.Start();

            loadingbox.Image = new Bitmap(loadingimg);

            loadingbox.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private string GetApplication()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection
                .Assembly.GetExecutingAssembly()
                .GetModules()[0].FullyQualifiedName);
        }

        private void loadingbox_Paint(object sender, PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;
            e.Graphics.DrawImage(loadingimg, ClientRectangle);
        }
        int n = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            if (n == 40)
                Close();

        }
    }
    

}
