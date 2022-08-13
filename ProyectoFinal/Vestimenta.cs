﻿using System;
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

        //constructores
        public Vestimenta()
        {
        }

        public Vestimenta(string nombre, string apellido, string cedula, string tipodeVestimenta, 
            string colordeVestimenta, string marcadeVestimenta, string tipodeTela, int preciodeVestimenta)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            TipodeVestimenta = tipodeVestimenta;
            ColordeVestimenta = colordeVestimenta;
            MarcadeVestimenta = marcadeVestimenta;
            TipodeTela = tipodeTela;
            PreciodeVestimenta = preciodeVestimenta;
        }
        
    }
}
