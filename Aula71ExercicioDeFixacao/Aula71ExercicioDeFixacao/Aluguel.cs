using System;
using System.Collections.Generic;
using System.Text;

namespace Aula71ExercicioDeFixacao {
    class Aluguel {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() {
            return Room
                + ": "
                + Name
                + ", "
                + Email;
        }


    }


}
