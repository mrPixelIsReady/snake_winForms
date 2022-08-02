using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_winForms
{
    public partial class MenuForm : Form
    {
        private Settings settings = new Settings();
        private Game game;
        private int _newPixelSize;
        private int _newMapWidth;
        private int _newMapHeight;
        private int _newGameSpeed;
        private bool _enableBorders = true;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            settings.SnakeSpawnX = settings.MapWidth / 2;
            settings.SnakeSpawnY = settings.MapHeight / 2;
            form.Settings = settings;
            form.Show();
            this.Hide();
            form.Disposed += (o, e) => this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Text = "Змейка (Настройки)";

            newGameButton.Visible = false;
            ContinueButton.Visible = false;
            SettingsButton.Visible = false;
            ExitButton.Visible = false;

            BackButton.Visible = true;
            pictureBox1.Visible = true;
            InfoDisplay.Visible = true;
            PixelSizeBar.Visible = true;
            PixelSizeLabel.Visible = true;
            MapWidthLabel.Visible = true;
            MapWidthBar.Visible = true;
            MapHeightLabel.Visible = true;
            MapHeightBar.Visible = true;
            BorderColorButton.Visible = true;
            HeadColorButton.Visible = true;
            BorderColorButton.Visible = true;
            FoodColorButton.Visible = true;
            BodyColorButton.Visible= true;
            GameSpeedLabel.Visible = true;
            GameSpeedBar.Visible = true;
            EnableBorders.Visible = true;

            settings.PixelSize = 40;
            settings.MapWidth = 10;
            settings.MapHeight = 10;

            game = new Game(settings);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            settings.graphics = Graphics.FromImage(bmp);
            game.Start();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            newGameButton.Visible = true;
            ContinueButton.Visible = true;
            SettingsButton.Visible = true;
            ExitButton.Visible = true;

            BackButton.Visible = false;
            pictureBox1.Visible = false;
            InfoDisplay.Visible = false;
            PixelSizeBar.Visible = false;
            PixelSizeLabel.Visible = false;
            MapWidthBar.Visible = false;
            MapWidthLabel.Visible = false;
            MapHeightBar.Visible = false;
            MapHeightLabel.Visible = false;
            BorderColorButton.Visible = false;
            HeadColorButton.Visible = false;
            BorderColorButton.Visible = false;
            FoodColorButton.Visible = false;
            BodyColorButton.Visible = false;
            GameSpeedBar.Visible = false;
            GameSpeedLabel.Visible = false;
            EnableBorders.Visible = false;

            if (_newPixelSize != 0)
            {
                settings.PixelSize = _newPixelSize;
            }
            if (_newMapWidth != 0)
            {
                settings.MapWidth = _newMapWidth;
            }
            if (_newMapHeight != 0)
            {
                settings.MapHeight = _newMapHeight;
            }
            if (_newGameSpeed != 0)
            {
                settings.GameSpeed = _newGameSpeed;
            } 
            settings.EnableBorders = _enableBorders;
        }

        private void PixelSizeBar_ValueChanged(object sender, EventArgs e)
        {
            _newPixelSize = PixelSizeBar.Value;
            InfoDisplay.Text = Convert.ToString(_newPixelSize);
        }

        private void MapWidthBar_ValueChanged(object sender, EventArgs e)
        {
            _newMapWidth = MapWidthBar.Value;
            InfoDisplay.Text = Convert.ToString(_newMapWidth);
        }

        private void MapHeightBar_ValueChanged(object sender, EventArgs e)
        {
            _newMapHeight = MapHeightBar.Value;
            InfoDisplay.Text = Convert.ToString(_newMapHeight);
        }

        private void BorderColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            settings.BorderColor = colorDialog1.Color;
            settings.graphics.Clear(Color.White);
            game.Start();
            pictureBox1.Refresh();
        }

        private void HeadColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            settings.HeadColor = colorDialog1.Color;
            settings.graphics.Clear(Color.White);
            game.Start();
            pictureBox1.Refresh();
        }

        private void BodyColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            settings.BodyColor = colorDialog1.Color;
            settings.graphics.Clear(Color.White);
            game.Start();
            pictureBox1.Refresh();
        }

        private void FoodColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            settings.FoodColor = colorDialog1.Color;
            settings.graphics.Clear(Color.White);
            game.Start();
            pictureBox1.Refresh();
        }

        private void GameSpeedBar_ValueChanged(object sender, EventArgs e)
        {
            _newGameSpeed = GameSpeedBar.Value;
            InfoDisplay.Text = GameSpeedBar.Value.ToString();
        }

        private void EnableBorders_CheckedChanged(object sender, EventArgs e)
        {
            _enableBorders = EnableBorders.Checked;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            var jsonFormatter = new DataContractSerializer(typeof(Game));
            using (var file = new FileStream("save.json", FileMode.OpenOrCreate))
            {
                Game newgame = jsonFormatter.ReadObject(file) as Game;
                if (newgame != null)
                {
                    game = newgame;
                }
            }

            var form = new Form1();
            form.game = game;
            form.Show();
            this.Hide();
            form.Disposed += (o, e) => this.Show();
        }
    }
}
