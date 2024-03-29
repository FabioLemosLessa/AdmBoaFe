﻿using System.ComponentModel.DataAnnotations;

namespace AdmBoaFe.Api.ViewModels
{
    public class LogradouroViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string NomeFornecedor { get; set; }
    }
}