using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Capa_Datos;


namespace Capa_Negocio
{
    public class CN_Envio
    {

        private CD_Envio envioPollos = new CD_Envio();

        public DataTable MostrarEnvio() {
            DataTable tabla = new DataTable();
            tabla = envioPollos.MostrarEnvio();
            return tabla;
        }

        public void insertarEnvioPollos(string fecha, string chofer, string cantJaulas)
        {
            envioPollos.insertarEnvio(Convert.ToDateTime(fecha),chofer,Int32.Parse(cantJaulas));
        }

        public DataTable MostrarDetalle()
        {
            DataTable tabla = new DataTable();
            tabla = envioPollos.mostrarDetalle();
            return tabla;
        }

        public void insertarDetallesEnvio(string codGalpon,string cantHembras, string cantMachos, string pesoPromedio, string codEnvio )
        {
            envioPollos.insertarDetalle(Int32.Parse(codGalpon),Int32.Parse(cantHembras), Int32.Parse(cantMachos),Double.Parse(pesoPromedio),Int32.Parse(codEnvio));
        }
    }
}
