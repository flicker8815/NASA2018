using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Puzzle : Form
    {
        public int Level = 0;
        public string language = "";
        public Puzzle(string Lang)
        {
            language = Lang;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox temP = new PictureBox();
            temP.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
            pictureBox3.BackgroundImage = temP.BackgroundImage;
            Check(Level);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox temP = new PictureBox();
            temP.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox2.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox1.BackgroundImage = temP.BackgroundImage;
            Check(Level);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox temP = new PictureBox();
            temP.BackgroundImage = pictureBox3.BackgroundImage;
            pictureBox3.BackgroundImage = pictureBox4.BackgroundImage;
            pictureBox4.BackgroundImage = temP.BackgroundImage;
            Check(Level);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox temP = new PictureBox();
            temP.BackgroundImage = pictureBox4.BackgroundImage;
            pictureBox4.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox2.BackgroundImage = temP.BackgroundImage;
            Check(Level);
        }
        private void Check(int L)
        {
            string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
            root = root.Remove(root.Length - 8);
            Bitmap ans1 = new Bitmap(@root + "Resources\\1.1.jpg", false);
            Bitmap ans2 = new Bitmap(@root + "Resources\\1.2.jpg", false);
            Bitmap ans3 = new Bitmap(@root + "Resources\\1.3.jpg", false);
            Bitmap ans4 = new Bitmap(@root + "Resources\\1.4.jpg", false);
            switch (L)
            {
                case 1:
                    break;
                case 2:
                    ans1 = new Bitmap(@root + "Resources\\2.1.jpg", false);
                    ans2 = new Bitmap(@root + "Resources\\2.2.jpg", false);
                    ans3 = new Bitmap(@root + "Resources\\2.3.jpg", false);
                    ans4 = new Bitmap(@root + "Resources\\2.4.jpg", false);
                    break;
                case 3:
                    ans1 = new Bitmap(@root + "Resources\\3.1.jpg", false);
                    ans2 = new Bitmap(@root + "Resources\\3.2.jpg", false);
                    ans3 = new Bitmap(@root + "Resources\\3.3.jpg", false);
                    ans4 = new Bitmap(@root + "Resources\\3.4.jpg", false);
                    break;
                case 4:
                    ans1 = new Bitmap(@root + "Resources\\4.1.jpg", false);
                    ans2 = new Bitmap(@root + "Resources\\4.2.jpg", false);
                    ans3 = new Bitmap(@root + "Resources\\4.3.jpg", false);
                    ans4 = new Bitmap(@root + "Resources\\4.4.jpg", false);
                    break;
            }
                

        
            Bitmap image1 = (Bitmap)pictureBox1.BackgroundImage;
            Bitmap image2 = (Bitmap)pictureBox2.BackgroundImage;
            Bitmap image3 = (Bitmap)pictureBox3.BackgroundImage;
            Bitmap image4 = (Bitmap)pictureBox4.BackgroundImage;

            bool flag = true;
            string i1;
            string i2;
            string i3;
            string i4;

            string a1;
            string a2;
            string a3;
            string a4;

            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    i1 = image1.GetPixel(i, j).ToString();
                    i2 = image2.GetPixel(i, j).ToString();
                    i3 = image3.GetPixel(i, j).ToString();
                    i4 = image4.GetPixel(i, j).ToString();

                    a1 = ans1.GetPixel(i, j).ToString();
                    a2 = ans2.GetPixel(i, j).ToString();
                    a3 = ans3.GetPixel(i, j).ToString();
                    a4 = ans4.GetPixel(i, j).ToString();

                    if (a1 != i1 || a2 != i2 || a3 != i3 || a4 != i4)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag == true)
            {
                winText.Visible = true;
                pictureBox5.Visible = true;
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            if (language == "en")
            {
                winText.Text = "Name: Lagoon Nebula \nDistance: 4000-6000 Light years \nAparent Magnitude: 6.0 \nConstellation: Sagittarius";
            }
            if (language == "zh")
            {
                winText.Text = "名字: Lagoon Nebula \n距離:4,000-6,000 光年 \n絕對星等:6.0 \n星座:  Sagittarius";
                ExitButton.Text = "返回";
            }
            if (language == "es")
            {
                winText.Text = "Nombre: Lagoon Nebula \nDistancia: 4000-6000 Light years \nMagnitud aparente: 6.0 \nConstellación: Sagittarius";
                ExitButton.Text = "Volver";
            }
            backPanel.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            winText.Visible = false;
            pictureBox5.Visible = false;
        }

        private void Play1_Click(object sender, EventArgs e)
        {
            Level = 1;
            backPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            Play1.Visible = false;
            Play2.Visible = false;
            Play3.Visible = false;
            Play4.Visible = false;
            ChangeLang(language);
        }

        private void Play2_Click(object sender, EventArgs e)
        {
            string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
            root = root.Remove(root.Length - 8);
            Level = 2;
            Bitmap img = new Bitmap(@root + "Resources\\2.1.jpg");
            pictureBox2.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\2.2.jpg");
            pictureBox3.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\2.3.jpg");
            pictureBox1.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\2.4.jpg");
            pictureBox4.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\2.jpg");
            pictureBox5.BackgroundImage = img;
            backPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            Play1.Visible = false;
            Play2.Visible = false;
            Play3.Visible = false;
            Play4.Visible = false;
            ChangeLang(language);
        }

        private void Play3_Click(object sender, EventArgs e)
        {
            string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
            root = root.Remove(root.Length - 8);
            Level = 3;
            Bitmap img = new Bitmap(@root + "Resources\\3.1.jpg");
            pictureBox4.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\3.2.jpg");
            pictureBox2.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\3.3.jpg");
            pictureBox1.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\3.4.jpg");
            pictureBox3.BackgroundImage = img;
            pictureBox1.Visible = true;
            img = new Bitmap(@root + "Resources\\3.jpg");
            pictureBox5.BackgroundImage = img;
            backPanel.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            Play1.Visible = false;
            Play2.Visible = false;
            Play3.Visible = false;
            Play4.Visible = false;
            ChangeLang(language);
        }

        private void Play4_Click(object sender, EventArgs e)
        {
            string root = System.Reflection.Assembly.GetExecutingAssembly().Location;
            root = root.Remove(root.Length - 8);
            Level = 4;
            Bitmap img = new Bitmap(@root + "Resources\\4.1.jpg");
            pictureBox3.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\4.2.jpg");
            pictureBox2.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\4.3.jpg");
            pictureBox4.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\4.4.jpg");
            pictureBox1.BackgroundImage = img;
            img = new Bitmap(@root + "Resources\\4.jpg");
            pictureBox5.BackgroundImage = img;
            backPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            Play1.Visible = false;
            Play2.Visible = false;
            Play3.Visible = false;
            Play4.Visible = false;
            ChangeLang(language);
        }
        private void ChangeLang(string L)
        {
            if (L == "en")
            {
                switch (Level)
                {
                    case 1:
                        break;
                    case 2:
                        winText.Text = "Name: NGC-6326 \nDistance: 11000 Light Years \nAparent Magnitude: 11.5 \nConstellation: Ursa Major";
                        break;
                    case 3:
                        winText.Text = "Name: NGC-3918 \nDistance: 4900 Light Years \nAparent Magnitude: 12.2 \nConstellation: Ara";
                        break;
                    case 4:
                        winText.Text = "Name: NGC-3079 \nDistance: 52 million Light Years \nAparent Magnitude: 8.5 \nConstellation: Centarus";
                        break;

                }
            }
            if (L == "zh")
            {
                switch (Level)
                {
                    case 1:
                        winText.Text = "名字:Lagoon nebula \n距離:4000-6000光年 \n絕對星等: 6.0 \n所在星座: Sagittarius";
                        break;
                    case 2:
                        winText.Text = "名字:NGC-6326 \n距離:11000光年 \n絕對星等: 11.5 \n所在星座: Ursa Major";
                        break;
                    case 3:
                        winText.Text = "名字:NGC-3918 \n距離: 4900光年 \n絕對星等: 12.2 \n所在星座: Ara";
                        break;
                    case 4:
                        winText.Text = "名字:NGC-3079 \n距離: 52 million光年 \n絕對星等: 8.5 \n所在星座: Centarus";
                        break;

                }
            }
            if (L == "es")
            {
                switch (Level)
                {
                    case 1:
                        winText.Text = "Nombre: Lagoon Nebula \nDistancia: 4000-6000 Años luz \nMagnitud Aparente: 6.0 \nConstelación: Sagittarius";
                        break;
                    case 2:
                        winText.Text = "Nombre: NGC-6326 \nDistancia: 11000 Años luz \nMagnitud Aparente: 11.5 \nConstelación: Ursa Major";
                        break;
                    case 3:
                        winText.Text = "Nombre: NGC-3918 \nDistancia: 4900 Años luz \nMagnitud Aparente: 12.2 \nConstelación: Ara";
                        break;
                    case 4:
                        winText.Text = "Nombre: NGC-3079 \nDistancia: 52 millón años luz \nMagnitud Aparente: 8.5 \nConstelación: Centarus";
                        break;

                }
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

