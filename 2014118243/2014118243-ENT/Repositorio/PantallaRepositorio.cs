using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014118243;

namespace _2014118243_ENT.Repositorio
{
    interface PantallaRepositorio : IRepositorio<Pantalla>
    {
        IEnumerable<Pantalla> GetPantallasWithMovies(string nombre, int dni);
        IEnumerable<Pantalla> GetPantallaByClassification(Pantalla classification);

    }
}
