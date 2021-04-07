using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02.ValueObjects
{
    public class NumeroHoja : IntValueObject
    {

        public NumeroHoja(int valor) : base(valor)
        {
            this.asegurarEsValorValido();
            this._valor = valor;
        }

        private void asegurarEsValorValido()
        {
            if (this._valor < 0)
            {
                throw new IndexOutOfRangeException("El valor ingresado no puede ser negativo");
            }
        }
    }
}
