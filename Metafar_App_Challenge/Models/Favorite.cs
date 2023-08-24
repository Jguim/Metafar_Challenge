using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metafar_Challenge.Models
{
    [Table("Favorite")]
    public class Favorite
    {
        #region Properties
        [Required]
        public Guid Id { get; set; }
        
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid UserId { get; set; }
        
        [ForeignKey("ActionId")]
        public Actions Action { get; set; }
        public Guid ActionId { get; set; }
        #endregion
    }
}
