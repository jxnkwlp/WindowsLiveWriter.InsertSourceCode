using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    /// <summary>
    /// 主入口
    /// </summary>
    [InsertableContentSource(menuText: "插入代码", SidebarText = "插入代码")]
    [WriterPlugin("8d9a62c7-0d43-b6ee-55e0-dce030325e87", "插入代码", ImagePath = "Resources.ico.ico", PublisherUrl = "http://www.wuliping.cn", Description = "WindowsLiveWriter代码插入插件")]
    public class CodePlugin : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            DialogResult result = DialogResult.Cancel;
            using (CodeForm code = new CodeForm())
            {
                result = code.ShowDialog(dialogOwner);
                if (result == DialogResult.OK)
                {
                    content = code.Code;
                }
            }
            return result;
            // return base.CreateContent(dialogOwner, ref content);
        }
    }
}
