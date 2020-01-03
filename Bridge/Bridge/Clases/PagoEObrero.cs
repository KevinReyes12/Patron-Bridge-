using System;
using Bridge.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    //Este es el Implemento concreto 2 (ConcreteImplementator2)
    public class PagoEObrero:IPago
    {
        //Métodos del emplemento concreto 2
        public String ProcesarPago()//La implementacion del proceso de pago es independiente 
        {
            return "Procesando pago para empleado obrero";
        }
        public String RealizarPago()
        {
            return "Pago realizado con exito a un empleado obrero";
        }
    }
}
