
namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    public interface IPrettifyCode
    {
        ILanguage Language { get; }
        string Prettify(string language, string code, PrettifyCodeOption option);
    }
}
