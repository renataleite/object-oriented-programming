using System;
using System.Collections.Generic;
using System.Text;

namespace frequency_system
{
    class Faltas
    {
        public double percentage;

        public void faltar()
        {
            Disciplina d1;
            d1 = new Disciplina();
            d1.HorasAulas--;
        }
    }
}
