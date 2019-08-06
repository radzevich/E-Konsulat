using E_Konsulat.Application.Helpers;
using E_Konsulat.Infrastructure.Providers;

namespace E_Konsulat.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var formMapper = new FormMapper(new TestSchemaProvider(), new TestDataProvider());
            formMapper.Map().GetAwaiter().GetResult();
        }
    }
}
 