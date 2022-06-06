using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface Negocio <M>
    {
        bool Agregar(M op); 

        bool Quitar (M op);

    }
}
