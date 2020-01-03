using System;
using Bridge.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    //Este es el Implemento concreto 1 (ConcreteImplementator1)
    public class PagoEConsultoria:IPago
    {
        //Métodos del implemento concreto 1
        public String ProcesarPago() //La implementacion del proceso de pago es independiente 
        {
            return "Procesando pago para empleado de consultoría";
        }
        public String RealizarPago() 
        {
            return "Pago realizado con exito a un empleado de consultoría";
        }
    }
}
