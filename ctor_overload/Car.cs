using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_
{
    class Car
    {
        public string _brand;
        public string _model;
        public int _nefah;

        public Car()
        {

        }

        /// <summary>
        /// with 3 arguments
        /// </summary>
        /// <param name="_brand"></param>
        /// <param name="_model"></param>
        /// <param name="_nefah"></param>
        public Car(string _brand, string _model, int _nefah)
        {
            this._brand = _brand;
            this._model = _model;
            this._nefah = _nefah;
        }

        /// <summary>
        /// with 2 arguments
        /// </summary>
        /// <param name="_model">aswesome model</param>
        /// <param name="_nefah"></param>
        public Car(string _model, int _nefah)
        {
            this._model = _model;
            this._nefah = _nefah;
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] {_brand} {_model} {_nefah}";
        }
    }
}
