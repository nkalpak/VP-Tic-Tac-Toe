using System;

namespace TicTacToe
{
    public class GameBoard
    {
        private const int BoardSize = 3;
        public bool HasWon { get; private set; }

        private readonly string[,] _board = new string[3, 3];
        private string _currentSign = "O";

        private static bool IsIndexValid(int index) => index >= 0 && index < 9;

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

        private bool IsBoardMainDiagonalWinState()
        {
            string top = _board[0, 0];
            string mid = _board[1, 1];
            string bottom = _board[2, 2];

            if (top == null) return false;

            return top == mid && mid == bottom;
        }

        private bool IsBoardSecondaryDiagonalWinState()
        {
            string bottom = _board[2, 0];
            string mid = _board[1, 1];
            string top = _board[0, 2];

            if (bottom == null) return false;

            return bottom == mid && mid == top;
        }

        private void DetermineIfPlayerHasWon()
        {
            if (IsBoardMainDiagonalWinState()
                || IsBoardSecondaryDiagonalWinState()
                || IsBoardHorizontalWinState()
                || IsBoardVerticalWinState())
            {
                HasWon = true;
            }
        }

        /// <summary>
        /// Method which signs the board with either X or O at the given index position.
        /// </summary>
        /// <param name="index">The 1D index position at which the 2D board should be signed.</param>
        /// <returns>The appropriate sign which was inserted at the given position. (determined by internal logic)</returns>
        public string SignBoardAtPosition(int index)
        {
            if (!IsIndexValid(index)) throw new IndexOutOfRangeException("Button positions are only [0-8].");
            if (GetSignAtPosition(index) != null) return GetSignAtPosition(index);

            int x = index % BoardSize;
            int y = index / BoardSize;

            SetSignOn2dBoard(x, y);
            DetermineIfPlayerHasWon();

            return _currentSign;
        }

        private void SetSignOn2dBoard(int x, int y)
        {
            ToggleSign();
            _board[x, y] = _currentSign;
        }

        private string GetSignAtPosition(int index)
        {
            int x = index % BoardSize;
            int y = index / BoardSize;

            return _board[x, y];
        }

        private void ToggleSign()
        {
            _currentSign = _currentSign == "X" ? "O" : "X";
        }
    }
}