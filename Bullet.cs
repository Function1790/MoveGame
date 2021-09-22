using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hero_Color: (200, 255, 255)
class Bullet
{
    public int Force;
    public int[] Vector = new int[2];
    public Label bullet = new Label();
    public int Move_Count = 0;

    public Bullet(int Speed, Angle angle, int Force, Point pos,Color color)
    {
        Vector[0] = Speed * angle.seta[0];
        Vector[1] = Speed * angle.seta[1];

        this.Force = Force;

        bullet.Size = new Size(10, 10);
        bullet.Location = pos;
        bullet.BackColor = color;
    }

    public void Move()
    {
        Move_Count++;
        bullet.Location = new Point(bullet.Location.X + Vector[0], bullet.Location.Y + Vector[1]);
    }
}