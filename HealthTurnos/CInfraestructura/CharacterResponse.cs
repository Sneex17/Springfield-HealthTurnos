using System.Collections.Generic;
using CEntidades;


namespace CInfraestructura
{
    public class CharacterResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
        public int pages { get; set; }
        public List<Character> results { get; set; }
    }
}
