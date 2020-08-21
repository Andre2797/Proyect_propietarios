using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.modelo
{
    class Vitamina
    {
        private String fechaSuministro;
        private int edad;
        private String tipo;
        private String nombreVitamina;
        private float dosis;
        private String galpon;
        private String justificacion;


        public String getJustificacion()
        {
            return justificacion;
        }

        public void setJustificacion(String justificacion)
        {
            this.justificacion = justificacion;
        }



        public String getfechaSuministro()
        {
            return fechaSuministro;
        }

        public void setfechaSuministro(String fechaSuministro)
        {
            this.fechaSuministro = fechaSuministro;
        }

        public int getedad()
        {
            return edad;
        }

        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public String gettipo()
        {
            return tipo;
        }

        public void settipo(String tipo)
        {
            this.tipo = tipo;
        }

        public String getnombreVitamina()
        {
            return nombreVitamina;
        }

        public void setnombreVitamina(String nombreVitamina)
        {
            this.nombreVitamina = nombreVitamina;
        }

        public float getdosis()
        {
            return dosis;
        }

        public void setdosis(float dosis)
        {
            this.dosis = dosis;
        }

        public String getgalpon()
        {
            return galpon;
        }

        public void setgalpon(String galpon)
        {
            this.galpon = galpon;
        }

        public Vitamina(String fechaSuministro, int edad, String tipo, String nombreVitamina, float dosis, String galpon, String justificacion)
        {
            this.fechaSuministro = fechaSuministro;
            this.edad = edad;
            this.tipo = tipo;
            this.nombreVitamina = nombreVitamina;
            this.dosis = dosis;
            this.galpon = galpon;
            this.justificacion = justificacion;
        }

        public Vitamina()
        {

        }

    }
}
