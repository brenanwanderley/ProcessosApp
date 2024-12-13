using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ProcessosApp.Data.DataTransferObjects;

namespace ProcessosApp.Services
{
    public class IBGEService
    {
        private readonly HttpClient _httpClient;

        public IBGEService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Método para pegar todos os estados
        public async Task<List<EstadoDto>> GetEstadosAsync()
        {
            var response = await _httpClient.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/estados");

            var estados = JsonSerializer.Deserialize<List<EstadoDto>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return estados;
        }

        // Método para pegar municípios de um estado específico
        public async Task<List<MunicipioDto>> GetMunicipiosAsync(string uf)
        {
            var response = await _httpClient.GetStringAsync($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios");

            var municipios = JsonSerializer.Deserialize<List<MunicipioDto>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return municipios;
        }

        // Método para pegar informações de um município específico
        public async Task<MunicipioDto> GetMunicipioAsync(long codigo)
        {
            var response = await _httpClient.GetStringAsync($"https://servicodados.ibge.gov.br/api/v1/localidades/municipios/{codigo}");

             var municipio = JsonSerializer.Deserialize<MunicipioDto>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return municipio;
        }
    }
}