using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreakerer
{

   
    class Game
    {
        int ballMoveLeft;
        int ballMoveTop;
        int brickCount;
        int gameLevel;
        int levelFour;
        int levelNumber;
        int levelOne;
        int levelThree;
        int levelTwo;
        int levelWin;
        int scoreUpdate;
        List<int> scores;



        Ball ball;
        Wall wall; 

        public Game ()
        {
            this.ball = new Ball();
            this.wall = new Wall();
        }
        
        public void BallBounce()
        {
            //method
        }

        public void GameLevel()
        {
            //method
        }

        public void GameOverLoop()
        {
            //method
        }

        public void GameOverLose()
        {
            //method
        }

        public void GameOverRestart()
        {
            //method
        }

        public void GameSplash()
        {
            //method
        }

        public void PaddleSlide()
        {
            //method
        }

        public void RunGame()
        {
            //method
        }

        public void RunGameEasy()
        {
            //method
        }

        public void RunGameHard()
        {
            //method
        }

        public void RunGameLoopEasy()
        {
            //method
        }

        public void RunGameLoopHard()
        {
            //method
        }

        public void Score()
        {
            //method
        }


    }
}
