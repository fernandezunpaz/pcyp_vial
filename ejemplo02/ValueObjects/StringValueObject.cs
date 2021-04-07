using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02.ValueObjects
{
    public class StringValueObject
    {
        protected string _valor;

        public StringValueObject(string valor)
        {
            this._valor = valor;
        }

        public string valor()
        {
            return this._valor;
        }
    }
}
