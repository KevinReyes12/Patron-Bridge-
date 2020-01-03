using System;
using Bridge.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    //Este es el Implemento concreto 3 (ConcreteImplementator3)
    public class PagoEAdministrativo:IPago
    {
        //Métodos demplemento concreto 3
        public String ProcesarPago()//La implementacion del proceso de pago es independiente 
        {
            return "Procesando pago para empleado administrativo";
        }
        public String RealizarPago()
        {
            return "Pago realizado con exito a un empleado administrativo";
        }
    }
}
