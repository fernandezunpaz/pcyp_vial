using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    public class Linea
    {
        private int numeroHoja;
        private string tipoObjeto;
        private int identificadorTramo;
        private string tipoCamino;
        private int longitud;

        public Linea(string linea)
        {
            String[] valores = linea.Split(',');
            Int32.TryParse(valores[0], out this.numeroHoja);
            this.tipoObjeto = valores[1];
            Int32.TryParse(valores[2], out this.identificadorTramo);
            this.tipoCamino = valores[3];
            Int32.TryParse(valores[4], out this.longitud);
        }

        public string imprimir()
        {
            return String.Format(
                "{0} | {1} | {2} | {3} | {4}",
                this.numeroHoja,
                this.tipoObjeto,
                this.identificadorTramo,
                this.tipoCamino,
                this.longitud
            );
        }
    }
}
