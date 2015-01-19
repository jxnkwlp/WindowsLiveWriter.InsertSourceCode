using System.Linq;
using System.Text;

namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    public class GooglePrettifyCode : IPrettifyCode
    {
        public string Prettify(string language, string code, PrettifyCodeOption option)
        {
            string lang = this.Language.GetLanguageList().First(t => t.ToLower() == language.ToLower());

            StringBuilder sb = new StringBuilder();
            if (option.ShowLineNumber)
            {
                if (option.LineNumberStart != 1)
                    sb.AppendLine(string.Format("<pre class=\"prettyprint linenums:{1} lang-{0}\">", lang, option.LineNumberStart));
                else
                    sb.AppendLine(string.Format("<pre class=\"prettyprint linenums lang-{0}\">", lang));
            }
            else
                sb.AppendLine(string.Format("<pre class=\"prettyprint lang-{0}\">", lang));

            sb.Append(code);

            sb.AppendLine("</pre>");

            return sb.ToString();
        }

        public ILanguage Language
        {
            get { return new GoogleLanguage(); }
        }
    }
}
