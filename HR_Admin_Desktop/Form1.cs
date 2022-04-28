using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

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

        private string extractedNumberFromJson;

        private static bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (Newtonsoft.Json.JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string populateJsonString()
        {
            if (IsValidJson(Clipboard.GetText())) { 

            JToken resultToken = JToken.Parse(Clipboard.GetText());

            JObject json = JObject.Parse(resultToken.ToString());

            string url = string.Empty;

            foreach (var item in json)
            {
                if(item.Key.ToLower() == "number")
                {
                    extractedNumberFromJson = item.Value.ToString();
                }
                else { 
                    url += "%0a"+item.Key + ":%20" + item.Value  ;
                }
            }
                // https://api.whatsapp.com/send/?phone=923150222321&text=Price:%2063333%0aLink:%20http%3A%2F%2Fwww.google.com%0aPhone:%2003452362514%0aProduct:%20POWERCON+30&app_absent=0
                ErrorMsg.Text = "";
                return "text="+ url;
            }
            else
            {
                ErrorMsg.Text= "Invalid JSON";
                return "";
            }
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
            form1.label1.Text = url.Replace("&","&&");
            form1.webView.Source = new Uri(url);
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
            ErrorMsg.Text = "";
            if (!string.IsNullOrWhiteSpace(Clipboard.GetText()))
            {
                if (JSONR.Checked)
                {
                    string otherPart = populateJsonString();

                    if ( !string.IsNullOrWhiteSpace(extractedNumberFromJson) && extractedNumberFromJson.All(char.IsDigit))
                    {
                        if(extractedNumberFromJson.ToString() + "&" + otherPart != form1.addressBar.Text)
                        {
                            form1.addressBar.Text = extractedNumberFromJson.ToString() + "&" + otherPart;
                            string value = form1.addressBar.Text;
                            visitUrl();
                        }
                        else
                        {
                            form1.addressBar.Text = extractedNumberFromJson.ToString() + "&" + otherPart;
                            string value = form1.addressBar.Text;
                        }
                    }
                    else
                    {
                        ErrorMsg.Text ="Invalid JSON string";
                        WJSONR.Checked = true;
                        JSONR.Checked = false;
                    }
                }
                if (WJSONR.Checked)
                {
                    if (Clipboard.GetText().ToLower().Trim() != form1.addressBar.Text.ToLower().Trim())
                    {
                        string url = Clipboard.GetText().ToLower().Trim();
                        if (url.All(char.IsDigit))
                        {
                            form1.addressBar.Text = url.ToString();
                            string value = form1.addressBar.Text;
                            visitUrl();
                        }
                        else
                        {
                            ErrorMsg.Text = "Invalid phone number";
                        }
                    }
                }
            }
        }

        private void WJSONR_CheckedChanged(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";
            if (WJSONR.Checked)
            {
                JSONR.Checked = false;
                Form1_Activated(null,null);
            }
        }

        private void JSONR_CheckedChanged(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";

            if (JSONR.Checked)
            {
                WJSONR.Checked = false;
                Form1_Activated(null, null);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clipboard.Clear();
        }
    }
}