using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module6.Entities //Classe identidade significa que ela é uma classe e ao mesmo tempo, uma tabela no banco de dados
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CellphoneNumber { get; set; }
        public bool Active { get; set; }
    }
}