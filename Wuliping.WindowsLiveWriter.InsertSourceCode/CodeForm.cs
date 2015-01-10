using System;
using System.Reflection;
using System.Windows.Forms;
using System.Web;

namespace Wuliping.WindowsLiveWriter.InsertSourceCode
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();

            this.Text = "InsertCode - " + Assembly.GetExecutingAssembly().GetName().Version;

            Load_Language();

            tb_code.Text = Clipboard.GetText();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        public IPrettifyCode PrettifyCode
        {
            get
            {
                return new GooglePrettifyCode();
            }
        }

        /// <summary>
        /// return source code
        /// </summary>
        public string Code
        {
            get
            {
                return CreateCode();
            }
        }

        void Load_Language()
        {
            var langs = this.PrettifyCode.Language.GetLanguageList();
            langs.Insert(0, "");

            cb_language.DataSource = langs;
        }

        string CreateCode()
        {
            PrettifyCodeOption option = new PrettifyCodeOption()
            {
                ShowLineNumber = cb_showlinenumber.Checked,
                LineNumberStart = (int)txt_linenumber.Value,
            };

            string input = HttpUtility.HtmlEncode(tb_code.Text);

            var code = this.PrettifyCode.Prettify(cb_language.SelectedValue.ToString(), input, option);

            return code;
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            using (OptionsForm form = new OptionsForm())
            {
                form.ShowDialog();
            }
        }

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cb_language.SelectedValue.ToString());
        }
    }
}
