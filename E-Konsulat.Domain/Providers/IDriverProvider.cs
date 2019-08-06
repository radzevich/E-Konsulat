namespace E_Konsulat.Domain.Providers
{
    public interface IDriverProvider
    {
        TDriver GetDriver<TDriverOptions, TDriver>(TDriverOptions options);
    }
}
