using System.Collections.Generic;

namespace E_Konsulat.Domain.Models.Form
{
    public class FormData
    {
        public string Id { get; set; }
        public Dictionary<string, object> Fields { get; set; }
    }
}
