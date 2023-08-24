using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metafar_Challenge.Models
{
    [Table("User")]
    public class User
    {
        #region Properties
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
        #endregion
    }
}
