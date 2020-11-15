using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Data
{
    public class MqttData
    {
        [Required]
        public string serverUri { get; set; }

        [Required]
        public string clientId { get; set; }

    }
}