using Metafar_App_Challenge.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Metafar_App_Challenge.Models
{
    public class ActionViewModel
    {
        #region Properties
        public string username { get; set; }
        public List<ActionDTO> favorites { get; set; }
        public List<ActionDTO> actions { get; set; }
        #endregion
    }
}
