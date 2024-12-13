using System.ComponentModel.DataAnnotations;

namespace ProcessosApp.Models;

public class Processo
{
    public int Id { get; set; }
    public string NomeProcesso { get; set; }
    public string Npu { get; set; }
    public string EstadoSigla { get; set; }
    public long MunicipioId { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataVisualizacao { get; set; }
}