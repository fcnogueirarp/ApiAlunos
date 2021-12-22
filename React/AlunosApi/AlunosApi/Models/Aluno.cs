using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosApi.Models
{
    [Table("Alunos")] //desnecessário acaba sendo redundante pois no db context já efetuei um map de aluno para alunos
    public class Aluno
    {
        [Key] //desnecessário acaba sendo redundante pois através do id o entity já entende que temos uma chave primária
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}