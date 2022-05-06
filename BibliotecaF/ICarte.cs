using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProiectPIU.BibliotecaF {
    public interface ICarte {
        string Denumire { get; set; }
        string Autor { get; }
        int NumarPagini { get; set; }

        CategorieCarte Categoria { get; set; }
    }
}
