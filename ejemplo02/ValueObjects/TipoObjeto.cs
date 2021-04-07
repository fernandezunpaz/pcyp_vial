using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02.ValueObjects
{
    public class TipoObjeto : StringValueObject
    {
        public TipoObjeto(string valor) : base(valor)
        {
            asegurarValorValido();
            this._valor = valor;
        }

        private void asegurarValorValido()
        {
            if (this._valor != "Red Vial")
            {
                throw new IndexOutOfRangeException("El tipo de objeto ingresado no es válido");
            }
        }
    }
}
