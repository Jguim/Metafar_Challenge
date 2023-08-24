using WebApp.WebTools.DataTable;

namespace WebApp.Models
{
    public class ActionRow : DataTableRow
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
        public string favorite { get; set; }


        public ActionRow() { }
    }
}
