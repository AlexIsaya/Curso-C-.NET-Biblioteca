using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.modelo;

namespace Biblioteca.negocio
{
    class cnAlquiler
    {
        bool result = false;
        public bool GuardarAlquilerNegocio(Alquiler alquiler)
        {
            modelo.Alquiler al = new Alquiler();

            if (al.GuardarAlquiler(alquiler) == true)
            {
                result = true;
            }
            return result;
        }
    }
}
