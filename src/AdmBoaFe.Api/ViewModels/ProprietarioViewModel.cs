using AdmBoaFe.Business.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.Api.ViewModels
{
    public class ProprietarioViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Documento { get; set; }
        public string Estado { get; set; }
        public TipoPessoa TipoProprietario { get; set; }
    }
}
