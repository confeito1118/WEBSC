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
            // the URL of the target Wikipedia page
            string url = "https://en.wikipedia.org/wiki/List_of_SpongeBob_SquarePants_episodes";

            var web = new HtmlWeb();
            // downloading to the target page
            // and parsing its HTML content
            var document = web.Load(url);
        }
    }
}
