using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sideSelectPanel.Height = buttonMobileGame.Height;
            sideSelectPanel.Top = buttonHome.Top;
        }



        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Button Clicks
        private void buttonHome_Click(object sender, EventArgs e)
        {
            sideSelectPanel.Height = buttonHome.Height;
            sideSelectPanel.Top = buttonHome.Top;

        }

        private void buttonPC_Click(object sender, EventArgs e)
        {
            sideSelectPanel.Height = buttonPCGame.Height;
            sideSelectPanel.Top = buttonPCGame.Top;
        }

        private void buttonMobile_Click(object sender, EventArgs e)
        {
            sideSelectPanel.Height = buttonMobileGame.Height;
            sideSelectPanel.Top = buttonMobileGame.Top;
        }

        private void buttonXBox_Click(object sender, EventArgs e)
        {
            sideSelectPanel.Height = buttonXboxGame.Height;
            sideSelectPanel.Top = buttonXboxGame.Top;
        }

        private void buttonPS4_Click(object sender, EventArgs e)
        {
            sideSelectPanel.Height = buttonPS4Game.Height;
            sideSelectPanel.Top = buttonPS4Game.Top;
        }
    }
}
