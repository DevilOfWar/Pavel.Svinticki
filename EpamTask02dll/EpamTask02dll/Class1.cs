using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask02dll
{
    public class Vector
    {
        private double x, y, z;
        public double GetX
        {
            get
            {
                return this.x;
            }
        }
        public double GetY
        {
            get
            {
                return this.y;
            }
        }
        public double GetZ
        {
            get
            {
                return this.z;
            }
        }
        public void SetCoords(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public Vector(double x, double y, double z) : this()
        {
            this.SetCoords(x, y, z);
        }
    }
}
