using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Negocio
{
    public class CN_registroMortalidad
    {
        private CD_registroMortalidadcs mortalidadGalpon = new CD_registroMortalidadcs();
        DataTable tabla = new DataTable();
        public DataTable mostrarMortalisdadGalpon()
        {

            tabla = mortalidadGalpon.mostrarRegistroMortalidad();
            return tabla;
        }
        public void insertarmortalidad(string fechaR, string cthm, string ctmm, string cod_registro)
        {
            mortalidadGalpon.InsertarMortalidad(Convert.ToDateTime(fechaR),Convert.ToInt32(cthm),Convert.ToInt32(ctmm),Convert.ToInt32(cod_registro));
        }
    }
}
