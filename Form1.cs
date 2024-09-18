using System.ComponentModel.Design.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.ComponentModel.Design;

namespace PrimeMinisters
{
    public partial class frmPrimeMinisters : Form
    {
        private Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>();

        public frmPrimeMinisters()
        {
            InitializeComponent();
        }

        private void frmPrimeMinisters_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("maple-leaf.ico");
            string filename = "PrimeMinisters.json";
            FileStream stream = File.OpenRead(filename);

            primeMinisters = JsonSerializer.Deserialize<Dictionary<string, PrimeMinister>>(stream);

            stream.Close();

            lstPrimeMinisters.DataSource = primeMinisters.Keys.ToList<string>();
            lstPrimeMinisters.SelectedIndex = 1;
        }

        private void lstPrimeMinisters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dictKey = lstPrimeMinisters.SelectedValue.ToString();

            lblName.Text = $"{primeMinisters[dictKey].FirstName} {primeMinisters[dictKey].LastName}";
            lblTerm.Text = $"{primeMinisters[dictKey].Term}";
            lblParty.Text = $"{primeMinisters[dictKey].Party}";
            picPhoto.ImageLocation = $"{dictKey.ToLower()}.jpg";
        }
    }
}
