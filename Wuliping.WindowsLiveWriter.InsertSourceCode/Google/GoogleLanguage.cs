using System.Collections.Generic;

namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    class GoogleLanguage : ILanguage
    {
        public List<string> GetLanguageList()
        {
            //File extensions supported by default include
            //"bsh", "c", "cc", "cpp", "cs", "csh", "cyc", "cv", "htm", "html",
            //"java", "js", "m", "mxml", "perl", "pl", "pm", "py", "rb", "sh",
            //"xhtml", "xml", "xsl". 

            var lan = new List<string>();
            lan.Add("csharp");
            lan.Add("bash");
            lan.Add("shell");
            lan.Add("cpp");
            lan.Add("css");
            lan.Add("pas");
            lan.Add("patch");
            lan.Add("groovy");
            lan.Add("xml");
            lan.Add("js");
            lan.Add("java");
            lan.Add("php");
            lan.Add("text");
            lan.Add("py");
            lan.Add("rails");
            lan.Add("bash");
            lan.Add("sql");
            lan.Add("vb");
            lan.Add("powershell");
            lan.Add("fsharp");

            return lan;

            //var lan = new Dictionary<string, string>();
            ////lan.Add("UnixShell", "bsh");
            ////lan.Add("UnixShell", "bsh");
            //lan.Add("c", "c");
            //lan.Add("cpp", "cpp");
            //lan.Add("cs", "cs");
            //lan.Add("java", "java");
            //lan.Add("html", "html");
            //lan.Add("js", "js");
            //lan.Add("xml", "xml");

            //return lan;
        }
    }
}
