namespace CEntidades
{
    public class Ruta
    {
       private readonly string _url = @"C:\Users\xrami\OneDrive\Documentos\Springfield HealthTurnos\HealthTurnos\CPresentacion\Reportes\";
        public Ruta(string nombre)
        {
            this._url = $"{_url}{nombre}";
        }
        public string GetRuta()
        {
            return this._url;
        }
    }
}
