using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mvcmovie.Models
{
    [Table("Persons")]
    public class Person
    {
        [key]
        public string PersonID { get; set;}
        public string FullName { get; set;}
        public string Address { get; set;}
    }
}