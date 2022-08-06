using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    public class Vestimentas
    {
        public List<Vestimenta> Vestimentas1 = new List<Vestimenta>();
        public Vestimentas()
        {
            Vestimentas1 = new List<Vestimenta>();
        }
        
        //Listamos los datos
        public void Agregar(Vestimenta vestimentas)
        {
            Vestimentas1.Add(vestimentas);
        }
        //Nombre del comprador que contenga alguna cadena
        public List<Vestimenta> Cadena(string cadena)
        {
            List<Vestimenta> aux = new List<Vestimenta>();
            foreach (Vestimenta vestimenta in Vestimentas1)
            {
                if (vestimenta.Nombre.Contains(cadena))
                {
                    aux.Add(vestimenta);
                }
            }
            return aux;
        }
        public List<Vestimenta> PreciodeVestimenta()
        {
            List<Vestimenta> aux = new List<Vestimenta>();
            foreach (Vestimenta vestimenta in Vestimentas1)
            {
                if (vestimenta.PreciodeVestimenta > 50)
                {
                    aux.Add(vestimenta);
                }
            }
            return aux;
        }
    }
}
