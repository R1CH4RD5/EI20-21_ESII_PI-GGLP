﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EI20_21_ESII_PI_GGLP.Models
{
    public class Pessoa
    {

        [Key]
        public int PessoaID { get; set; }


        [Required(ErrorMessage = "Introduza seu o Nome")]
        [RegularExpression ( @"[a-zA-Z]+")]
        [StringLength(50)]
        public string PNome { get; set; }


        [Required(ErrorMessage = "Introduza o Contato")]
        [RegularExpression(@"(9[1236]\d{7})|(2\d{8})", ErrorMessage = "Contato Incorreto")]
        public int PContato { get; set; }


        [Required(ErrorMessage = "Introduza o Email")]
        [EmailAddress(ErrorMessage = "Email Incorreto")]
        public string PEmail { get; set; }

        [Required(ErrorMessage = "Introzua um Comentario")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "No mínimo 10 carateres")]
        public string PComments { get; set; }




        // Pessoa Class '1 to *' Agendamento Class
        public ICollection<Agendamento> Agendamentos { get; set; }

        // Pessoa Class '1 to *' PontoDeInteresse Class
        //public ICollection<PontoDeInteresse> PontoDeInteresses { get; set; }
    }
}
