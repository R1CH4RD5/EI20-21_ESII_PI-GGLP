﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EI20_21_ESII_PI_GGLP.Models
{
    public class Horario
    {
        [Key]
        public int HorarioID { get; set; }


        // Horario Class '* to 1' PontoDeInteresse Class
        public int PontosDeInteresseID { get; set; }
        public PontoDeInteresse PontoDeInteresse { get; set; }


        // Horario Class '* to 1' Dia Class
        public int DiaID { get; set; }
        public Dia Dia { get; set; }


        public int HInicio { get; set; }
        public int HFim { get; set; }



        //public string HCovid { get; set; }
        //public string HComments{ get; set; }
    }
}
