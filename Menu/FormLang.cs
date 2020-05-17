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
    public partial class FormLang : Form
    {
        public FormLang()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZhButton_Click(object sender, EventArgs e)
        {
            String Lang = "zh";
            Form1 f1 = new Form1();
            f1.ChangeLanguage(Lang);
            ChangeLanguage(Lang);
            
        }
        private void ChangeLanguage(String Lang)
        {
            
        }
    }
}
