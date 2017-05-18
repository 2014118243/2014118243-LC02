using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118243_ENT.Repositorio
{
    interface IUnityOfWork : IDisposable
    {
        PantallaRepositorio Pantala { get; }
        CuentaRepositorio Cuenta { get; }
        TecladoRepositorio Teclado { get; }
      
        int SaveChanges();
    }
}
