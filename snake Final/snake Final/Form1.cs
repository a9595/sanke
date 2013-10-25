using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        private enum Directions : byte
        {
            Stopped,
            Up,
            Down,
            Left,
            Right
        };

        private enum Lvl : byte
        {
            Beginner = 5,
            Amature = 10,
            LikeAPro = 20
        };

        int _lifesCount = 3, _bombsCount = 5, _applesCount = 5; //житкі, бомби, яблука (кількість)
        int _currentApplesEated, _currentBombsCount, _scores;
        Directions _currentSnakeDirection = Directions.Stopped; //поточний напрямок руху змії
        Lvl _currentLvl = Lvl.Beginner;
        private const int width = 20, height = 20;
        byte[,] field = new byte[width, height];
        private const byte back = 0, apple = 1, bomb = 2, imageWidth = 30, imageHeight = 30,
                              snakeTale = 4, snakeBody = 5, snakeHead = 6;

        public List<SnakePint> NewSnake = new List<SnakePint>(); // ліст де переміщена змєйка є (буферний)
        public List<SnakePint> SnakeList = new List<SnakePint>(); //тут настоящя тікущя змєйка сидить
        private Image bApple = Properties.Resources.apple;
        private Image bBomb = Properties.Resources.bomb;
        private Image bSnakeHead = Properties.Resources.snake_head;
        private Image bSnakeBody = Properties.Resources.snake_body;
        private Image bSnakeTale = Properties.Resources.snake_tale;


        public Form1()
        {
            InitializeComponent();
            //FillSnake(6);
            //RandomFieldFill(5, 5);
            //timerSnake.Start();
            GetAppleAndBombsSettings();
            NewGame(snakeSize: 5, applesCount: _applesCount, bombsCount: _bombsCount, lifesCount: 3);
        }
        public class SnakePint
        {
            public int x, y;
            public byte type;
        }


        void FillSnake(int size)
        {
            SnakeList.Clear();
            for (int i = size - 1; i >= 0; i--)
            {
                SnakeList.Add(new SnakePint() { type = snakeBody, x = 0, y = i });
            }

            SnakeList.First().type = snakeHead;
            SnakeList.Last().type = snakeTale;
            //ДОДАЙ СНЕЙК НА ФІЛД
            for (int i = 0; i < SnakeList.Count; i++)
            {
                field[SnakeList[i].x, SnakeList[i].y] = SnakeList[i].type;
            }

        }
        void RandomFieldFill(int AppleCount, int BombCount)
        {
            Random r = new Random(Environment.TickCount);
            int i = 0;
            do//apples
            {
                int x = r.Next(0, width), y = r.Next(0, height);
                if (field[x, y] == 0)
                {
                    i++;
                    field[x, y] = apple;
                }
            } while (i <= AppleCount);

            i = 0;
            do//bombs
            {
                int x = r.Next(0, width), y = r.Next(0, height);
                try//check if bombs is not near head
                {
                    if (field[x, y] == 0 && field[x - 1, y] != snakeHead && field[x, y - 1] != snakeHead)
                    {
                        i++;
                        field[x, y] = bomb;
                    }
                }
                catch (Exception)
                { }

            } while (i <= BombCount);
        }

        private void Form1Paint(object sender, PaintEventArgs e)
        {
            lock (this)
            {
                Graphics g = e.Graphics;

                for (int i = 0; i < field.GetLength(0); i++)
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        switch (field[i, j])
                        {
                            //case back:
                            //    g.DrawImageUnscaled(bBack, i * imageWidth, j * imageHeight);
                            //    break;
                            case apple:
                                g.DrawImageUnscaled(bApple, i * imageWidth, j * imageHeight + 25);
                                break;
                            case bomb:
                                g.DrawImageUnscaled(bBomb, i * imageWidth, j * imageHeight + 25);
                                break;
                            case snakeTale:
                                g.DrawImageUnscaled(bSnakeTale, i * imageWidth, j * imageHeight + 25);
                                break;
                            case snakeBody:
                                g.DrawImageUnscaled(bSnakeBody, i * imageWidth, j * imageHeight + 25);
                                break;
                            case snakeHead:
                                g.DrawImageUnscaled(bSnakeHead, i * imageWidth, j * imageHeight + 25);
                                break;
                        }
                    }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lock (this)
            {
                NewSnake = new List<SnakePint>();
                switch (e.KeyCode.ToString())
                {
                    case "Down":
                        {
                            //bool isBodyUnderTheHead = SnakeList.First().y - 1 != 0; //Can you turn correct if snake paused 
                            if (_currentSnakeDirection == Directions.Up) return;
                            //NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = SnakeList[0].y + 1 }); //записуємо в новий ліст -переміщену голову
                            _currentSnakeDirection = Directions.Down;
                        }
                        break;

                    case "Left":
                        {
                            //bool isBodyLeftTheHead = SnakeList.First().x - 1 != 0; //Can you turn correct if snake paused
                            if (_currentSnakeDirection == Directions.Right) return;
                            //NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x - 1, y = SnakeList[0].y });
                            _currentSnakeDirection = Directions.Left;
                        }
                        break;

                    case "Right":
                        {
                            //bool isBodyRightTheHead = SnakeList.First().x + 1 != 0; //Can you turn correct if snake paused
                            if (_currentSnakeDirection == Directions.Left) return;
                            //NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x + 1, y = SnakeList[0].y });
                            _currentSnakeDirection = Directions.Right;
                        }
                        break;

                    case "Up":
                        {
                            //bool isBodyUpTheHead = SnakeList.First().y + 1 == snakeBody; //Can you turn correct if snake paused 
                            if (_currentSnakeDirection == Directions.Down) return;
                            //NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = SnakeList[0].y - 1 });
                            _currentSnakeDirection = Directions.Up;
                        }
                        break;
                    case "Space":
                        _currentSnakeDirection = Directions.Stopped;
                        break;
                }
            }
        }



        private void timerSnake_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                bool IsGrow = false;
                NewSnake = new List<SnakePint>();
                switch (_currentSnakeDirection)
                {
                    case Directions.Stopped:
                        return;
                    case Directions.Up:
                        //NewSnake.Add(SnakeList[0].y - 1 < 0
                        //                 ? new SnakePint() {type = snakeHead, x = SnakeList[0].x, y = height-1}
                        //                 : new SnakePint()
                        //                       {type = snakeHead, x = SnakeList[0].x, y = SnakeList[0].y - 1});
                        if (SnakeList[0].y - 1 < 0)
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = height - 1 });
                        else
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = SnakeList[0].y - 1 });
                        break;
                    case Directions.Down:
                        NewSnake.Add(SnakeList[0].y + 1 >= height
                                         ? new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = 0 }
                                         : new SnakePint() { type = snakeHead, x = SnakeList[0].x, y = SnakeList[0].y + 1 });
                        break;
                    case Directions.Left:
                        if (SnakeList[0].x - 1 < 0)
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = width - 1, y = SnakeList[0].y });
                        else
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x - 1, y = SnakeList[0].y });
                        break;
                    case Directions.Right:
                        if (SnakeList[0].x + 1 >= width)//не пахало, бо писав x = SnakeList[0].x = 0
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = 0, y = SnakeList[0].y });
                        else
                            NewSnake.Add(new SnakePint() { type = snakeHead, x = SnakeList[0].x + 1, y = SnakeList[0].y });
                        break;
                }

                switch (field[NewSnake.Last().x, NewSnake.Last().y])
                {
                    case snakeTale:
                    case snakeBody:
                    case bomb:
                        GameOver();
                        return;
                    case apple:
                        if (++_currentApplesEated >= _applesCount)
                            SpawnNewApple();
                        if (_currentApplesEated % 2 == 0) //якшо парне число яблук (по ідєї має реагувать через раз)
                        {
                            SpawnNewBomb();
                            BombsCountStatusLabel.Text = (++_currentBombsCount).ToString();
                        }
                        IsGrow = true;
                        ApplesCountStatusLabel.Text = _currentApplesEated.ToString();
                        ScoresCountStatusLabel.Text = (_scores += (int)_currentLvl).ToString(); //add scores acording to the GameLvl
                        break;
                }

                field[NewSnake.Last().x, NewSnake.Last().y] = NewSnake.Last().type; //записуємо цю голову на поле 
                for (int i = 1; i < SnakeList.Count; i++)
                {
                    NewSnake.Add(SnakeList[i - 1]); //записуємо всю стару змєйку в нову (тіло її)
                    NewSnake.Last().type = snakeBody;
                    field[NewSnake.Last().x, NewSnake.Last().y] = NewSnake.Last().type;
                    //записуємо новий елемент тіла на поле 
                }
                if (IsGrow)
                    NewSnake.Add(SnakeList.Last());

                field[SnakeList.Last().x, SnakeList.Last().y] = back;//ставим фон на останній елемент, бо він уїхав уже

                NewSnake.Last().type = snakeTale; //останній елемент міняєм на хвоста

                field[NewSnake.Last().x, NewSnake.Last().y] = snakeTale; //записуємо хвост в поле
                SnakeList = NewSnake; //міняємо змєйку на нову
                Invalidate();
            }
        }
    }
}

