﻿using System.Collections.Generic;
using System.Threading.Tasks;
using E_Konsulat.Domain;
using E_Konsulat.Domain.Models.Form;
using E_Konsulat.Domain.Providers;

namespace E_Konsulat.Infrastructure.Providers
{
    public class TestSchemaProvider : IFormSchemaProvider
    {
        public async Task<FormSchema> LoadSchemaAsync(string formId)
        {
            return await Task.FromResult(new FormSchema
            {
                Id = "FormId",
                ChildNodes = new List<FormNode>
                {
                    new Facet
                    {
                        DomainKey = "Nazwisko",
                        Selector = "cp_f_daneOs_txtNazwisko",
                        NodeType = NodeTypes.Text
                    },
                    new Facet
                    {
                        DomainKey = "NazwiskoRodowe",
                        Selector = "cp_f_daneOs_txtNazwiskoRodowe",
                        NodeType = NodeTypes.Text
                    },
                    new Facet
                    {
                        DomainKey = "Imiona",
                        Selector = "cp_f_daneOs_txtImiona",
                        NodeType = NodeTypes.Text
                    },
                    new Facet
                    {
                        DomainKey = "DataUrodzin",
                        Selector = "cp_f_daneOs_txtDataUrodzin",
                        NodeType = NodeTypes.Text
                    },
                    new Facet
                    {
                        DomainKey = "MiejsceUrodzenia",
                        Selector = "cp_f_daneOs_txtMiejsceUrodzenia",
                        NodeType = NodeTypes.Text
                    }
                }
            });
        }
    }
}
