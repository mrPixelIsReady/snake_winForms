using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace snake_winForms
{
    [DataContract]
    public class Game
    {
        [DataMember]
        public Settings Settings { get; set; }
        [DataMember]
        public Snake Snake { get; set; }
        [DataMember]
        private Pixel food;
        private Random rnd = new Random();
        public Direction NewDirection { get; set; }
        public Direction OldDirection { get; set; } = Direction.Right;
        [DataMember]
        public int Score { get; private set; } = 0;
        
        public delegate void GameOverDelegate();
        public event GameOverDelegate GameOver;

        public Game(Settings settings)
        {
            this.Settings = settings;
        }
        public void Start()
        {
            if (Settings.EnableBorders)
            {
                DrawBorders();
            }
            Snake = new Snake(Settings);
            SpawnFood();
        }

        public void Tick()
        {
            bool hasEaten = false;
            if (Snake.Head.X == food.X && Snake.Head.Y == food.Y)
            {
                hasEaten = true;
                Score++;
                SpawnFood();
            }

            Snake.Move(NewDirection, hasEaten);
            OldDirection = NewDirection;

            bool hitSelf = Snake.Body.Any(i => i.X == Snake.Head.X && i.Y == Snake.Head.Y);

            if (hitSelf)
            {
                GameOver();
            }

            if (Settings.EnableBorders)
            {
                bool hitWall = Snake.Head.X == 0 || Snake.Head.X == Settings.MapWidth - 1
                         || Snake.Head.Y == 0 || Snake.Head.Y == Settings.MapHeight - 1;

                if (hitWall)
                {
                    GameOver();
                }
            }
            else
            {
                if (Snake.Head.X == Settings.MapWidth)
                {
                    Snake.Head.X = 0;
                }
                else if(Snake.Head.X == -1)
                {
                    Snake.Head.X = Settings.MapWidth - 1;
                }
                else if (Snake.Head.Y == Settings.MapHeight)
                {
                    Snake.Head.Y = 0;
                }
                else if (Snake.Head.Y == -1)
                {
                    Snake.Head.Y = Settings.MapHeight - 1;
                }

            }
            
        }

        public void SpawnFood()
        {
            bool IsInHead;
            bool IsInBody;
            do
            {
                food = new Pixel(Settings, rnd.Next(1, Settings.MapWidth - 1), rnd.Next(1, Settings.MapWidth - 1), Settings.FoodColor);
                IsInHead = food.X == Snake.Head.X && food.Y == Snake.Head.Y;
                IsInBody = Snake.Body.Any(i => i.X == food.X && i.Y == food.Y);
            } while (IsInHead || IsInBody);
            food.Draw();
        }
        void DrawBorders()
        {
            for (int i = 0; i < Settings.MapWidth; i++)
            {
                new Pixel(Settings, i, 0, Settings.BorderColor).Draw();
                new Pixel(Settings, i, Settings.MapHeight - 1, Settings.BorderColor).Draw();
            }
            for (int i = 0; i < Settings.MapHeight; i++)
            {
                new Pixel(Settings, 0, i, Settings.BorderColor).Draw();
                new Pixel(Settings, Settings.MapWidth - 1, i, Settings.BorderColor).Draw();
            }
        }
       
    }
}
