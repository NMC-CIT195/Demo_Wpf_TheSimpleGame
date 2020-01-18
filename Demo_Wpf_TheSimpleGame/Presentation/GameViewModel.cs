using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheSimpleGame.Presentation
{
    class GameViewModel
    {
        private GameView gameView;

        public GameViewModel(GameView gameView)
        {
            this.gameView = gameView;
        }
    }
}
