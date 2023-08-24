using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metafar_App_Challenge.Models
{
    public class LoginViewModel
    {
        #region properties
        public string name { get; set; }
        public string password { get; set; }
        #endregion

        public LoginViewModel() { }
    }
}
