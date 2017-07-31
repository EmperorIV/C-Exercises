using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector4
{
    class Vectores
    {
        private double[] vector1;
        private double[] vector2;
        private double[] vector3;

        public double[] Vector1 { get { return this.vector1; } set { this.vector1 = value; } }
        public double[] Vector2 { get { return this.vector2; } set { this.vector2 = value; } }
        public double[] Vector3 { get { return this.vector3; } set { this.vector3 = value; } }

        public void cargarVector3()
        {
            vector3 = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector2[i] + vector1[i];
            }
        }
    }
}
