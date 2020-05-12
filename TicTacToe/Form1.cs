using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private const int BOARD_WIDTH = 3; 
        
        private string[,] _board = new string[3, 3];
        private string _currentSign = "X";

        private bool IsIndexValid(int index) => index >= 0 && index < 9;

        private bool IsBoardSignedAtPosition(int index)
        {
            int x = index % BOARD_WIDTH;
            int y = index / BOARD_WIDTH;

            return _board[x, y] != null;
        }

        private void SignBoardAtPosition(int index, string sign)
        {
            if (!IsIndexValid(index)) throw new IndexOutOfRangeException("Button positions are only [0-8].");

            int x = index % BOARD_WIDTH;
            int y = index / BOARD_WIDTH;

            _board[x, y] = sign;
        }

        private void ToggleSign()
        {
            _currentSign = _currentSign == "X" ? "O" : "X";
        }

        private void HandleButtonSignRender(Button button)
        {
            string buttonName = button.Name;
            string lastChar = buttonName.Substring(buttonName.Length - 1);
            int buttonIndex = int.Parse(lastChar) - 1;

            if (IsBoardSignedAtPosition(buttonIndex)) return;
            
            SignBoardAtPosition(buttonIndex, _currentSign);
            button.Text = _currentSign;
            
            ToggleSign();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void GameButton1_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton2_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton3_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton4_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton5_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton6_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton7_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton8_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
        
        private void GameButton9_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
    }
}