using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Govinet_Front_End_Connection_Checker.Models
{
    public class Check
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string prop1 { get; set; }
        public string prop2 { get; set; }

        public string prop3 {  get; set; }

        public string prop4 { get; set; }



    }
}
