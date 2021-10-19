using System.ComponentModel.DataAnnotations;

namespace TestSigmatech.Models {

    public class mMaritalStatus {

        [Key]
        public int m_marital_status_id { get;set;}
        public string marital_status_desc {get;set;}
    }
}