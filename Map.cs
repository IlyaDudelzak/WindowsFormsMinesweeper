using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Xml;
using System.Web.UI.WebControls;

namespace WindowsFormsMinesweeper
{
    class sdfjkstgrhdks
    {
        string borderHorisontal, BorderHorisontalWide, BorderVertical, BorderVerticalWide, closed;
    }
    struct dhtsfzeirfjg
    {
        Graphics graph;
        public void fill()
        {
        }
    };

    internal class Cell
    {
        public int BombsAround;
        public bool IsBomb, IsOpened;
        private Map InMap;
        public int X, Y;
        public Cell(Map inMap, int x, int y)
        {
            InMap = inMap;
            this.X = x;
            this.Y = y;
        }
        public void accord()
        {
            if (IsOpened)
            {
                for (int x = X - 1; x < X + 2; x++)
                {
                    for (int y = Y - 1; y < Y + 2; y++)
                    {
                        if (x == X && y == Y) continue;
                        if(x < 0 || y < 0 || x > InMap.SizeX || y > InMap.SizeY) continue;
                        if (x != 0)
                        {
                            if (y != 0 && !InMap.cells[x - 1, y - 1].IsBomb) InMap.cells[x - 1, y - 1].BombsAround++;
                            if (y != InMap.SizeX && !InMap.cells[x - 1, y + 1].IsBomb) InMap.cells[x - 1, y + 1].BombsAround++;
                            if (!InMap.cells[x - 1, y].IsBomb) InMap.cells[x - 1, y].BombsAround++;
                        }
                        if (x != InMap.SizeX)
                        {
                            if (!InMap.cells[x + 1, y].IsBomb) InMap.cells[x + 1, y].BombsAround++;
                            if (y != InMap.SizeY && !InMap.cells[x + 1, y + 1].IsBomb) InMap.cells[x + 1, y + 1].BombsAround++;
                            if (y != 0 && !InMap.cells[x + 1, y - 1].IsBomb) InMap.cells[x + 1, y - 1].BombsAround++;
                        }
                        if (y != InMap.SizeY && !InMap.cells[x, y + 1].IsBomb) InMap.cells[x, y + 1].BombsAround++;
                        if (y != 0 && !InMap.cells[x, y - 1].IsBomb) InMap.cells[x, y - 1].BombsAround++;
                    }
                }
            }
        }
        public void open()
        {
            IsOpened = true;
        }

    }
    internal class Map
    {
        private void nop() { }
        public Cell[,] cells;
        public int BombsIn, SizeX, SizeY;
        internal void alert(string a)
        {
            MessageBox.Show(a, "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Map(int X, int Y, int b)
        {
            alert("map genereted");
            Random rnd = new Random();
            this.cells = new Cell[X, Y];
            this.SizeX = X;
            this.SizeY = Y;
            this.BombsIn = b;
            for (int i = 0; i < this.SizeX; i++)
                for (int j = 0; j < this.SizeY; j++)
                    cells[i, j] = new Cell(this, i, j);

            for (int i = 0; i < this.BombsIn; i++)
            {
            BombBegGen:
                int x = rnd.Next() % this.SizeX, y = rnd.Next() % this.SizeY;
                if (cells[x, y].IsBomb) goto BombBegGen;
                cells[x, y].IsBomb = true;
                for(int k = x - 1; k < x + 2; k++)
                    for(int m = y - 1; m < y + 2; m++)
                    {
                        if (k == x || m == y || k < 0 || k >= this.SizeX || m < 0 || m >= this.SizeY) continue;
                        else cells[k, m].BombsAround++;
                    }
            }
        }
        public Map(int X, int Y, Cell[,] cells)
        {
            alert("map loaded");
            this.cells = cells;
            this.SizeX = X;
            this.SizeY = Y;
            this.BombsIn = 0;
//            for (int i = 0; i < this.SizeX; i++)
//                for (int j = 0; j < this.SizeY; j++)
//                    if (this.cells[i, j].IsBomb) BombsIn++;
        }
        public void fromDataSet(DataSet a)
        {
            
        }
        public static Map fromFile()
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Minesweeper maps (*.msm)|*.msm|All files (*.*)|*.*";
            fd.DefaultExt = ".msm";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                int X = int.Parse(doc.DocumentElement.Attributes["width"].Value);
                int Y = int.Parse(doc.DocumentElement.Attributes["height"].Value);
                Cell[,] cells = new Cell[X, Y];
                foreach (XmlNode node in doc.DocumentElement.FirstChild.ChildNodes)
                {
                    int x = int.Parse(node.Attributes["x"].InnerText);
                    int y = int.Parse(node.Attributes["y"].InnerText);
                    cells[x, y].IsOpened = bool.Parse(node.Attributes["opened"].InnerText);
                    cells[x, y].IsBomb = bool.Parse(node.Attributes["isBomb"].InnerText);
                    cells[x, y].BombsAround = int.Parse(node.Attributes["BombsAround"].InnerText);
                };
                Map mp = new Map(X, Y, cells);
                return mp;
            }
            return null;
        }
        public void toFile()
        {
            StreamWriter st;
            var fd = new SaveFileDialog();
            fd.Filter = "Minesweeper maps (*.msm)|*.msm|All files (*.*)|*.*";
            fd.DefaultExt = ".msm";
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                st = new StreamWriter(fd.FileName);
                string map = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<!DOCTYPE msm>\r\n<map width=\"" + SizeX + "\" height=\"" + SizeY + "\" bombsRemain=\"" + BombsIn + "\">\n";
                for (int j = 0; j < SizeX; j++)
                {
                    for (int i = 0; i < SizeY; i++)
                    {
                        map += "    <cell x=\"" + j + "\" y=\"" + i + "\" opened=\"" + IsOpened(j, i) + "\" isbomb=\"" + IsBomb(j, i) + "\" BombsAround=\"" + BombsAround(j, i) + "\" />\n";
                    }
                }
                map += "</map>";
                st.Write(map);
                st.Close(); //remember to close the file again.
                st.Dispose(); //remember to dispose it from the memory.
            }
        }
        public void accord(int x, int y)
        {
            cells[x, y].accord();
        }
        public bool IsBomb(int x, int y)
        {
            return cells[x, y].IsBomb;
        }
        public bool IsOpened(int x, int y)
        {
            return cells[x, y].IsOpened;
        }
        public int BombsAround(int x, int y)
        {
            return cells[x, y].BombsAround;
        }
    }
    internal class Indicator
    {

    }
}
