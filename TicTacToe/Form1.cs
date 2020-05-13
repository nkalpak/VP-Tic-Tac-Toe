using System;
using System.Windows.Forms;

// TODO: Create checkers for win states (horizontal, vertical, primary/secondary diagonal)

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 3;
        private bool HasWon;

        private string[,] _board = new string[3, 3];
        private string _currentSign = "X";

        private bool IsIndexValid(int index) => index >= 0 && index < 9;

        private bool IsBoardSignedAtPosition(int index)
        {
            int x = index % BoardSize;
            int y = index / BoardSize;

            return _board[x, y] != null;
        }

        private bool IsBoardHorizontalWinState()
        {
            var win = false;

            for (var i = 0; i < BoardSize; i++)
            {
                string sign = _board[i, 0];
                win = true;

                for (var j = 1; j < BoardSize; j++)
                {
                    string boardSign = _board[i, j];
                    if (boardSign == null || sign == null || !boardSign.Equals(sign)) win = false;
                }

                if (win) return win;
            }

            return win;
        }
        
        private bool IsBoardVerticalWinState()
        {
            var win = false;

            for (var i = 0; i < BoardSize; i++)
            {
                string sign = _board[0, i];
                win = true;

                for (var j = 1; j < BoardSize; j++)
                {
                    string boardSign = _board[j, i];
                    if (boardSign == null || sign == null || !boardSign.Equals(sign)) win = false;
                }

                if (win) return win;
            }

            return win;
        }
        
        private void SignBoardAtPosition(int index, string sign)
        {
            if (!IsIndexValid(index)) throw new IndexOutOfRangeException("Button positions are only [0-8].");

            int x = index % BoardSize;
            int y = index / BoardSize;

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
            if (IsBoardHorizontalWinState() || IsBoardVerticalWinState())
            {
                HasWon = true;
                WinnerDisplay.Text = "Someone has won!";
            }

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