using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveGame
{
    public partial class Setting : Form
    {
        bool Held_Bar = false;
        int[] Held_Pos = { 0, 0 };
        int[] Values = new int[3];

        public Setting()
        {
            InitializeComponent();
        }

        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BorderBar_MouseUp(object sender, MouseEventArgs e)
        {
            Held_Bar = false;
        }

        private void BorderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Held_Bar == true)
            {
                SetDesktopLocation(MousePosition.X - Held_Pos[0], MousePosition.Y - Held_Pos[1]);
            }
        }

        private void BorderBar_MouseDown(object sender, MouseEventArgs e)
        {
            Held_Bar = true;
            Held_Pos[0] = e.X;
            Held_Pos[1] = e.Y;
        }

        public int Passvalue1
        {
            get { return Values[0]; }
            set { Values[0] = value; }
        }

        public int Passvalue2
        {
            get { return Values[1]; }
            set { Values[1] = value; }
        }

        public int Passvalue3
        {
            get { return Values[2]; }
            set { Values[2] = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passvalue1 = Convert.ToInt32(textBox1.Text);
            Passvalue2 = Convert.ToInt32(textBox2.Text);
            Passvalue3 = Convert.ToInt32(textBox3.Text);
            Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = Passvalue1 + "";
            textBox2.Text = Passvalue2 + "";
            textBox3.Text = Passvalue3 + "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
