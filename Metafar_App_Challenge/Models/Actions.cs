using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metafar_Challenge.Models
{
    [Table("Action")]
    public class Actions
    {
        #region Properties
        [Required]
        public Guid ActionId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public string Currency { get; set; }
        #endregion
    }
}
