using ChickPro_Interfaces.dao;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.control
{
    class ControlAlimento
    {
        AlimentoVitaminaDAO alimentoVitaminaDAO;

        public int guardarAlimento(Conexion2 conexion, String codigoBarras, String marca, int cantidadSacos, float pesoSacos)
        {
            AlimentoVitamina alimento = new AlimentoVitamina(codigoBarras, marca, cantidadSacos, pesoSacos);
            alimentoVitaminaDAO = new AlimentoVitaminaDAO(new Conexion2());
            Console.WriteLine("" + alimentoVitaminaDAO.guardarAlimento(alimento));
            return alimentoVitaminaDAO.guardarAlimento(alimento);
        }
    }
}
