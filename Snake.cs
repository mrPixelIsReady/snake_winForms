using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace snake_winForms
{
    [DataContract]
    public class Snake
    {
        [DataMember]
        public Settings Settings { get; set; }
        [DataMember]
        public Pixel Head { get; private set; }
        [DataMember]
        public Queue<Pixel> Body { get; private set; }
        public Snake(Settings settings)
        {
            this.Settings = settings;

            Head = new Pixel(settings, settings.SnakeSpawnX, settings.SnakeSpawnY, settings.HeadColor);
            Body = new Queue<Pixel>();

            for (int i = settings.SnakeInitialLength; i > 0; i--)
            {
                Pixel bodyPart = new Pixel(settings, Head.X - i, Head.Y, settings.BodyColor);
                Body.Enqueue(bodyPart);
                bodyPart.Draw();
            }
            Head.Draw();
        }

        public void Move(Direction direction, bool hasEaten)
        {
            Pixel newie = new Pixel(Settings, Head.X, Head.Y, Settings.BodyColor);
            Body.Enqueue(newie);
            newie.Draw();
            if (!hasEaten)
            {
                Body.Dequeue().Clear();
            }

            switch (direction)
            {
                case Direction.Up:
                    Head.Y--;
                    break;
                case Direction.Down:
                    Head.Y++;
                    break;
                case Direction.Left:
                    Head.X--;
                    break;
                case Direction.Right:
                    Head.X++;
                    break;
            }
            Head.Draw();            
        }
    }
}
