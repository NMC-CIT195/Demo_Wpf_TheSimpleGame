using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_TheSimpleGame.Models;

namespace Demo_Wpf_TheSimpleGame.Presentation
{
    public class GameViewModel : ObservableObject
    {
        private Gameboard _gameboard;

        private Player _playerOne;
        private Player _playerTwo;

        public string Test { get; set; }

        public Player PlayerOne
        {
            get { return _playerOne; }
            set
            {
                _playerOne = value;
                OnPropertyChanged(nameof(PlayerOne));
            }
        }

        public Player PlayerTwo
        {
            get { return _playerTwo; }
            set
            {
                _playerTwo = value;
                OnPropertyChanged(nameof(PlayerTwo));
            }
        }

        public GameViewModel((Player playerOne, Player playerTwo) players)
        {
            _playerOne = players.playerOne;
            _playerTwo = players.playerTwo;

            InitializeGame();
        }

        private void InitializeGame()
        {
            _gameboard = new Gameboard();
            _gameboard.InitializeGameboard();
        }
    }
}
