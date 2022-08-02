using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace snake_winForms
{
    [DataContract]
    public class Pixel
    {
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
        [DataMember]
        private Color _color;
        [DataMember]
        public Settings Settings;
        public Pixel(Settings settings, int x, int y, Color color)
        {
            this.Settings = settings;
            X = x;
            Y = y;
            _color = color;
        }

        public void Draw()
        {
            Settings.graphics.FillRectangle(new SolidBrush(_color), X * Settings.PixelSize, Y * Settings.PixelSize, Settings.PixelSize, Settings.PixelSize);
        }

        public void Clear()
        {
            int a = 1;
            Settings.graphics.FillRectangle(new SolidBrush(Settings.FieldColor), X * Settings.PixelSize, Y * Settings.PixelSize, Settings.PixelSize, Settings.PixelSize);
        }
    }
}
