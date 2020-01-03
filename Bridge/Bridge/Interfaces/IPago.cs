using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Interfaces
{
    //Implemento (Implementor)
    public interface IPago
    {
        string ProcesarPago();
        string RealizarPago();
    }
}
