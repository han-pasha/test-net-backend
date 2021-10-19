using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TestSigmatech.Models {

        public enum Gender {
            Male,
            Female,
        }

        public enum MaritalStatus {
            Single,
            Widow,
            Widower,
            Married
        }
        public class Status {
        
        public int m_dukcapil_data_id {get;set;}
        [Key]
        public int NIK {get;set;}
        public string name {get;set;}
        public string maiden_name {get;set;}
        public DateTime birth_date {get;set;}

        public Gender gender {get;set;}

        public int religion_id {get;set;}
        public MaritalStatus marital_status {get;set;}
    }
}