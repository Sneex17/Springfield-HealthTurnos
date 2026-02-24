using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CEntidades;


namespace CInfraestructura
{
    public class PacientesApiRepository : IPacientesRepository
    {
        private readonly HttpClient _httpClient;
        public PacientesApiRepository(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<Character>> ObtenerPacientes()
        {
            // Primera petición para saber cuántas páginas hay
            var resultado = await _httpClient.GetAsync("https://thesimpsonsapi.com/api/characters");
            resultado.EnsureSuccessStatusCode();
            var json = await resultado.Content.ReadAsStringAsync();
            var primera = JsonConvert.DeserializeObject<CharacterResponse>(json);

            // Crear tareas para todas las páginas en paralelo
            var tareas = new List<Task<List<Character>>>();
            for (int i = 2; i <= primera.pages; i++)
            {
                var pagina = i;
                tareas.Add(Task.Run(async () =>
                {
                    var r = await _httpClient.GetAsync($"https://thesimpsonsapi.com/api/characters?page={pagina}");
                    r.EnsureSuccessStatusCode();
                    var j = await r.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CharacterResponse>(j).results;
                }));
            }

            // Esperar todas las páginas
            var resultados = await Task.WhenAll(tareas);

            // Combinar todo
            var todos = new List<Character>(primera.results);
            foreach (var lista in resultados)
                todos.AddRange(lista);

            return todos;

            //var lista = new List<Character>();
            //var url = "https://thesimpsonsapi.com/api/characters";

            //while (url != null)
            //{

            //}
            //var resultado = await _httpClient.GetAsync(url);
            //resultado.EnsureSuccessStatusCode();
            //var json = await resultado.Content.ReadAsStringAsync();
            //var response = JsonConvert.DeserializeObject<CharacterResponse>(json);

            //lista.AddRange(response.results);
            //url = response.next;
            //return lista;
        }
    }
}
