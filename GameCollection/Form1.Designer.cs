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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideSelectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPS4Game = new System.Windows.Forms.Button();
            this.buttonXboxGame = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMobileGame = new System.Windows.Forms.Button();
            this.UbisoftLogo = new System.Windows.Forms.PictureBox();
            this.buttonPCGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UbisoftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.sideSelectPanel);
            this.panel1.Controls.Add(this.buttonPS4Game);
            this.panel1.Controls.Add(this.buttonXboxGame);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonMobileGame);
            this.panel1.Controls.Add(this.UbisoftLogo);
            this.panel1.Controls.Add(this.buttonPCGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 853);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sideSelectPanel
            // 
            this.sideSelectPanel.BackColor = System.Drawing.Color.Gray;
            this.sideSelectPanel.Location = new System.Drawing.Point(0, 88);
            this.sideSelectPanel.Name = "sideSelectPanel";
            this.sideSelectPanel.Size = new System.Drawing.Size(18, 72);
            this.sideSelectPanel.TabIndex = 2;
            // 
            // buttonPS4Game
            // 
            this.buttonPS4Game.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPS4Game.FlatAppearance.BorderSize = 0;
            this.buttonPS4Game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPS4Game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPS4Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPS4Game.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPS4Game.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPS4Game.Image = global::GameCollection.Properties.Resources.ps4;
            this.buttonPS4Game.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPS4Game.Location = new System.Drawing.Point(24, 400);
            this.buttonPS4Game.Name = "buttonPS4Game";
            this.buttonPS4Game.Size = new System.Drawing.Size(239, 72);
            this.buttonPS4Game.TabIndex = 5;
            this.buttonPS4Game.Text = " PS4 Game";
            this.buttonPS4Game.UseVisualStyleBackColor = true;
            this.buttonPS4Game.Click += new System.EventHandler(this.buttonPS4_Click);
            // 
            // buttonXboxGame
            // 
            this.buttonXboxGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonXboxGame.FlatAppearance.BorderSize = 0;
            this.buttonXboxGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonXboxGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonXboxGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXboxGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXboxGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXboxGame.Image = global::GameCollection.Properties.Resources.xbox;
            this.buttonXboxGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXboxGame.Location = new System.Drawing.Point(24, 322);
            this.buttonXboxGame.Name = "buttonXboxGame";
            this.buttonXboxGame.Size = new System.Drawing.Size(239, 72);
            this.buttonXboxGame.TabIndex = 4;
            this.buttonXboxGame.Text = "  Xbox Game";
            this.buttonXboxGame.UseVisualStyleBackColor = true;
            this.buttonXboxGame.Click += new System.EventHandler(this.buttonXBox_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Image = global::GameCollection.Properties.Resources.home;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(24, 88);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(236, 72);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "        Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonMobileGame
            // 
            this.buttonMobileGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMobileGame.FlatAppearance.BorderSize = 0;
            this.buttonMobileGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonMobileGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMobileGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMobileGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMobileGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMobileGame.Image = global::GameCollection.Properties.Resources.smartphone_call;
            this.buttonMobileGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMobileGame.Location = new System.Drawing.Point(24, 244);
            this.buttonMobileGame.Name = "buttonMobileGame";
            this.buttonMobileGame.Size = new System.Drawing.Size(239, 72);
            this.buttonMobileGame.TabIndex = 3;
            this.buttonMobileGame.Text = "    Mobile Game";
            this.buttonMobileGame.UseVisualStyleBackColor = true;
            this.buttonMobileGame.Click += new System.EventHandler(this.buttonMobile_Click);
            // 
            // UbisoftLogo
            // 
            this.UbisoftLogo.Image = global::GameCollection.Properties.Resources.Ubisoft_Logo_trsparent;
            this.UbisoftLogo.Location = new System.Drawing.Point(39, 694);
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
            this.buttonPCGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPCGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPCGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPCGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPCGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPCGame.Image = global::GameCollection.Properties.Resources.pc;
            this.buttonPCGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPCGame.Location = new System.Drawing.Point(24, 166);
            this.buttonPCGame.Name = "buttonPCGame";
            this.buttonPCGame.Size = new System.Drawing.Size(236, 72);
            this.buttonPCGame.TabIndex = 2;
            this.buttonPCGame.Text = "PC Game";
            this.buttonPCGame.UseVisualStyleBackColor = true;
            this.buttonPCGame.Click += new System.EventHandler(this.buttonPC_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 853);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UbisoftLogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPCGame;
        private System.Windows.Forms.Button buttonMobileGame;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPS4Game;
        private System.Windows.Forms.Button buttonXboxGame;
        private System.Windows.Forms.FlowLayoutPanel sideSelectPanel;
        private System.Windows.Forms.PictureBox UbisoftLogo;
    }
}

