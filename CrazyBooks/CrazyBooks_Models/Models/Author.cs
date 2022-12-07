using System.ComponentModel.DataAnnotations;

namespace CrazyBooks_Models.Models  //on a changé tous les namespaces CrazyBooks_Web en CrazyBooks_Models pis on right click crazybooks_models pour regénérer pour faire dll
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

       
        //Propriété de navigation 1 à 1
        public AuthorDetail AuthorDetail { get; set; }
    }
}
