using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.modelo
{
    public class Galponero : Persona
    {
        private String rendimientoGalponeor;
        private String fechaInicioLboral;
        private String estado;
        private String creacionidGalponasig;

        public String getRendimientoGalponeor()
        {
            return rendimientoGalponeor;
        }

        public void setRendimientoGalponeor(String rendimientoGalponeor)
        {
            this.rendimientoGalponeor = rendimientoGalponeor;
        }

        public String getFechaInicioLboral()
        {
            return fechaInicioLboral;
        }

        public void setFechaInicioLboral(String fechaInicioLboral)
        {
            this.fechaInicioLboral = fechaInicioLboral;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public String getCreacionidGalponasig()
        {
            return creacionidGalponasig;
        }

        public void setCreacionidGalponasig(String creacionidGalponasig)
        {
            this.creacionidGalponasig = creacionidGalponasig;
        }

        public Galponero(String cedula, String priNombre, String priApellido, String direccion, String telefono, char sexo, String rendimientoGalponeor, String fechaInicioLboral, String estado, String creacionidGalponasig)
            : base(cedula, priNombre, priApellido, direccion, telefono, sexo)
        {
            this.rendimientoGalponeor = rendimientoGalponeor;
            this.fechaInicioLboral = fechaInicioLboral;
            this.estado = estado;
            this.creacionidGalponasig = creacionidGalponasig;
        }

        public Galponero()
        {
        }


    }

}
