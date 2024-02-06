using System;

namespace AdmBoaFe.Business.Models
{
    public class Imovel : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Guid CondominioId { get; set; }
        public Condominio Condominio { get; set; }
        public Guid LogradouroId { get; set; }
        public Logradouro Logradouro { get; set; }
        public Guid ProprietarioId { get; set; }
        public Proprietario Proprietario { get; set; }
        public Guid InquilinoId { get; set; }
        public Inquilino Inquilino { get; set; }
    }
}
