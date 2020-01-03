using System;
using Bridge.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el objeto de Empresa 
            Empresa pagoSalario = new PagoSueldoEmpresa("1");
            //Hacemos el pago del sueldo a un empleado de consultoria
            Console.WriteLine(pagoSalario.Procesarpago());
            Console.WriteLine(pagoSalario.Pagar());
         
            //Ahora decidimos paraga el sueldo a un empleado obrero
            pagoSalario.Asignarpago(new PagoEObrero());
            Console.WriteLine(pagoSalario.Procesarpago());
            Console.WriteLine(pagoSalario.Pagar());
   
            ////Ahora Retrasaremos el pago de un empleado administraivo
            pagoSalario.Asignarpago(new PagoEAdministrativo());
            Console.WriteLine(pagoSalario.Procesarpago());
            Console.WriteLine(pagoSalario.RetrasarPago());
            pagoSalario.IdPago();
            Console.ReadKey();
        }
    }
}
