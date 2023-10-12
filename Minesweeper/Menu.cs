using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class menuForm : Form
    {
        GameFunctions game = new GameFunctions();
        GameFunctions.Difficulty difficulty = new GameFunctions.Difficulty();
        public menuForm()
        {
            InitializeComponent();
        }

        private void easyPicked(object sender, EventArgs e)
        {
            difficulty = GameFunctions.Difficulty.Easy;
            ExecuteGame();
        }

        private void mediumPicked(object sender, EventArgs e)
        {
            difficulty = GameFunctions.Difficulty.Medium;
            ExecuteGame();
        }

        private void hardPicked(object sender, EventArgs e)
        {
            difficulty = GameFunctions.Difficulty.Hard;
            ExecuteGame();
        }

        private void ExecuteGame()
        {
            // Declare
            int newFormWidth = 0;
            int newFormHeight = 0;

            int widthErrorRoom = 15;
            int heightErrorRoom = 39;

            // Initialize
            switch (difficulty)
            {
                case GameFunctions.Difficulty.Easy:
                    newFormWidth = 400 + widthErrorRoom;
                    newFormHeight = 400 + heightErrorRoom;
                    break;
                case GameFunctions.Difficulty.Medium:
                    newFormWidth = 600 + widthErrorRoom;
                    newFormHeight = 600 + heightErrorRoom;
                    break;
                case GameFunctions.Difficulty.Hard:
                    newFormWidth = 800 + widthErrorRoom;
                    newFormHeight = 800 + heightErrorRoom;
                    break;
            }

        // Clear the list
        game.tileList.Clear();

            // Create new form and hide menu
            Form newForm = new Form();
            this.Hide();

            // Size the form
            newForm.Size = new Size(newFormWidth, newFormHeight);
            newForm.MinimumSize = new Size(newFormWidth, newFormHeight);
            newForm.MaximumSize = new Size(newFormWidth, newFormHeight);

            // Basic UI
            newForm.Text = "Minesweeper - " + difficulty.ToString();

            // Get actual width and height
            int actualWidth = newForm.Size.Width - widthErrorRoom;
            int actualHeight = newForm.Size.Height - heightErrorRoom;

            // Create the list
            game.CreateGrid(difficulty, actualWidth, actualHeight);

            newForm.Activate();

            // Create buttons for each tile
            int numOfBtn = 0;
            foreach (GameFunctions.Tile Tile in game.tileList)
            {
                Button newBtn = new Button();
                newBtn.Parent = newForm;
                newBtn.Location = new Point(Tile.x, Tile.y);
                newBtn.Size = new Size(Tile.width, Tile.height);
                newBtn.Name = numOfBtn.ToString();
                newBtn.FlatStyle = FlatStyle.Popup;
                numOfBtn++;
                newBtn.Click += ClickedTile;
                newForm.Controls.Add(newBtn);
                newBtn.Show();
            }

            // Format new form before shown
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.MaximizeBox = false;
            newForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            newForm.ShowDialog();

            // Show after dialog done aka game finished
            this.Show();
        }

        private void ClickedTile(object sender, EventArgs e)
        {
            Button pressedBtn = sender as Button;

            if (!int.TryParse(pressedBtn.Name, out int btnNum))
                return;

            pressedBtn.Enabled = false;
            pressedBtn.BackColor = Color.Gray;

        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
