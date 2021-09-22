using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Unit
{
    public int F_height, F_width;
    public int Acceleration;
    public int[] Vector = { 0, 0 };
    public Label Hero = new Label();
    int Move_Count = 0;
    public int Reduction = 20;
    public int Impact = 3;
    public Angle Facing = new Angle(1, 0);

    public Unit(int acceleration, int size, Color color, int[] Panel_Size)
    {
        this.Acceleration = acceleration;
        Hero.Size = new Size(size, size);
        Hero.BackColor = color;
        Hero.Padding = new Padding(0, 0, 0, 0);

        F_width = Panel_Size[0];
        F_height = Panel_Size[1];
    }

    public void Change_Vector(int Vector_X, int Vector_Y)
    {
        Vector[0] += Vector_X;
        Vector[1] += Vector_Y;
    }

    public void Slowing()
    {
        if (Vector[0] > 0)
        {
            Vector[0]-=1;
        }
        if (Vector[0] < 0)
        {
            Vector[0]+=1;
        }
        if (Vector[1] > 0)
        {
            Vector[1]-=1;
        }
        if (Vector[1] < 0)
        {
            Vector[1]+=1;
        }
    }

    public int Operate_Angle(int v1, int v2)
    {
        int result = 0;
        if (v2-v1 > 0)
        {
            result = 1;
        }
        else if (v2-v1 < 0)
        {
            result = -1;
        }
        else
        {
            result = 0;
        }

        return result;
    }
    public void Move()
    {
        int x = Hero.Location.X;
        int y = Hero.Location.Y;
        bool a = false, b = false, c = false, d = false;

        if (x + Hero.Width + Vector[0] > F_width)
        {
            Vector[0] = (Vector[0] / Impact) * -1;
            Hero.Location = new Point(F_width - 40, y);
            a = true;
        }
       if (x + Vector[0] < 0)
        {
            Vector[0] = (Vector[0] / Impact) * -1;
            Hero.Location = new Point(0, y);
            b = true;
        }
        if (y + Hero.Height + Vector[1] > F_height)
        {
            Vector[1] = (Vector[1] / Impact) * -1;
            Hero.Location = new Point(x, F_height-40);
            c = true;
        }
       if (y + Vector[1] < 0)
        {
            Vector[1] = (Vector[1] / Impact) * -1;
            Hero.Location = new Point(x, 0);
            d = true;
        }

        if(a == false|| b == false || c == false || d == false)
        {
            Hero.Location = new Point(x + Vector[0], y + Vector[1]);
            Move_Count++;
        }

        Facing.seta[0] = Operate_Angle(x, Hero.Location.X);
        Facing.seta[1] = Operate_Angle(y, Hero.Location.Y);

        if (Move_Count >= Reduction)
        {
            Slowing();
            Move_Count = 0;
        }
    }
}