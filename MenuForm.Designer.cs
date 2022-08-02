namespace snake_winForms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.PixelSizeBar = new System.Windows.Forms.TrackBar();
            this.PixelSizeLabel = new System.Windows.Forms.Label();
            this.InfoDisplay = new System.Windows.Forms.TextBox();
            this.MapWidthLabel = new System.Windows.Forms.Label();
            this.MapWidthBar = new System.Windows.Forms.TrackBar();
            this.MapHeightLabel = new System.Windows.Forms.Label();
            this.MapHeightBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BorderColorButton = new System.Windows.Forms.Button();
            this.HeadColorButton = new System.Windows.Forms.Button();
            this.BodyColorButton = new System.Windows.Forms.Button();
            this.FoodColorButton = new System.Windows.Forms.Button();
            this.GameSpeedBar = new System.Windows.Forms.TrackBar();
            this.GameSpeedLabel = new System.Windows.Forms.Label();
            this.EnableBorders = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapHeightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 111);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(149, 69);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(12, 186);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(149, 69);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 261);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(149, 69);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 336);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(149, 69);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(342, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 401);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 336);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(149, 68);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PixelSizeBar
            // 
            this.PixelSizeBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.PixelSizeBar.Location = new System.Drawing.Point(21, 114);
            this.PixelSizeBar.Maximum = 50;
            this.PixelSizeBar.Minimum = 10;
            this.PixelSizeBar.Name = "PixelSizeBar";
            this.PixelSizeBar.Size = new System.Drawing.Size(130, 56);
            this.PixelSizeBar.TabIndex = 7;
            this.PixelSizeBar.Value = 10;
            this.PixelSizeBar.Visible = false;
            this.PixelSizeBar.ValueChanged += new System.EventHandler(this.PixelSizeBar_ValueChanged);
            // 
            // PixelSizeLabel
            // 
            this.PixelSizeLabel.AutoSize = true;
            this.PixelSizeLabel.Location = new System.Drawing.Point(30, 91);
            this.PixelSizeLabel.Name = "PixelSizeLabel";
            this.PixelSizeLabel.Size = new System.Drawing.Size(110, 20);
            this.PixelSizeLabel.TabIndex = 8;
            this.PixelSizeLabel.Text = "размер клетки";
            this.PixelSizeLabel.Visible = false;
            // 
            // InfoDisplay
            // 
            this.InfoDisplay.Location = new System.Drawing.Point(58, 37);
            this.InfoDisplay.Name = "InfoDisplay";
            this.InfoDisplay.ReadOnly = true;
            this.InfoDisplay.Size = new System.Drawing.Size(38, 27);
            this.InfoDisplay.TabIndex = 9;
            this.InfoDisplay.Visible = false;
            // 
            // MapWidthLabel
            // 
            this.MapWidthLabel.AutoSize = true;
            this.MapWidthLabel.Location = new System.Drawing.Point(30, 164);
            this.MapWidthLabel.Name = "MapWidthLabel";
            this.MapWidthLabel.Size = new System.Drawing.Size(105, 20);
            this.MapWidthLabel.TabIndex = 11;
            this.MapWidthLabel.Text = "Ширина поля";
            this.MapWidthLabel.Visible = false;
            // 
            // MapWidthBar
            // 
            this.MapWidthBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.MapWidthBar.Location = new System.Drawing.Point(21, 187);
            this.MapWidthBar.Maximum = 50;
            this.MapWidthBar.Minimum = 6;
            this.MapWidthBar.Name = "MapWidthBar";
            this.MapWidthBar.Size = new System.Drawing.Size(130, 56);
            this.MapWidthBar.TabIndex = 10;
            this.MapWidthBar.Value = 10;
            this.MapWidthBar.Visible = false;
            this.MapWidthBar.ValueChanged += new System.EventHandler(this.MapWidthBar_ValueChanged);
            // 
            // MapHeightLabel
            // 
            this.MapHeightLabel.AutoSize = true;
            this.MapHeightLabel.Location = new System.Drawing.Point(30, 238);
            this.MapHeightLabel.Name = "MapHeightLabel";
            this.MapHeightLabel.Size = new System.Drawing.Size(97, 20);
            this.MapHeightLabel.TabIndex = 13;
            this.MapHeightLabel.Text = "Высота поля";
            this.MapHeightLabel.Visible = false;
            // 
            // MapHeightBar
            // 
            this.MapHeightBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.MapHeightBar.Location = new System.Drawing.Point(21, 261);
            this.MapHeightBar.Maximum = 50;
            this.MapHeightBar.Minimum = 6;
            this.MapHeightBar.Name = "MapHeightBar";
            this.MapHeightBar.Size = new System.Drawing.Size(130, 56);
            this.MapHeightBar.TabIndex = 12;
            this.MapHeightBar.Value = 10;
            this.MapHeightBar.Visible = false;
            this.MapHeightBar.ValueChanged += new System.EventHandler(this.MapHeightBar_ValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            // 
            // BorderColorButton
            // 
            this.BorderColorButton.Location = new System.Drawing.Point(178, 217);
            this.BorderColorButton.Name = "BorderColorButton";
            this.BorderColorButton.Size = new System.Drawing.Size(115, 48);
            this.BorderColorButton.TabIndex = 14;
            this.BorderColorButton.Text = "Выбрать цвет границ";
            this.BorderColorButton.UseVisualStyleBackColor = true;
            this.BorderColorButton.Visible = false;
            this.BorderColorButton.Click += new System.EventHandler(this.BorderColorButton_Click);
            // 
            // HeadColorButton
            // 
            this.HeadColorButton.Location = new System.Drawing.Point(178, 271);
            this.HeadColorButton.Name = "HeadColorButton";
            this.HeadColorButton.Size = new System.Drawing.Size(115, 48);
            this.HeadColorButton.TabIndex = 15;
            this.HeadColorButton.Text = "Выбрать цвет головы";
            this.HeadColorButton.UseVisualStyleBackColor = true;
            this.HeadColorButton.Visible = false;
            this.HeadColorButton.Click += new System.EventHandler(this.HeadColorButton_Click);
            // 
            // BodyColorButton
            // 
            this.BodyColorButton.Location = new System.Drawing.Point(178, 325);
            this.BodyColorButton.Name = "BodyColorButton";
            this.BodyColorButton.Size = new System.Drawing.Size(115, 48);
            this.BodyColorButton.TabIndex = 16;
            this.BodyColorButton.Text = "Выбрать цвет тела";
            this.BodyColorButton.UseVisualStyleBackColor = true;
            this.BodyColorButton.Visible = false;
            this.BodyColorButton.Click += new System.EventHandler(this.BodyColorButton_Click);
            // 
            // FoodColorButton
            // 
            this.FoodColorButton.Location = new System.Drawing.Point(178, 379);
            this.FoodColorButton.Name = "FoodColorButton";
            this.FoodColorButton.Size = new System.Drawing.Size(115, 48);
            this.FoodColorButton.TabIndex = 17;
            this.FoodColorButton.Text = "Выбрать цвет еды";
            this.FoodColorButton.UseVisualStyleBackColor = true;
            this.FoodColorButton.Visible = false;
            this.FoodColorButton.Click += new System.EventHandler(this.FoodColorButton_Click);
            // 
            // GameSpeedBar
            // 
            this.GameSpeedBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.GameSpeedBar.Location = new System.Drawing.Point(178, 114);
            this.GameSpeedBar.Maximum = 20;
            this.GameSpeedBar.Minimum = 1;
            this.GameSpeedBar.Name = "GameSpeedBar";
            this.GameSpeedBar.Size = new System.Drawing.Size(130, 56);
            this.GameSpeedBar.TabIndex = 18;
            this.GameSpeedBar.Value = 10;
            this.GameSpeedBar.Visible = false;
            this.GameSpeedBar.ValueChanged += new System.EventHandler(this.GameSpeedBar_ValueChanged);
            // 
            // GameSpeedLabel
            // 
            this.GameSpeedLabel.AutoSize = true;
            this.GameSpeedLabel.Location = new System.Drawing.Point(181, 91);
            this.GameSpeedLabel.Name = "GameSpeedLabel";
            this.GameSpeedLabel.Size = new System.Drawing.Size(112, 20);
            this.GameSpeedLabel.TabIndex = 19;
            this.GameSpeedLabel.Text = "Скорость игры";
            this.GameSpeedLabel.Visible = false;
            // 
            // EnableBorders
            // 
            this.EnableBorders.AutoSize = true;
            this.EnableBorders.Checked = true;
            this.EnableBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableBorders.Location = new System.Drawing.Point(160, 52);
            this.EnableBorders.Name = "EnableBorders";
            this.EnableBorders.Size = new System.Drawing.Size(163, 24);
            this.EnableBorders.TabIndex = 20;
            this.EnableBorders.Text = "Включить границы";
            this.EnableBorders.UseVisualStyleBackColor = true;
            this.EnableBorders.Visible = false;
            this.EnableBorders.CheckedChanged += new System.EventHandler(this.EnableBorders_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnableBorders);
            this.Controls.Add(this.GameSpeedLabel);
            this.Controls.Add(this.GameSpeedBar);
            this.Controls.Add(this.FoodColorButton);
            this.Controls.Add(this.BodyColorButton);
            this.Controls.Add(this.HeadColorButton);
            this.Controls.Add(this.BorderColorButton);
            this.Controls.Add(this.MapHeightLabel);
            this.Controls.Add(this.MapHeightBar);
            this.Controls.Add(this.MapWidthLabel);
            this.Controls.Add(this.MapWidthBar);
            this.Controls.Add(this.InfoDisplay);
            this.Controls.Add(this.PixelSizeLabel);
            this.Controls.Add(this.PixelSizeBar);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ContinueButton);
            this.Name = "MenuForm";
            this.Text = "Змейка(меню)";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapHeightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newGameButton;
        private Button ContinueButton;
        private Button SettingsButton;
        private Button ExitButton;
        private PictureBox pictureBox1;
        private Button BackButton;
        private TrackBar PixelSizeBar;
        private Label PixelSizeLabel;
        private TextBox InfoDisplay;
        private Label MapWidthLabel;
        private TrackBar MapWidthBar;
        private Label MapHeightLabel;
        private TrackBar MapHeightBar;
        private ColorDialog colorDialog1;
        private Button BorderColorButton;
        private Button HeadColorButton;
        private Button BodyColorButton;
        private Button FoodColorButton;
        private TrackBar GameSpeedBar;
        private Label GameSpeedLabel;
        private CheckBox EnableBorders;
    }
}