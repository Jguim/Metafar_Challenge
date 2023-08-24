using System.ComponentModel.DataAnnotations;

namespace Metafar_App_Challenge.Models.Enum
{
    public enum IntervalEnum
    {

        [Display(Name = "1 minute")]
        oneMinute = 0,

        [Display(Name = "5 minutes")]
        fiveMinutes = 1,

        [Display(Name = "15 minutes")]
        fifteenMinutes = 2
    }
}
