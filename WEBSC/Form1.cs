using HtmlAgilityPack;

namespace WEBSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var html = @"http://html-agility-pack.net/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            // label1.Text = "Node Name: " + node.Name + "\n" + node.OuterHtml;
            label1.Text = "Node Name: " + node.Name + "\n" + node.InnerHtml;
        }
    }
}
