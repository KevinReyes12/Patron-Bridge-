using System;
using Bridge.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    //Abstraccion (Abstraction)
    public abstract class Empresa
    {
        protected IPago elpago;
        protected PagoSueldoEmpresa id;
        //Constructor
        public Empresa(IPago pago) 
        {
            elpago = pago;
        }
        //Métodos
        public String Procesarpago() 
        {
            return elpago.ProcesarPago();
        }
        
        public String Pagar() 
        {
            return elpago.RealizarPago();
        }

        public void Asignarpago(IPago pago) 
        {
             elpago = pago;
        }

        public String RetrasarPago() 
        {
            return "El pago del salario ha sido retrasado";
        }

    }
}
