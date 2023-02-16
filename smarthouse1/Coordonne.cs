using System;
using System.Collections.Generic;
using System.Text;

namespace smarthouse1
{
    class Coordonne
    {
        public int x;
        public int y;
        

        public Coordonne(int v1, int v2)
        {
            this.x = v1;
            this.y = v2;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

    }
}
