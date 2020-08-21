using ChickPro_Interfaces.control;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.dao
{
    class VitaminaDAO
    {
        private Conexion2 conexion = new Conexion2();
        int done = 0;

        public VitaminaDAO(Conexion2 conexion)
        {
            this.conexion = conexion;
        }

        public int guardarVitamina(Vitamina vitamina)
        {
            try
            {
               
                done = conexion.consultaLsitaDB("EXEC SP_RegistroVitamina " +
                    "'"+vitamina.getfechaSuministro()+"',"+vitamina.getedad()+",'"+vitamina.gettipo()+"', '"+vitamina.getnombreVitamina()+"', "+vitamina.getdosis()+", ' " + vitamina.getJustificacion() + " ',  '"+vitamina.getgalpon()+"'");
               
                
            }
            catch (Exception)
            {
            }
            return done;

        }
    }
}
