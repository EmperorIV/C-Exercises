using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Memoria
{
    class Numeros
    {
        private int[] nums;
        private String[] rutas;
        public int[] Nums {
            get { return this.nums; }
            set
            {
                this.nums = value;
            }
        }

        public Numeros()
        {
            nums = new int[16];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = (i+1);
                nums[i+8] = (i+1);
            }
            this.rutas = new string[8];
            for (int i = 0; i < rutas.Length; i++)
            {
                this.rutas[i] = "./Imagenes/" + (i+1) + ".png";
            }
        }
        
        public int darNumero()
        {
            List<int> a = this.nums.OfType<int>().ToList();
            Random b = new Random();
            int c =b.Next(0, this.nums.Length);
            int aux = a[c];
            a.RemoveAt(c);
            this.nums = a.ToArray();
            return aux;
        }
        public String conseguirImagen(int aux)
        {
            for (int i = 0; i <= rutas.Length; i++)
            {
                if (aux == i)
                {
                    return rutas[i-1];
                }

            }
            return "";
        }

    }
}
