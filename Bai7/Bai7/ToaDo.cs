using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class ToaDo
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        private float _x;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        private float _y;

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public ToaDo(string ten, float x, float y)
        {
            this._ten = ten;
            this._x = x;
            this._y = y;
        }

        public ToaDo()
        {
            this._ten = "UnKnow";
            this._x = 0;
            this._y = 0;
        }

        public override string ToString()
        {
            return Ten + "(" + X + ", " + Y + ")";
        }
    }
}