using System;
using System.ComponentModel.DataAnnotations;
using TestSigmatech.Models;

namespace TestSigmatech.Dtos {

    public class CreateCheckResultDto {

        [Required]
        public string t_dukcapil_check_result {get;set;}

        [Required]
        [Range(0000000001,9999999999)]
        public int NIK { get; set; }
        [Required]
        public DateTime check_dtm {get;set;}
        [Required]
        public string check_status {get;set;}

    }
}