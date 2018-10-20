namespace GameCollection
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        #endregion

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonSwitchGame = new System.Windows.Forms.Button();
            this.selectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPS4Game = new System.Windows.Forms.Button();
            this.buttonXboxGame = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMobileGame = new System.Windows.Forms.Button();
            this.UbisoftLogo = new System.Windows.Forms.PictureBox();
            this.buttonPCGame = new System.Windows.Forms.Button();
            this.pcGameUC1 = new GameCollection.pcGameUC();
            this.ubisoftGifLogo1 = new GameCollection.ubisoftGifLogo();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UbisoftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Black;
            this.sidePanel.Controls.Add(this.buttonSwitchGame);
            this.sidePanel.Controls.Add(this.selectPanel);
            this.sidePanel.Controls.Add(this.buttonPS4Game);
            this.sidePanel.Controls.Add(this.buttonXboxGame);
            this.sidePanel.Controls.Add(this.buttonHome);
            this.sidePanel.Controls.Add(this.buttonMobileGame);
            this.sidePanel.Controls.Add(this.UbisoftLogo);
            this.sidePanel.Controls.Add(this.buttonPCGame);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(256, 852);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSwitchGame
            // 
            this.buttonSwitchGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSwitchGame.FlatAppearance.BorderSize = 0;
            this.buttonSwitchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitchGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSwitchGame.Image = global::GameCollection.Properties.Resources.nintendo_switch;
            this.buttonSwitchGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSwitchGame.Location = new System.Drawing.Point(24, 438);
            this.buttonSwitchGame.Name = "buttonSwitchGame";
            this.buttonSwitchGame.Size = new System.Drawing.Size(239, 72);
            this.buttonSwitchGame.TabIndex = 6;
            this.buttonSwitchGame.Text = "     Switch Game";
            this.buttonSwitchGame.UseVisualStyleBackColor = true;
            this.buttonSwitchGame.MouseLeave += new System.EventHandler(this.buttonSwitchGame_MouseLeave);
            this.buttonSwitchGame.MouseHover += new System.EventHandler(this.buttonSwitchGame_MouseHover);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.White;
            this.selectPanel.Location = new System.Drawing.Point(0, 48);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(18, 72);
            this.selectPanel.TabIndex = 2;
            // 
            // buttonPS4Game
            // 
            this.buttonPS4Game.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPS4Game.FlatAppearance.BorderSize = 0;
            this.buttonPS4Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPS4Game.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPS4Game.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPS4Game.Image = global::GameCollection.Properties.Resources.ps4;
            this.buttonPS4Game.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPS4Game.Location = new System.Drawing.Point(24, 360);
            this.buttonPS4Game.Name = "buttonPS4Game";
            this.buttonPS4Game.Size = new System.Drawing.Size(239, 72);
            this.buttonPS4Game.TabIndex = 5;
            this.buttonPS4Game.Text = "  PS4 Game";
            this.buttonPS4Game.UseVisualStyleBackColor = true;
            this.buttonPS4Game.Click += new System.EventHandler(this.buttonPS4_Click);
            this.buttonPS4Game.MouseLeave += new System.EventHandler(this.buttonPS4Game_MouseLeave);
            this.buttonPS4Game.MouseHover += new System.EventHandler(this.buttonPS4Game_MouseHover);
            // 
            // buttonXboxGame
            // 
            this.buttonXboxGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonXboxGame.FlatAppearance.BorderSize = 0;
            this.buttonXboxGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXboxGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXboxGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXboxGame.Image = global::GameCollection.Properties.Resources.xbox;
            this.buttonXboxGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXboxGame.Location = new System.Drawing.Point(24, 282);
            this.buttonXboxGame.Name = "buttonXboxGame";
            this.buttonXboxGame.Size = new System.Drawing.Size(239, 72);
            this.buttonXboxGame.TabIndex = 4;
            this.buttonXboxGame.Text = "   Xbox Game";
            this.buttonXboxGame.UseVisualStyleBackColor = true;
            this.buttonXboxGame.Click += new System.EventHandler(this.buttonXBox_Click);
            this.buttonXboxGame.MouseLeave += new System.EventHandler(this.buttonXboxGame_MouseLeave);
            this.buttonXboxGame.MouseHover += new System.EventHandler(this.buttonXboxGame_MouseHover);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(24, 48);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(236, 72);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "        Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseLeave += new System.EventHandler(this.buttonHome_MouseLeave);
            this.buttonHome.MouseHover += new System.EventHandler(this.buttonHome_MouseHover);
            // 
            // buttonMobileGame
            // 
            this.buttonMobileGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMobileGame.FlatAppearance.BorderSize = 0;
            this.buttonMobileGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMobileGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMobileGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMobileGame.Image = global::GameCollection.Properties.Resources.smartphone_call;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMobileGame.Location = new System.Drawing.Point(24, 204);
            this.buttonMobileGame.Name = "buttonMobileGame";
            this.buttonMobileGame.Size = new System.Drawing.Size(239, 72);
            this.buttonMobileGame.TabIndex = 3;
            this.buttonMobileGame.Text = "     Mobile Game";
            this.buttonMobileGame.UseVisualStyleBackColor = true;
            this.buttonMobileGame.Click += new System.EventHandler(this.buttonMobile_Click);
            this.buttonMobileGame.MouseLeave += new System.EventHandler(this.buttonMobileGame_MouseLeave);
            this.buttonMobileGame.MouseHover += new System.EventHandler(this.buttonMobileGame_MouseHover);
            // 
            // UbisoftLogo
            // 
            this.UbisoftLogo.Image = global::GameCollection.Properties.Resources.Ubisoft_Logo_trsparent;
            this.UbisoftLogo.Location = new System.Drawing.Point(46, 653);
            this.UbisoftLogo.Name = "UbisoftLogo";
            this.UbisoftLogo.Size = new System.Drawing.Size(154, 136);
            this.UbisoftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UbisoftLogo.TabIndex = 0;
            this.UbisoftLogo.TabStop = false;
            // 
            // buttonPCGame
            // 
            this.buttonPCGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPCGame.FlatAppearance.BorderSize = 0;
            this.buttonPCGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPCGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPCGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPCGame.Image = global::GameCollection.Properties.Resources.pc;
            this.buttonPCGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPCGame.Location = new System.Drawing.Point(24, 126);
            this.buttonPCGame.Name = "buttonPCGame";
            this.buttonPCGame.Size = new System.Drawing.Size(236, 72);
            this.buttonPCGame.TabIndex = 2;
            this.buttonPCGame.Text = "PC Game";
            this.buttonPCGame.UseVisualStyleBackColor = true;
            this.buttonPCGame.Click += new System.EventHandler(this.buttonPC_Click);
            this.buttonPCGame.MouseLeave += new System.EventHandler(this.buttonPCGame_MouseLeave);
            this.buttonPCGame.MouseHover += new System.EventHandler(this.buttonPCGame_MouseHover);
            // 
            // pcGameUC1
            // 
            this.pcGameUC1.BackColor = System.Drawing.Color.Transparent;
            this.pcGameUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcGameUC1.BackgroundImage")));
            this.pcGameUC1.Location = new System.Drawing.Point(252, 0);
            this.pcGameUC1.Name = "pcGameUC1";
            this.pcGameUC1.Size = new System.Drawing.Size(1080, 852);
            this.pcGameUC1.TabIndex = 2;
            // 
            // ubisoftGifLogo1
            // 
            this.ubisoftGifLogo1.Location = new System.Drawing.Point(252, 0);
            this.ubisoftGifLogo1.Name = "ubisoftGifLogo1";
            this.ubisoftGifLogo1.Size = new System.Drawing.Size(1106, 852);
            this.ubisoftGifLogo1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1332, 852);
            
            this.Controls.Add(this.pcGameUC1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.ubisoftGifLogo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UbisoftLogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button buttonPCGame;
        private System.Windows.Forms.Button buttonMobileGame;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPS4Game;
        private System.Windows.Forms.Button buttonXboxGame;
        private System.Windows.Forms.FlowLayoutPanel selectPanel;
        private System.Windows.Forms.PictureBox UbisoftLogo;
        private System.Windows.Forms.Button buttonSwitchGame;
        private ubisoftGifLogo ubisoftGifLogo1;
        private pcGameUC pcGameUC1;
    }
}

