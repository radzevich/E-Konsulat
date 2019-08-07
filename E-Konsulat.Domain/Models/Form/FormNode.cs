using System.Collections.Generic;

namespace E_Konsulat.Domain.Models.Form
{
    public class FormNode
    {
        public List<FormNode> ChildNodes { get; set; }
    }
}
