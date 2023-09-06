using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToaDo
    {
        private string _Ten;

        private float x ;
        private float y ;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo()
        {

        }
        public ToaDo(string Ten,float X, float Y)
        {
            this._Ten = Ten;
            this.x = X;
            this.y = Y;
        }
    }
}
