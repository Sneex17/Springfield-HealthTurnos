using CEntidades;
using CInfraestructura;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CNegocio
{
    public class PacienteServices
    {
        private readonly IPacientesRepository _repository;
        public PacienteServices(IPacientesRepository pacientesRepository)
        {
            _repository = pacientesRepository;
        }
        public async Task<List<Character>> ObtenerPacientes()
        {
            return await _repository.ObtenerPacientes();
        }
    }
}
