using System;
using System.ComponentModel.DataAnnotations;
using TestSigmatech.Models;

namespace TestSigmatech.Dtos {

    public class CreateStatusDto {
        [Required]
        public int m_dukcapil_data_id { get; set; }

        [Required]
        [Range(0000000001,9999999999)]
        public int NIK { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string maiden_name {get;set;}
        [Required]
        public DateTime birth_date {get;set;}
        [Required]
        [Range(1,2)]
        public Gender gender {get;set;}
        [Required]
        [Range(1,8)]
        public int religion_id {get;set;}
        [Required]
        [Range(1,4)]
        public MaritalStatus marital_status {get;set;}
    }
}