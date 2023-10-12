using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class GameFunctions
    {
        public List<Tile> tileList = new List<Tile>();
        public List<TileState> tileStates = new List<TileState>();
        public int numOfCol { get; set; }
        public int numOfRow { get; set; }
        public enum Difficulty
        {
            Easy,
            Medium,
            Hard
        }
        public enum TileState
        {
            Normal,
            Armed,
            Flagged

        }
        public struct Tile
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public Tile(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;

                this.width = width;
                this.height = height;
            }
        }
        public void CreateGrid(Difficulty choice, int windowWidth, int windowHeight)
        {
            int tileWidth = 0;
            int tileHeight = 0;

            switch (choice)
            {
                case Difficulty.Easy:
                    tileWidth = windowWidth / 16;
                    tileHeight = windowHeight / 16;
                    break;
                case Difficulty.Medium:
                    tileWidth = windowWidth / 24;
                    tileHeight = windowHeight / 24;
                    break;
                case Difficulty.Hard:
                    tileWidth = windowWidth / 32;
                    tileHeight = windowHeight / 32;
                    break;
            }

            // Create dimensions for each tile/button
            for (int x = 0; x < windowWidth; x += tileWidth)
            {
                for (int y = 0; y < windowHeight; y += tileHeight)
                {
                    tileList.Add(new Tile(x, y, tileWidth, tileHeight));
                    if (x == 0)
                        numOfCol++;
                }
                numOfRow++;
            }
        }
    }
}
