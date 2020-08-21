using ChickPro_Interfaces.control;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.dao
{
    class AlimentoVitaminaDAO
    {
        private Conexion2 conexion = new Conexion2();
        //private AlimentoVitamina alimentoVitamina;
        int done = 0;


        public AlimentoVitaminaDAO(Conexion2 conexion)
        {
            this.conexion = conexion;
        }

        public int guardarAlimento(AlimentoVitamina alimentoVitamina)
        {
            try
            {
                Console.WriteLine("ENTRA AQUI");
                done = conexion.consultaLsitaDB("EXEC SP_RegistroAlimento '"+alimentoVitamina.getcodigoBarras()+ "','"+alimentoVitamina.getmarca()+ "'," + alimentoVitamina.getcantidadSacos()+ "," + alimentoVitamina.getpesoSaco()+";");
                Console.WriteLine("Este es el valor de done: " + done);
                Console.WriteLine("", done);
            }
            catch (Exception)
            {
            }
            return done;

        }

    }
}
