using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMinesweeper
{
    public partial class FormGameSize : Form
    {
        Action<int, int, int> f;
        public FormGameSize()
        {
            InitializeComponent();
        }
        public FormGameSize setF(Action<int, int, int> f)
        {
            this.f = f;
            return this;
        }
        private void FormGameSize_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f((int)numericUpDownX.Value, (int)numericUpDownY.Value, (int)numericUpDownBomb.Value);
            Close();
        }
    }
}
