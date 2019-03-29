using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BunifuTooltipDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///add cool drophadows to the form 
            (new Bunifu.Utils.DropShaddow()).ApplyShadows(this);

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            //invoke the tootip
            // Set a ToolTip for the added Bunifu Image Button.
            bunifuToolTip1.Show(bunifuImageButton3, "This is my first tooltip!");

        }
    }
}
