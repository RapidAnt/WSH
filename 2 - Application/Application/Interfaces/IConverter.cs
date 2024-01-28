namespace Application
{
    public interface IConverter
    {
        T ConvertFrom<T>(string response);
    }
}
