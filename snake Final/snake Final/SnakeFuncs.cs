using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1
    {
        //переносим функцию в інший файл:
        //1.создаєш файл новий (клас). ставиш імя таке саме як в главного класа і ставим partial
        //http://msdn.microsoft.com/ru-ru/library/wbx7zzdd.aspx
        
        void GameOver()
        {
            SnakeList.Clear();
            timerSnake.Stop();
            _lifesCount--;
            if (_lifesCount <= 0) //Full game over
            {
                if (MessageBox.Show("You get " + _scores + " scores \nTry again?", "Game over", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GetAppleAndBombsSettings();
                    NewGame(snakeSize: 5, applesCount: _applesCount, bombsCount: _bombsCount, lifesCount: 3);
                    _scores = 0;
                    return;
                }
                Close();
            }
            else //Not full game over
            {
                MessageBox.Show("Snake is dead =( \n You have " + _lifesCount + " lifes yet");
                GetAppleAndBombsSettings();
                NewGame(snakeSize: 5, applesCount: _applesCount, bombsCount: _bombsCount, lifesCount: _lifesCount);
            }

        }

        private void NewGame(int snakeSize, int applesCount, int bombsCount, int lifesCount)
        {
            SnakeList.Clear();
            timerSnake.Stop();
            timerSnake.Dispose();
            Array.Clear(field, 0, field.Length);
            _currentSnakeDirection = Directions.Stopped;

            _lifesCount = lifesCount;
            LifesStatusLabel.Text = String.Format(" " + _lifesCount);
            FillSnake(snakeSize);
            RandomFieldFill(applesCount, bombsCount);

            //lvl -- timer(snake speed) change
            if (_currentLvl == Lvl.Amature)
                timerSnake.Interval = 150;
            else if (_currentLvl == Lvl.LikeAPro)
                timerSnake.Interval = 100;
            else timerSnake.Interval = 250;

            _currentApplesEated = 0;
            _currentBombsCount = bombsCount;
            ScoresCountStatusLabel.Text = (_scores).ToString(); 
            timerSnake.Start();
            Invalidate();
        }
        void SpawnNewApple()
        {
            Random r = new Random(Environment.TickCount);
            bool appleGenerated = false;
            //apples
            do
            {
                int x = r.Next(0, width), y = r.Next(0, height);
                if (field[x, y] == 0)
                {
                    field[x, y] = apple;
                    appleGenerated = true;
                }
            } while (!appleGenerated);
            
        }
        void SpawnNewBomb()
        {
            Random r = new Random(Environment.TickCount);
            bool bombGenerated = false;
            do
            {
                int x = r.Next(0, width), y = r.Next(0, height);
                try//check if bombs is not near head
                {
                    //if (field[x, y] == 0 && field[x - 1, y] != snakeHead && field[x, y - 1] != snakeHead)
                    if (field[x, y] == 0)
                    {
                        field[x, y] = bomb;
                        bombGenerated = true;
                    }
                }
                catch (Exception)
                { }
            } while (!bombGenerated);
            
        }
        //void AddScores()
        //{
        //    //switch (_currentLvl)
        //    //{
        //    //        case Lvl.Beginner:
        //    //        _scores += 5;
        //    //        break;

        //    //        case Lvl.Amature:
        //    //        _scores += 10;
        //    //        break;

        //    //        case Lvl.LikeAPro:
        //    //        _scores += 20;
        //    //        break;
        //    //}
        //    _scores += (int) _currentLvl;
        //}
    }
}
