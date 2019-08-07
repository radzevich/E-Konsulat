namespace E_Konsulat.Domain.Models.Form
{
    public class Facet : FormNode
    {
        public string Selector { get; set; }
        public string DomainKey { get; set; }
        public FacetTypes FacetType { get; set; }
    }
}
