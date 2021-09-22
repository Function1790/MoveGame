using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Angle
{
    public int[] seta = new int[2];
    
    public Angle(int x, int y)
    {
        seta[0] = x;
        seta[1] = y;
    }

    public void Set(int x, int y)
    {
        seta[0] = x;
        seta[1] = y;
    }
}