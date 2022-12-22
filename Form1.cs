using HarfBuzzSharp;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.ImageGenerator;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Web.UI.WebControls.WebParts;

namespace WindowsFormsMinesweeper
{

    public partial class Form1 : Form
    {
        private Config cnf;
        private ImgResoursePack resouses;
        private Map map;
        public Form1()
        {
            InitializeComponent();
        }
        internal void alert(string a)
        {
            MessageBox.Show(a, "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal void alertD(string a)
        {
#if DEBUG
            MessageBox.Show(a, "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
        }
        private void load_delauf()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.json"))
            {
                load_delauf();
            }
        }
        private void OpenMap(object sender, EventArgs e)
        {
            map = Map.fromFile();
        }
        private void OpenReplay(object sender, EventArgs e)
        {
            var svgConv = new HtmlToImageConverter();
            svgConv.Width = 200;
            svgConv.Height = 200;
            var svg = svgConv.GenerateImageFromFile("D:\\Disk-U\\Ilya\\Documents\\Education\\C#\\WindowsFormsMinesweeper\\img\\face.svg", ImageFormat.Jpeg);
            var stream = new MemoryStream(svg, 0, svg.Length);
            var img = new Bitmap(Image.FromStream(stream));
            this.CreateGraphics().DrawImage(img, new PointF(50, 50));
        }
        private void SaveMap(object sender, EventArgs e)
        {
            map.toFile();
        }
        private void SaveReplay(object sender, EventArgs e)
        {

        }

        private void GameSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GameSizeComboBox.SelectedIndex)
            {
                case 0:
                    map = new Map(9, 9, 10);
                    break;
                case 1:
                    map = new Map(16, 16, 40);
                    break;
                case 2:
                    map = new Map(30, 16, 99);
                    break;
                case 3:
                    void f(int x, int y, int b)
                    {
                        this.map = new Map(x, y, b);
                    }
                    new FormGameSize().setF(f).ShowDialog();
                    break;
            }
        }

        private void ChooseResoursepack(object sender, EventArgs e)
        {

            resouses = ResoursePack.readFromFile("Resoursepacks/delauf.msrp");
        }

        private void еуыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < map.SizeX; i++) 
            {
                for (int j = 0; j < map.SizeY; j++)
                {
                    if (map.cells[i, j].IsBomb) Debug.Write("X");
                    else Debug.Write(map.cells[i, j].BombsAround);
                }
                Debug.Write("\n");
            }
        }
    }
    internal class Config {
        public int GSI, GSX, GSY, GSB;
        public string RPP;
        public StreamWriter st;
        public Config()
        {

        }
    }
    internal class ImgResoursePack
    {
        public Bitmap face, face_press, face_win, face_dead;
        public Bitmap d_, d0, d1, d2, d3, d4, d5, d6, d7, d8, d9;
        public Bitmap closed, closed_flag, closeg_free;
        public Bitmap t0, t1, t2, t3, t4, t5, t6, t7, t8;
        public Bitmap bottom_left, bottom_right, up_left, up_right, horizontal, vertical;
        public Bitmap start, flag, flag_correct, flag_wrong;
        public Bitmap mine, mine_wrong, nums_background;
    };
    internal class ResoursePack
    {
        private string face, face_press, face_win, face_dead;
        private string d_, d0, d1, d2, d3, d4, d5, d6, d7, d8, d9;
        private string closed, closed_flag, closeg_free;
        private string t0, t1, t2, t3, t4, t5, t6, t7, t8;
        private string bottom_left, bottom_right, up_left, up_right, horizontal, vertical;
        private string start, flag, flag_correct, flag_wrong;
        private string mine, mine_wrong, nums_background;
        public static ImgResoursePack readFromFile(string path)
        {
            ZipArchive res = ZipFile.Open(path, ZipArchiveMode.Read);
            int i = 0;
            ResoursePack ros = JsonSerializer.Deserialize<ResoursePack>(new StreamReader(res.GetEntry("config.json").Open()).ReadToEnd());
            ImgResoursePack rs = new ImgResoursePack();
            {
                rs.bottom_left = toImg(new StreamReader(res.GetEntry(ros.bottom_left).Open()).ReadToEnd());
            }
            return rs;
        }
        public static Bitmap toImg(string a)
        {
            var svgConv = new HtmlToImageConverter();
            var xml = new XmlDocument();
            xml.LoadXml(a);
            string str = xml.DocumentElement.FirstChild["viewBox"].Value;
            char[] chars = str.ToCharArray();
            int b = 0, c = 0, d = 0, e = 0, f, i = 0;
            while (int.TryParse(chars[i].ToString(), out f))
            {
                b = (b * 10) + f;
                i++;
            }
            i++;
            while (int.TryParse(chars[i].ToString(), out f))
            {
                c = (b * 10) + f;
                i++;
            }
            i++;
            while (int.TryParse(chars[i].ToString(), out f))
            {
                d = (b * 10) + f;
                i++;
            }
            i++;
            while (!(!int.TryParse(chars[i].ToString(), out f) || i + 1 == chars.Length))
            {
                e = (b * 10) + f;
                i++;
            }
            i++;
            svgConv.Width = d - b;
            svgConv.Height = e - c;
            var svg = svgConv.GenerateImage(a, "svg");
            var stream = new MemoryStream(svg, 0, svg.Length);
            var bmp = new Bitmap(Image.FromStream(stream));
            return bmp;
        }
    };
}
