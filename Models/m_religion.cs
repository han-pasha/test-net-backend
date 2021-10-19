using System.ComponentModel.DataAnnotations;

namespace TestSigmatech.Models {

    public class mReligion {

        [Key]
        public int religion_id { get;set;}
        public string religion_name {get;set;}
        public string usr_crt {get;set;} //INI APA?
        public string dtm_crt {get;set;}
        public string usr_upd {get;set;}
        public string dtm_upd {get;set;}
    }
}