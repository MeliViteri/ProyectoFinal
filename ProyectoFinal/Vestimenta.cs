using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    public class Vestimenta
    {
        //Datos para el comprador
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Cedula { set; get; }

        //Datos para la vestimenta del comprador
        public string TipodeVestimenta { set; get; }
        public string ColordeVestimenta { set; get; }
        public string MarcadeVestimenta { set; get; }
        public string TipodeTela { set; get; }
        public int PreciodeVestimenta { set; get; }

        
    }
}
