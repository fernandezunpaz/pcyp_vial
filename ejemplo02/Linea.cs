using ejemplo02.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    public class Linea
    {
        private NumeroHoja numeroHoja;
        private TipoObjeto tipoObjeto;
        private int identificadorTramo;
        private string tipoCamino;
        private int longitud;

        public Linea(string linea)
        {
            int numeroHoja;

            String[] valores = linea.Split(',');

            Int32.TryParse(valores[0], out numeroHoja);
            this.numeroHoja = new NumeroHoja(numeroHoja);

            this.tipoObjeto = new TipoObjeto(valores[1]);
            Int32.TryParse(valores[2], out this.identificadorTramo);
            this.tipoCamino = valores[3];
            Int32.TryParse(valores[4], out this.longitud);
        }

        public string imprimir()
        {
            return String.Format(
                "{0} | {1} | {2} | {3} | {4}",
                this.numeroHoja.toString(),
                this.tipoObjeto.valor(),
                this.identificadorTramo,
                this.tipoCamino,
                this.longitud
            );
        }
    }
}
