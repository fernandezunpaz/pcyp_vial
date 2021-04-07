using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02.ValueObjects
{
    public class IntValueObject
    {
        protected int _valor;

        public IntValueObject(int valor)
        {
            this._valor = valor;
        }

        public int valor()
        {
            return this._valor;
        }

        public string toString()
        {
            return this._valor.ToString();
        }
    }
}
