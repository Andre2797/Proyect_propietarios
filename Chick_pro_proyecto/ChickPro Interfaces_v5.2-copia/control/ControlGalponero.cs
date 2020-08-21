using ChickPro_Interfaces.dao;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.control
{
    class ControlGalponero
    {
        GalponeroDAO galponeroDAO;

        public int guardarGalponero(Conexion2 conexion, String cedula, String priNombre, String priApellido, String direccion, String telefono, char sexo, String rendimientoGalponeor, String fechaInicioLboral, String estado, String creacionidGalponasig)
        {
            Galponero g = new Galponero(cedula, priNombre, priApellido, direccion, telefono, sexo, rendimientoGalponeor, fechaInicioLboral, estado, creacionidGalponasig);
            galponeroDAO = new GalponeroDAO(new Conexion2());
            Console.WriteLine("" + galponeroDAO.guardarGlponero(g));
            return galponeroDAO.guardarGlponero(g);

        }

        public Galponero buscarGalponero(Conexion2 conexion, String cod)
        {
            galponeroDAO = new GalponeroDAO(conexion);
            return galponeroDAO.buscarGalponero(cod);
        }
    }
}
