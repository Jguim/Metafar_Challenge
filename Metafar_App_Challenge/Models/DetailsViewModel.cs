using Metafar_App_Challenge.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metafar_App_Challenge.Models
{
    public class DetailsViewModel
    {
        #region Properties
        
        public Guid ActionId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Currency")]
        public string Currency { get; set; }

        public List<string> intervals { get; set; }
        #endregion
    }
}
