using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.modelo
{
    class AlimentoVitamina
    {
        private String codigoBarras;
        private String marca;
        private int cantidadSacos;
        private float pesoSaco;

       

        

        public String getcodigoBarras()
        {
            return codigoBarras;
        }

        public void setcodigoBarras(String codigoBarras)
        {
            this.codigoBarras = codigoBarras;
        }

        public String getmarca()
        {
            return marca;
        }

        public void setmarca(String marca)
        {
            this.marca = marca;
        }

        public int getcantidadSacos()
        {
            return cantidadSacos;
        }

        public void setcantidadSacos(int cantidadSacos)
        {
            this.cantidadSacos = cantidadSacos;
        }

        public float getpesoSaco()
        {
            return pesoSaco;
        }

        public void setpesoSaco(float pesoSaco)
        {
            this.pesoSaco = pesoSaco;
        }

        public AlimentoVitamina(String codigoBarras, String marca, int cantidadSacos, float pesoSaco)
        {
            this.codigoBarras = codigoBarras;
            this.marca = marca;
            this.cantidadSacos = cantidadSacos;
            this.pesoSaco = pesoSaco;
        }

        public AlimentoVitamina()
        {

        }
    }
}
