using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Capa_Negocio
{
    public class CN_registroGalpon
    {
        private CD_registroGalpon registroGalpon = new CD_registroGalpon();
        DataTable tabla = new DataTable();
        public DataTable mostrarRegistroGalpon()
        {
           
            tabla = registroGalpon.mostrarRegistroGalpon();
            return tabla;
        }

        public void insertargalpon(string edad, string peso,  string ctm, string cth, string region, string fecha
            , string cg)
        {
            registroGalpon.InsertarRegistroGalpon(cg,Int32.Parse(edad),Convert.ToDouble(peso),Int32.Parse(ctm),Int32.Parse(cth), region,Convert.ToDateTime(fecha));
        }

        public void editargalpon(string edad, string peso, string ctm, string cth, string region, string fecha
            , string cg,string id)
        {
            registroGalpon.EditarRegistroGalpon(Int32.Parse(edad), Convert.ToDouble(peso), Int32.Parse(ctm), Int32.Parse(cth),region,Convert.ToDateTime(fecha), cg, Int32.Parse(id));
        }
    }
}
