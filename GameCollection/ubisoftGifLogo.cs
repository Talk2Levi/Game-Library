using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollection
{
    public partial class ubisoftGifLogo : UserControl
    {
        private static ubisoftGifLogo _instance;

        public static ubisoftGifLogo Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ubisoftGifLogo();
                }
                return _instance;
            }
        }

        public ubisoftGifLogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
