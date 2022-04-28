using Microsoft.Web.WebView2.Core;
namespace HR_Admin_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form1_Resize);
            InitWebView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addressBar.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitUrl();
        }

        async void InitWebView()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

      
        public void visitUrl()
        {
                Form1 form1 = this;
                string textBox = form1.addressBar.Text.Trim();
                string url = "https://web.whatsapp.com/send?phone=";
                if (textBox.StartsWith("0"))
                {
                    textBox = textBox.Substring(1);
                    url = url + "92" + textBox;
                }
                form1.label1.Text = url;
                form1.webView.Source = new System.Uri(url, UriKind.Absolute);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            addressBar.Width = webView.Width;
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                visitUrl();
            }

            //if (clickCount == 0)
            //{
            //    webView.CoreWebView2.ExecuteScriptAsync("document.getElementById('action-button').click();");
            //    clickCount = 1;
            //}
            //else
            //{
            //    webView.CoreWebView2.ExecuteScriptAsync("window.open('https://web.whatsapp.com/send?phone=923472673285');");
            //    clickCount = 0;
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1 form1 = this;

            if (!string.IsNullOrWhiteSpace(Clipboard.GetText()))
            {
                if(Clipboard.GetText().ToLower().Trim() != form1.addressBar.Text.ToLower().Trim()) {
                    string url = Clipboard.GetText().ToLower().Trim();
                    if (url.All(char.IsDigit))
                    {
                        form1.addressBar.Text = url.ToString();
                        string value = form1.addressBar.Text;
                        visitUrl();
                    }
                }
            }
        }
    }
}