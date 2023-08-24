using Newtonsoft.Json;

namespace WebApp.WebTools.DataTable
{
    public class DataTableRow
    {
        [JsonProperty(PropertyName = "id")]
        public string DT_RowId { get; set; }

        public List<DataTableAction> Actions { get; set; }
    }
}