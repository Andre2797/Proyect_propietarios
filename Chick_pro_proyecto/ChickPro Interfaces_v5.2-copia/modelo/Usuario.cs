using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.modelo
{
    
        class Usuario : Persona
        {
            private int idUsuario;
            private String nombreUsuario;
            private String contraseniaUsuario;
            private String cargoUsuario;
            private float salarioUsuario;

            public int getIdUsuario()
            {
                return idUsuario;
            }

            public void setIdUsuario(int idUsuario)
            {
                this.idUsuario = idUsuario;
            }

            public String getNombreUsuario()
            {
                return nombreUsuario;
            }

            public void setNombreUsuario(String nombreUsuario)
            {
                this.nombreUsuario = nombreUsuario;
            }

            public String getContraseniaUsuario()
            {
                return contraseniaUsuario;
            }

            public void setContraseniaUsuario(String contraseniaUsuario)
            {
                this.contraseniaUsuario = contraseniaUsuario;
            }

            public String getCargoUsuario()
            {
                return cargoUsuario;
            }

            public void setCargoUsuario(String cargoUsuario)
            {
                this.cargoUsuario = cargoUsuario;
            }

            public float getSalarioUsuario()
            {
                return salarioUsuario;
            }

            public void setSalarioUsuario(float salarioUsuario)
            {
                this.salarioUsuario = salarioUsuario;
            }

            public Usuario(int idUsuario, String nombreUsuario, String contraseniaUsuario, String cargoUsuario, float salarioUsuario)
            {
                this.idUsuario = idUsuario;
                this.nombreUsuario = nombreUsuario;
                this.contraseniaUsuario = contraseniaUsuario;
                this.cargoUsuario = cargoUsuario;
                this.salarioUsuario = salarioUsuario;
            }

            public Usuario()
            {
            }


        }
    
}
