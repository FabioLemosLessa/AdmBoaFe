using AdmBoaFe.Business.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.Api.ViewModels
{
    public class InquilinoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoPessoa TipoInquilino { get; set; }
        public Guid LogradouroId { get; set; }
        public LogradouroViewModel Logradouro { get; set; }
        public ImovelViewModel Imovel { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
