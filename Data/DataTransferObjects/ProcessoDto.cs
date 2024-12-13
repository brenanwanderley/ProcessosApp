using System.ComponentModel.DataAnnotations;

namespace ProcessosApp.Data.DataTransferObjects
{

    public class ProcessoDto
    {

        [Required(ErrorMessage = "O Campo é obrigatório !")]
        public string NomeProcesso { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatório e precisa seguir o padrão !")]
        public string Npu { get; set; }

        public string EstadoSigla { get; set; }
        
        public long MunicipioId { get; set; }

    }
}