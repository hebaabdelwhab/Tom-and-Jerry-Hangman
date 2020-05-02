using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class MainForm : Form
    {
        int move=2;
        public MainForm()
        {
           
            InitializeComponent();
           
        }
        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            Pnl_Splash.Left += 2;
            if(Pnl_Splash.Left> 504)
            {
                Pnl_Splash.Left = 0;
            }
            if(Pnl_Splash.Left<0)
            {
              move = 2;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimerSplash.Start();
        }
    }
}
