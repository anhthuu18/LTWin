using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_MDI
{
    public partial class FormCon : Form
    {
        public FormCon()
        {
            InitializeComponent();
        }
        public FormCon(string fileName)
        {
            InitializeComponent();
            // Hien thi anh tu file 
            picBox.Image = Image.FromFile(fileName);
        }

    }
}
