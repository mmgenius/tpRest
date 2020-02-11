using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest
{
    public partial class Form1 : Form
    {
        private const string URL = "http://localhost:8080/mavenprojecttest/REST/";
        static HttpClient client = null;
        private string urlParameters = "";
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            
        }


        static async Task<Utilisateurs> GetProductAsync(string path)
        {
            Utilisateurs product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Utilisateurs>();
            }
            return product;
        }


        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                "/mavenprojecttest/REST/services/delete/{id}");
            return response.StatusCode;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new AddUser(ref client).ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new AddService(ref client).ShowDialog();
        }
    }
}

 
