using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace snake_winForms
{
    [DataContract]
    public class Settings
    {
        [DataMember]
        public bool EnableBorders { get; set; } = true;
        [DataMember]
        public int GameSpeed { get; set; } = 5;
        [DataMember]
        public int SnakeInitialLength { get; set; } = 2;
        [DataMember]
        public int PixelSize { get; set; } = 30;
        [DataMember]
        public int MapHeight { get; set; } = 20;
        [DataMember]
        public int MapWidth { get; set; } = 20;
        [DataMember]
        public int SnakeSpawnX { get; set; } = 3;
        [DataMember]
        public int SnakeSpawnY { get; set; } = 3;

        [DataMember]
        public Color FieldColor { get; set; } = Color.White;
        [DataMember]
        public Color HeadColor { get; set; } = Color.Red;
        [DataMember]
        public Color BodyColor { get; set; } = Color.Black;
        [DataMember]
        public Color BorderColor { get; set; } = Color.Gray;
        [DataMember]
        public Color FoodColor { get; set; } = Color.Green;

        public Graphics graphics;
        private readonly Random random = new Random();
    }
}
