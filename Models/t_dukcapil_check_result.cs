using System;
using System.ComponentModel.DataAnnotations;

namespace TestSigmatech.Models {
    public class CheckResult {

        public string t_dukcapil_check_result {get;set;}
        public int NIK {get;set;}
        [Key]
        public DateTime check_dtm {get;set;}
        public string check_status {get;set;}
    }
}