using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest
{
    public partial class AddUser : Form
    {
        private const string URL = "http://localhost:8080/mavenprojecttest/REST/";
        private HttpClient m_client = null; 
        public AddUser(ref HttpClient client)
        {
            InitializeComponent();
            m_client = client; 
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public async Task<Uri> CreateUtilisateurAsync(Utilisateurs user)
        {
            var stringContent = new StringContent(user.toXML()) ;

            HttpResponseMessage response = await m_client.PostAsync(
                "/mavenprojecttest/REST/utilisateur/create", stringContent);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
