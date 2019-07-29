using System;
using System.Collections.Generic;
using System.Text;

namespace Aula66TipoReferencia {
    struct Point { //class troca pra struct

        public int x;
        public int y;

        public override string ToString() {
            return "( " + x + " , " + y + " )";
        }


    }
}
