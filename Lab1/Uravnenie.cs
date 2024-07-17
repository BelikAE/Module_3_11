using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    struct Uravnenie
    {
        float k;
        float b;

        public Uravnenie(float k, float b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root() 
        {
            if (k == 0) 
                return "Решения нет";
            float x = -b / k;
            return $"X равен: {x}";
        }

    }
}
