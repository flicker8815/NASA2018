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
    public partial class FormAbout : Form
    {
        public string language = "";
        public FormAbout(string Lang)
        {
            language = Lang;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            switch(language)
            {
                case "zh":
                    label2.Text = "關於";
                    label1.Text = "Unpuzzle the universe 為四位國立宜蘭大學資工系\n大一學生所開發的拼圖遊戲\n數據來源是為NASA 提供的資源\n本程式以Ｃ＃為核心\n架構為.net Framework4.6.1的標準類別庫";
                    break;
                case "en":
                    label2.Text = "About";
                    label1.Text = "Unpuzzle the universe is a puzzle game design by four \nNational Yilan University Freshman\nData source: NASA\nThis program is based on C#\n.net Framework 4.6.1";
                    break;
                case "es":
                    label2.Text = "Info";
                    label1.Text = "Unpuzzle the Universe es un juego diseñado por cuatro \nestudiantes de la Universidad Nacional de Yilan\nFuente de datos: NASA\nEste programa está basado en C#\n.net Framework 4.6.1";
                    break;

            }
        }
    }
}
