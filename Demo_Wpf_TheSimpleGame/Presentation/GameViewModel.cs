using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_TheSimpleGame.Models;

namespace Demo_Wpf_TheSimpleGame.Presentation
{
    class GameViewModel : ObservableObject
    {
        private GameView _gameView;
        private Gameboard _gameboard;

        private Player _playerOne;
        private Player _playerTwo;



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

        public GameViewModel(GameView gameView, (Player playerOne, Player playerTwo) players)
        {
            _gameView = gameView;
            _playerOne = players.playerOne;
            _playerTwo = players.playerTwo;

            InitializeGame();
        }

        private void InitializeGame()
        {
            _gameboard = new Gameboard();
            _gameboard.InitializeGameboard();

            _gameView.Show();
        }
    }
}
