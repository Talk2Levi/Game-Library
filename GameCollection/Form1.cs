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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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

        // Button Hovered
        private void button_MouseHover(object sender, EventArgs e)
        {
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        } 
        
        // Button Left
        private void button_MouseLeave(object sender, EventArgs e)
        {
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
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

        private void pcGameUC1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_MouseHover(object sender, EventArgs e)
        {
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::GameCollection.Properties.Resources.home_black;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonHome.Image = global::GameCollection.Properties.Resources.home;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonPCGame_MouseHover(object sender, EventArgs e)
        {
            this.buttonPCGame.ForeColor = System.Drawing.Color.Black;
            this.buttonPCGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPCGame.Image = global::GameCollection.Properties.Resources.computer_screen_black;
            this.buttonPCGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonPCGame_MouseLeave(object sender, EventArgs e)
        {
            this.buttonPCGame.ForeColor = System.Drawing.Color.White;
            this.buttonPCGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPCGame.Image = global::GameCollection.Properties.Resources.pc;
            this.buttonPCGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonMobileGame_MouseHover(object sender, EventArgs e)
        {
            this.buttonMobileGame.ForeColor = System.Drawing.Color.Black;
            this.buttonMobileGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMobileGame.Image = global::GameCollection.Properties.Resources.smartphone_call_black;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonMobileGame_MouseLeave(object sender, EventArgs e)
        {
            this.buttonMobileGame.ForeColor = System.Drawing.Color.White;
            this.buttonMobileGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonMobileGame.Image = global::GameCollection.Properties.Resources.smartphone_call;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonXboxGame_MouseHover(object sender, EventArgs e)
        {
            this.buttonXboxGame.ForeColor = System.Drawing.Color.Black;
            this.buttonXboxGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonXboxGame.Image = global::GameCollection.Properties.Resources.xbox_black;
            this.buttonXboxGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonXboxGame_MouseLeave(object sender, EventArgs e)
        {
            this.buttonXboxGame.ForeColor = System.Drawing.Color.White;
            this.buttonXboxGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonXboxGame.Image = global::GameCollection.Properties.Resources.xbox;
            this.buttonXboxGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonPS4Game_MouseHover(object sender, EventArgs e)
        {
            this.buttonPS4Game.ForeColor = System.Drawing.Color.Black;
            this.buttonPS4Game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPS4Game.Image = global::GameCollection.Properties.Resources.ps4_black;
            this.buttonPS4Game.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonPS4Game_MouseLeave(object sender, EventArgs e)
        {
            this.buttonPS4Game.ForeColor = System.Drawing.Color.White;
            this.buttonPS4Game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPS4Game.Image = global::GameCollection.Properties.Resources.ps4;
            this.buttonPS4Game.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonSwitchGame_MouseHover(object sender, EventArgs e)
        {
            this.buttonSwitchGame.ForeColor = System.Drawing.Color.Black;
            this.buttonSwitchGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSwitchGame.Image = global::GameCollection.Properties.Resources.nintendo_switch_black;
            this.buttonSwitchGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void buttonSwitchGame_MouseLeave(object sender, EventArgs e)
        {
            this.buttonSwitchGame.ForeColor = System.Drawing.Color.White;
            this.buttonSwitchGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonSwitchGame.Image = global::GameCollection.Properties.Resources.nintendo_switch;
            this.buttonSwitchGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
    }
}
