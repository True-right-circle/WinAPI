using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace Faker
{
    public partial class mainmenu : Form
    {
        WindowsMediaPlayer mainBGM = new WindowsMediaPlayer();

        
        public mainmenu()
        {
            
            InitializeComponent();

            mainBGM.URL = "maintheme.mp3";

            mainBGM.settings.setMode("loop", true);

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            picShow = new PictureBox();
            picShow.BorderStyle = BorderStyle.Fixed3D;
            picShow.BackColor = Color.Yellow;
            picShow.SizeMode = PictureBoxSizeMode.Zoom;
            bgimg = Properties.Resources.mainimage;
            startimg = Properties.Resources.start_button;
            exitimg = Properties.Resources.exit_button;

            Size = new Size(800, 600);


            PictureBox start_buttonImg = new PictureBox();          
            start_buttonImg.Location = new Point(300, 260); 
            start_buttonImg.Image = new Bitmap(startimg); 
            start_buttonImg.Height = 67; 
            start_buttonImg.Width = 230; 
            this.Controls.Add(start_buttonImg); //이 클래스에 PictureBox 추가하기 
            start_buttonImg.MouseClick += new MouseEventHandler(start_Click); //PictureBox에 클릭이벤트 추가 

            PictureBox exit_buttonImg = new PictureBox();         
            exit_buttonImg.Location = new Point(300, 350);
            exit_buttonImg.Image = new Bitmap(exitimg);
            exit_buttonImg.Height = 67; 
            exit_buttonImg.Width = 230;
            this.Controls.Add(exit_buttonImg);
            exit_buttonImg.MouseClick += new MouseEventHandler(exit_Click);



        }

        Image bgimg, startimg, exitimg;



        public void start_Click(object sender, MouseEventArgs e)
        {
            this.Opacity = 0;
            LoadingForm OpenLoadingForm = new LoadingForm();
            Game OpenGameForm = new Game();
            OpenLoadingForm.ShowDialog();
            OpenGameForm.ShowDialog();
            
        }

        public void exit_Click(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

       

        private Bitmap MyImage;
        private PictureBox picShow;

        public void _insertPic(String FileToDisPlay, int xSize, int ySize)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(FileToDisPlay);
            picShow.ClientSize = new Size(xSize, ySize);
            picShow.Image = (Image)MyImage;
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;
            e.Graphics.DrawImage(bgimg, ClientRectangle);
        }

      
        private void mainmenu_Load(object sender, EventArgs e)
        {
            
            mainBGM.controls.play();
        }
    }
}



