using Newtonsoft.Json;

namespace WebApp.WebTools
{
    public class SweetAlert
    {
        // We'll temporarily use Newtonsoft for json serialization until mechanism to handle circular references is fixed for System.Text.Json.Serialization
        // Tracking code: 3.0.0-issue1

        [JsonProperty(PropertyName = "typeOfAlert")]
        public string TypeOfAlert { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "confirmLabel")]
        public string ConfirmLabel { get; set; }

        [JsonProperty(PropertyName = "cancelLabel")]
        public string CancelLabel { get; set; }

        public SweetAlert()
        {
            this.ConfirmLabel = "Yes";
            this.CancelLabel = "Cancel";
        }

    }
}