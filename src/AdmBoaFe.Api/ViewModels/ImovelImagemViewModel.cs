using System;
using System.ComponentModel.DataAnnotations;
using AdmBoaFe.Api.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdmBoaFe.Api.ViewModels
{
    public class ImovelImagemViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CondominioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IFormFile ImagemUpload { get; set; }
        public byte[] Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string NomeCondominio { get; set; } 
    }
}
