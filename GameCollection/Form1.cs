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
            selectPanel.Height = buttonMobileGame.Height;
            selectPanel.Top = buttonHome.Top;
            selectPanel.BringToFront();
            ubisoftGifLogo1.BringToFront();
            selectPanel.BringToFront();

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
            selectPanel.Height = buttonHome.Height;
            selectPanel.Top = buttonHome.Top;
            selectPanel.BringToFront();
            ubisoftGifLogo1.BringToFront();
            selectPanel.BringToFront();
        }

        private void buttonPC_Click(object sender, EventArgs e)
        {
            selectPanel.Height = buttonPCGame.Height;
            selectPanel.Top = buttonPCGame.Top;
            selectPanel.BringToFront();
            pcGameUC1.BringToFront();
            selectPanel.BringToFront();
        }

        private void buttonMobile_Click(object sender, EventArgs e)
        {
            selectPanel.Height = buttonMobileGame.Height;
            selectPanel.Top = buttonMobileGame.Top;
        }

        private void buttonXBox_Click(object sender, EventArgs e)
        {
            selectPanel.Height = buttonXboxGame.Height;
            selectPanel.Top = buttonXboxGame.Top;
        }

        private void buttonPS4_Click(object sender, EventArgs e)
        {
            selectPanel.Height = buttonPS4Game.Height;
            selectPanel.Top = buttonPS4Game.Top;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
