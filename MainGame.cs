using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class MainGame : Form
    {
        private Bitmap[] Images = {
            HangManGame.Properties.Resources.Tom,
            HangManGame.Properties.Resources.Tom1,
            HangManGame.Properties.Resources.Tom2,
            HangManGame.Properties.Resources.Tom3,
            HangManGame.Properties.Resources.Tom4,
            HangManGame.Properties.Resources.Tom5,
            HangManGame.Properties.Resources.Tom6
        };
        private int WrongGuess = 0;
        private int ChancesLeftCounter = 6;
        private string current = "";
        private string CopyCurrent = "";
        private int ChancesLeft;
        private int  Score = 0;
        private string[]  Words;
        public MainGame()
        {
            Thread TheThread = new Thread(new ThreadStart(formRun));
            TheThread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            TheThread.Abort();
            DeflautValues();
        }
        private void DeflautValues()
        {
            WrongGuess = 0;
            ChancesLeftCounter = 6;
            Lbl_ChancesLeft.Text ="6";
            Lbl_YouLose.Visible = false;
            PictureBoxImage.Image = HangManGame.Properties.Resources.Tom;
        }
        private void Lose()
        {
            Btn_A.Visible = false;//A
            Btn_B.Visible = false;//B
            Btn_c.Visible = false;//C
            Btn_D.Visible = false;//D
            Btn_E.Visible = false;//E
            Btn_F.Visible = false;//F
            Btn_G.Visible = false;//G
            Btn_H.Visible = false;//H
            Btn_I.Visible = false;//I
            Btn_J.Visible = false;//J
            Btn_K.Visible = false;//K
            Btn_L.Visible = false;//L
            Btn_M.Visible = false;//M
            Btn_N.Visible = false;//N
            Btn_O.Visible = false;//O
            Btn_P.Visible = false;//P
            Btn_Q.Visible = false;//Q
            Btn_R.Visible = false;//R
            Btn_S.Visible = false;//S
            Btn_T.Visible = false;//T
            Btn_U.Visible = false;//U
            Btn_V.Visible = false;//V
            Btn_W.Visible = false;//W
            Btn_X.Visible = false;//X
            Btn_Y.Visible = false;//Y
            Btn_Z.Visible = false;//Z
            Lbl_YouLose.Visible = true;
            Lbl_YouLose.Text = "You Lose";
        }
        private void LoadWords()
        {
            char[] Delimiter = {','};
            string[] readWords = File.ReadAllLines("Fruits.txt");
            Words = new string[readWords.Length];
            int index = 0;
            foreach(string s in readWords)
            {
                string[] line = s.Split(Delimiter);
                Words[index++] = line[1];
            }
        }
        private void SetUpWordChoice()
        {
            int GuessIndex = (new Random()).Next(Words.Length);
            current = Words[GuessIndex];
            CopyCurrent = "";
            for(int index =0;index<current.Length;index++)
            {
                CopyCurrent += "_";
            }
            DisplayCopy();
        }
        private void DisplayCopy()
        {
            Lbl_Missingword.Text = "";
            for(int index =0;index<CopyCurrent.Length;index++)
            {
                Lbl_Missingword.Text += CopyCurrent.Substring(index, 1);
                Lbl_Missingword.Text += " ";
            }
        }
        private void formRun()
        {
            Application.Run(new MainForm());
        } 
        private void Guess_Click(object sender, EventArgs e)
        {
            Button Choice = sender as Button;
            if(current.Contains(Choice.Text))
            {
                char[] temp = CopyCurrent.ToCharArray();
                char[] Find = current.ToCharArray();
                char GuessChar = Choice.Text.ElementAt(0);
                for(int index=0; index<Find.Length;index++)
                {
                    if(Find[index]==GuessChar)
                    {
                        temp[index] = GuessChar;
                    }
                    Choice.BackColor = Color.Red;
                }
                CopyCurrent = new string(temp);
                DisplayCopy();
            }
            else
            {
               
                if (WrongGuess < 6)
                {
                    ChancesLeftCounter--;
                    PictureBoxImage.Image = Images[WrongGuess];
                    ChancesLeft = ChancesLeftCounter;
                    WrongGuess++;
                    Lbl_ChancesLeft.Text = ChancesLeft.ToString();
                }
                else
                {
                    Lose();
                }
            }
            if (CopyCurrent.Equals(current))
            {
                UpdateValues();
            }
        }
        private  void UpdateValues()
        {
            Score++;
            Lbl_Score.Text = Score.ToString();
            SetUpWordChoice();
            Btn_A.BackColor = Color.FromArgb(226, 185, 105);//A
            Btn_B.BackColor = Color.FromArgb(226, 185, 105); //B
            Btn_c.BackColor = Color.FromArgb(226, 185, 105); //C
            Btn_D.BackColor = Color.FromArgb(226, 185, 105);//D
            Btn_E.BackColor = Color.FromArgb(226, 185, 105);//E
            Btn_F.BackColor = Color.FromArgb(226, 185, 105);//F
            Btn_G.BackColor = Color.FromArgb(226, 185, 105);//G
            Btn_H.BackColor = Color.FromArgb(226, 185, 105);//H
            Btn_I.BackColor = Color.FromArgb(226, 185, 105);//I
            Btn_J.BackColor = Color.FromArgb(226, 185, 105);//J
            Btn_K.BackColor = Color.FromArgb(226, 185, 105);//K
            Btn_L.BackColor = Color.FromArgb(226, 185, 105);//L
            Btn_M.BackColor = Color.FromArgb(226, 185, 105);//M
            Btn_N.BackColor = Color.FromArgb(226, 185, 105);//N
            Btn_O.BackColor = Color.FromArgb(226, 185, 105);//O
            Btn_P.BackColor = Color.FromArgb(226, 185, 105);//P
            Btn_Q.BackColor = Color.FromArgb(226, 185, 105);//Q
            Btn_R.BackColor = Color.FromArgb(226, 185, 105);//R
            Btn_S.BackColor = Color.FromArgb(226, 185, 105);//S
            Btn_T.BackColor = Color.FromArgb(226, 185, 105);//T
            Btn_U.BackColor = Color.FromArgb(226, 185, 105);//U
            Btn_V.BackColor = Color.FromArgb(226, 185, 105);//V
            Btn_W.BackColor = Color.FromArgb(226, 185, 105);//W
            Btn_X.BackColor = Color.FromArgb(226, 185, 105);//X
            Btn_Y.BackColor = Color.FromArgb(226, 185, 105);//Y
            Btn_Z.BackColor = Color.FromArgb(226, 185, 105);//Z         
        }
        private void MainGame_Load(object sender, EventArgs e)
        {
            LoadWords();
            SetUpWordChoice();
        }
        private void Lbl_NewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGame TheMainGame = new MainGame();
            TheMainGame.ShowDialog();
        }
    }
}