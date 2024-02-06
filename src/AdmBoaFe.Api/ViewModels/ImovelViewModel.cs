using System;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.Api.ViewModels
{
    public class ImovelViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CondominioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUpload { get; set; } 
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string NomeCondominio { get; set; } 
        public Guid LogradouroId { get; set; } 
        public Guid ProprietarioId { get; set; }
        public ProprietarioViewModel Proprietario { get; set; }
        public Guid InquilinoId { get; set; }
        public InquilinoViewModel Inquilino { get; set; }
    }
}
