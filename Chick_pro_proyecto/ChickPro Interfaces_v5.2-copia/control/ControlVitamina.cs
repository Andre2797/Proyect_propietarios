using ChickPro_Interfaces.dao;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.control
{
    class ControlVitamina
    {
        VitaminaDAO vitaminaDAO;

        public int guardarVitamina(Conexion2 conexion, String fecha, int edad, String tipo, String nombre, float dosis, String galpon, String justificacion)
        {
            Vitamina vitamina = new Vitamina(fecha, edad, tipo, nombre, dosis, galpon,justificacion);
            vitaminaDAO = new VitaminaDAO(new Conexion2());
            
            return vitaminaDAO.guardarVitamina(vitamina);
        }
    }
}
