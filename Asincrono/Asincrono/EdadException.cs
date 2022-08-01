using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono
{
    public class EdadException: Exception
    {
        public int Edad { get; private set; }

        public EdadException(int _edad):base("El registro de edad " + _edad + " está fuera de rango")
        {
            Edad = _edad;
        }
    }
}
    
