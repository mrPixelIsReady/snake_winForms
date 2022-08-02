using System.Runtime.Serialization;

namespace snake_winForms
{
    public partial class Form1 : Form
    {
        public Settings Settings { get; set; }
        public Game game;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (game == null)
            {
                GameStart();
            }
            else
            {
                GameContinue();
            }
                       
        }
        public void GameContinue()
        {
            Settings = game.Settings;
            game.GameOver += GameOverAction;
            timer1.Interval = 1000 / Settings.GameSpeed;
            Height = Settings.MapHeight * Settings.PixelSize + 42;
            Width = Settings.MapWidth * Settings.PixelSize + 15;
            pictureBox1.Width = Settings.MapWidth * Settings.PixelSize;
            pictureBox1.Height = Settings.MapHeight * Settings.PixelSize;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            Settings.graphics = Graphics.FromImage(bmp);

            game.Snake.Settings = game.Settings;
            game.Snake.Head.Settings = game.Settings;
            List<Pixel> pixels = new List<Pixel>();
            int length = game.Snake.Body.Count;
            for (int i = 0; i < length; i++)
            {
                pixels.Add(game.Snake.Body.Dequeue());
                pixels[i].Settings = game.Settings;
            }
            for (int i = 0; i < length; i++)
            {
                game.Snake.Body.Enqueue(pixels[i]);
            }
            timer1.Start();

        }
        public void GameStart()
        {
            game = new Game(Settings);
            game.GameOver += GameOverAction;
            timer1.Interval = 1000 / Settings.GameSpeed;
            Height = Settings.MapHeight * Settings.PixelSize + 42;
            Width = Settings.MapWidth * Settings.PixelSize + 15;

            pictureBox1.Width = Settings.MapWidth * Settings.PixelSize;
            pictureBox1.Height = Settings.MapHeight * Settings.PixelSize;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            Settings.graphics = Graphics.FromImage(bmp);

            game.Start();
            timer1.Start();
        }
        private void GameOverAction()
        {
            timer1.Stop();

            string message = $"Ваш текущий рекорд: {game.Score}\nЖелаете попробовать ещё раз?";
            var result = MessageBox.Show(message, "Игра окончена!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                GameStart();
            }
            else
            {
                this.Close();
            }
        }
        private void Pause()
        {
            timer1.Stop();
            string title = "Пауза";
            string message = "Игра приостановлена.\nЖелаете выйти в меню (прогресс будет сохранён)?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //TODO: progress save

                var jsonFormatter = new DataContractSerializer(typeof(Game));
                using (var file = new FileStream("save.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, game);
                }

                this.Close();
            }
            else
            {
                timer1.Start();   
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Tick();
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Direction current;
            switch (e.KeyCode)
            {
                case Keys.W:
                    current = Direction.Up;
                    break;
                case Keys.S:
                    current = Direction.Down;
                    break;
                case Keys.A:
                    current = Direction.Left;
                    break;
                case Keys.D:
                    current = Direction.Right;
                    break;
                case Keys.Escape:
                    Pause();
                    current = game.OldDirection;
                    break;
                default:
                    current = game.OldDirection;
                    break;
            }

            switch (current)
            {
                case Direction.Up when game.OldDirection != Direction.Down:
                    game.NewDirection = current;
                    break;
                case Direction.Down when game.OldDirection != Direction.Up:
                    game.NewDirection = current;
                    break;
                case Direction.Left when game.OldDirection != Direction.Right:
                    game.NewDirection = current;
                    break;
                case Direction.Right when game.OldDirection != Direction.Left:
                    game.NewDirection = current;
                    break;
            }
        }
    }
}