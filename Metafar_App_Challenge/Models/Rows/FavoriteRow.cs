using WebApp.WebTools.DataTable;

namespace WebApp.Models
{
    public class FavoriteRow : DataTableRow
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
        public string delete { get; set; }


        public FavoriteRow() { }
    }
}
