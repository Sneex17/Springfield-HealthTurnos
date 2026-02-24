using System.Collections.Generic;
using System.Threading.Tasks;
using CEntidades;

namespace CInfraestructura
{
    public interface IPacientesRepository
    {
        Task<List<Character>> ObtenerPacientes();
    }
}
