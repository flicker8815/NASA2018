using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.Resources;

namespace Menu
{
    public partial class Form1 : Form
    {
        public string language = "en";
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Puzzle fp = new Puzzle(language);
            fp.ShowDialog();
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            FormHTP fhtp = new FormHTP(language);
            fhtp.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

            FormAbout fa = new FormAbout(language);
            fa.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideButtons();
           /* WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"C:\Users\Daniel\source\repos\Menu\ThroughTheSpace.mp3";
            wplayer.controls.play();*/
        }

        public void ChangeLanguage(string Lang)
        {
            if (Lang == "zh")
            {
            }
        }
        public void HideButtons()
        {
            PlayButton.Visible = false;
            AboutButton.Visible = false;
            ExitButton.Visible = false;
            TutorialButton.Visible = false;
            label1.Visible = false;
        }

        private void zhButton_Click(object sender, EventArgs e)
        {
            language = "zh";
            PlayButton.Text = "遊玩";
            AboutButton.Text = "關於";
            TutorialButton.Text = "如何操作";
            ExitButton.Text = "離開";
            PlayButton.Visible = true;
            AboutButton.Visible = true;
            ExitButton.Visible = true;
            TutorialButton.Visible = true;
            label1.Visible = true;
            zhButton.Visible = false;
            enButton.Visible = false;
            esButton.Visible = false;
        }

        private void enButton_Click(object sender, EventArgs e)
        {
            PlayButton.Visible = true;
            AboutButton.Visible = true;
            ExitButton.Visible = true;
            TutorialButton.Visible = true;
            label1.Visible = true;
            zhButton.Visible = false;
            enButton.Visible = false;
            esButton.Visible = false;
        }

        private void esButton_Click(object sender, EventArgs e)
        {
            language = "es";
            PlayButton.Text = "Jugar";
            AboutButton.Text = "Info";
            TutorialButton.Text = "Como jugar";
            ExitButton.Text = "Salir";
            PlayButton.Visible = true;
            AboutButton.Visible = true;
            ExitButton.Visible = true;
            TutorialButton.Visible = true;
            label1.Visible = true;
            zhButton.Visible = false;
            enButton.Visible = false;
            esButton.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
