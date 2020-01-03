using System;
using Bridge.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    //Esta clase es la abstraccion implemnto (ASbstractionImpl) 
    public class PagoSueldoEmpresa : Empresa 
    {
        private String nPago;//Numero de pago
        public PagoSueldoEmpresa(String idPago) : base(new PagoEConsultoria())//La clase PagoEConsultoria está por defecto
        {
            this.nPago = idPago;
        }
        public PagoSueldoEmpresa(String idPago,IPago pago) : base(pago)
        {
            this.nPago = idPago;
        }
       
    }
}
