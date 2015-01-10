using System.Linq;
using System.Text;

namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    public class GooglePrettifyCode : IPrettifyCode
    {
        public string Prettify(string language, string code, PrettifyCodeOption option)
        {
            string lang = language;
            if (!string.IsNullOrEmpty(language))
                lang = this.Language.GetLanguageList().First(t => t.ToLower() == language.ToLower());

            string css = "prettyprint ";
            if (option.ShowLineNumber && option.LineNumberStart != 1)
            {
                css = css + string.Format("linenums:{0} ", option.LineNumberStart);
            }
            else
            {
                css = css + "linenums ";
            }

            if (!string.IsNullOrEmpty(lang))
            {
                css = css + string.Format("lang-{0} ", lang);
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("<pre class=\"{0}\">", css));

            sb.AppendLine(code);

            sb.AppendLine("</pre>");

            return sb.ToString();
        }

        public ILanguage Language
        {
            get { return new GoogleLanguage(); }
        }
    }
}
