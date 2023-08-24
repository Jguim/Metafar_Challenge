using System.ComponentModel.DataAnnotations;

namespace Metafar_App_Challenge.Models.DTO
{
    public class ActionDTO
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Delete { get; set; }
        public string Favorite { get; set; }
    }
}
