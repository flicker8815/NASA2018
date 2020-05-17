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
    public partial class FormHTP : Form
    {
        public string language = "";
        public FormHTP(string Lang)
        {
            language = Lang;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHTP_Load(object sender, EventArgs e)
        {
            switch (language)
            {
                case "en":
                    HTPLable.Text = "How to play";
                    label1.Text = "First you have to choose the piece \nthat you want to change positions\n\nThe selected piece will exchange \npositions with the piece counterclockwise to it\n\nRepeat until you've solved the \npuzzle";
                    break;
                case "zh":
                    HTPLable.Text = "如何操作";
                    label1.Text = "第一步你需要去用滑鼠選定你想要\n換位置的圖片\n\n你選定的那個拼圖會逆時針的移動\n\n繼續重複同樣地步驟直到你完成這\n個拼圖";
                    break;
                case "es":
                    HTPLable.Text = "Como jugar";
                    label1.Text = "Primero tendrás que elegir la pieza \nque quieras cambiar de posición\n\nLa pieza seleccionada intercambiara \nposiciones con la pieza en sentido contrarreloj\n\nRepita hasta que hayas resuelto el \nrompecabezas";
                    break;
            }
        }
    }
}
