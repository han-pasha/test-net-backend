using System;
using System.ComponentModel.DataAnnotations;

namespace TestSigmatech.Models {

    public class CheckResult {
        public CheckResult t_dukcapil_check_result {get;set;}

        [Key]
        public int NIK {get;set;}

        public DateTime check_dtm {get;set;}
        public string check_status {get;set;}
    }
}