namespace solucaoDomain.Entities
{
    using solucaoDomain.Entities.Utilities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Informativo
    {
        [Key]
        public int IDInformativo { get; set; }
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Status")]
        public StatusInformativo StatusInformativo { get;set;}
    }
}
