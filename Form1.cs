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
    public partial class Form1 : Form
    {

        static Angle Up = new Angle(0, 1);
        static Angle Down = new Angle(0, -1);
        static Angle Left = new Angle(-1, 0);
        static Angle Right = new Angle(1, 0);
        static int[] World_Size = { 0, 0 };
        bool Held_Bar = false;
        int[] Held_Pos = { 0, 0 };
        List<Bullet> Hero_Bullets = new List<Bullet>();
        List<Unit> Villain = new List<Unit>();
        int Magazine = 15;

        Unit main;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            World_Size[0] = Data_Panel.Width;
            World_Size[1] = Data_Panel.Height;

            timer1.Start();
            spawn.Start();
            main = new Unit(3, 20, Color.FromArgb(200, 255, 225), World_Size);
            Data_Panel.Controls.Add(main.Hero);
        }

        void Hero_Shut()
        {
            int speed = 10;
            int force = 5;
            Point pos = new Point(main.Hero.Location.X + main.Hero.Width / 4, main.Hero.Location.Y + main.Hero.Height / 4);
            Color color = Color.FromArgb(200, 255, 255);
            Hero_Bullets.Add(new Bullet(speed, main.Facing,force,pos,color));
            int Last = Hero_Bullets.Count - 1;
            Data_Panel.Controls.Add(Hero_Bullets[Last].bullet);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool is_Move = true;
            switch (e.KeyChar)
            {
                case 'a':
                    main.Change_Vector(-main.Acceleration, 0);
                    break;
                case 'd':
                    main.Change_Vector(main.Acceleration, 0);
                    break;
                case 'w':
                    main.Change_Vector(0, -main.Acceleration);
                    break;
                case 's':
                    main.Change_Vector(0, main.Acceleration);
                    break;
                case 'e':
                    main.Change_Vector(main.Acceleration, -main.Acceleration);
                    break;
                case 'q':
                    main.Change_Vector(-main.Acceleration, -main.Acceleration);
                    break;
                case 'c':
                    main.Change_Vector(main.Acceleration, main.Acceleration);
                    break;
                case 'z':
                    main.Change_Vector(-main.Acceleration, main.Acceleration);
                    break;
                default:
                    is_Move = false;
                    break;
            }
            if (is_Move == false)
            {
                switch (e.KeyChar)
                {
                    case 'p':
                        main.Hero.Location = new Point(50, 50);
                        main.Vector[0] = 0;
                        main.Vector[1] = 0;
                        break;
                    case 'k':
                        if (Hero_Bullets.Count <= Magazine)
                        {
                            Hero_Shut();
                        }
                        break;
                }
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> Del_List = new List<int>();
            main.Move();
            for(int i=0; i<Hero_Bullets.Count; i++)
            {
                Hero_Bullets[i].Move();
                if (Hero_Bullets[i].Move_Count >= Data_Panel.Width/5)
                {
                    Del_List.Add(i);
                }
            }
            for (int i = 0; i < Del_List.Count; i++)
            {
                Data_Panel.Controls.Remove(Hero_Bullets[Del_List[i]].bullet);

                Hero_Bullets.RemoveAt(Del_List[i]);
            }

                label1.Text = $"A : {main.Vector[0]}, {main.Vector[1]}";
            label2.Text = $"P : ({main.Hero.Location.X}, {main.Hero.Location.Y})";
            label4.Text = $"θ : ({main.Facing.seta[0]}, {main.Facing.seta[1]})";
            label5.Text = $"M : {Magazine+1-Hero_Bullets.Count}";

            for (int i = 0; i < Villain.Count; i++)
            {
                Villain[i].Move();
            }
        }

        private void BorderBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Data_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Setting Set = new Setting();
            Set.Passvalue1 = main.Acceleration;
            Set.Passvalue2 = main.Reduction;
            Set.Passvalue3 = main.Impact;
            Set.ShowDialog();
            main.Acceleration = Set.Passvalue1;
            main.Reduction = Set.Passvalue2;
            main.Impact = Set.Passvalue3;
        }

        private void spawn_Tick(object sender, EventArgs e)
        {
            int Max = 5;
            Random r = new Random();

            if (Villain.Count < Max)
            {
                int size = 15;
                Villain.Add(new Unit(10, size, Color.FromArgb(255, 200, 200),World_Size));
                int Last = Villain.Count - 1;
                Data_Panel.Controls.Add(Villain[Last].Hero);

                Villain[Last].Hero.Location = new Point(r.Next(World_Size[0] - size), r.Next(World_Size[1] - size));
                Villain[Last].Reduction = 7;
                Villain[Last].Impact = 1;
            }

            for (int i = 0; i < Villain.Count; i++)
            {
                Villain[i].Move();
                int a = 1, b = 1;

                if (r.Next(6) >= 3)
                {
                    a = -1;
                }
                if (r.Next(6) >= 3)
                {
                    b = -1;
                }

                int speed = Villain[i].Acceleration;
                Villain[i].Change_Vector(speed * a, speed * b);;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }//
}//
