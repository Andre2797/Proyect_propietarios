using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.modelo
{
    public class Persona
    {
        private String cedula;
        private String priNombre;
        private String priApellido;
        private String direccion;
        private String telefono;
        private char sexo;

        public String getCedula()
        {
            return cedula;
        }

        public void setCedula(String cedula)
        {
            this.cedula = cedula;
        }

        public String getPriNombre()
        {
            return priNombre;
        }

        public void setPriNombre(String priNombre)
        {
            this.priNombre = priNombre;
        }

        public String getPriApellido()
        {
            return priApellido;
        }

        public void setPriApellido(String priApellido)
        {
            this.priApellido = priApellido;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public char getSexo()
        {
            return sexo;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public Persona(String cedula, String priNombre, String priApellido, String direccion, String telefono, char sexo)
        {
            this.cedula = cedula;
            this.priNombre = priNombre;
            this.priApellido = priApellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.sexo = sexo;
        }
        public Persona()
        {
        }

    }
}

