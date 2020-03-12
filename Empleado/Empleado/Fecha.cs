using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public struct Fecha
    {
        public int dia;
        public int mes;
        public int anno;

        public Fecha(int dia, int mes, int anno)
        {
            this.dia = dia;
            this.mes = mes;
            this.anno = anno;

        }
        public string ConvertirString()
        {
            return (dia + "/" + mes + "/" + anno);
        }
        
    }
}
