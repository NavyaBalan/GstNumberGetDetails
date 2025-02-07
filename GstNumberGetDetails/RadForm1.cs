using Newtonsoft.Json;
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
using Telerik.WinControls;
using Telerik.WinControls.UI;
using GstNumberGetDetails.Model;

namespace GstNumberGetDetails
{
    public partial class frmGstDetails : Telerik.WinControls.UI.RadForm
    {
        private readonly HttpClient client = new HttpClient();

        public frmGstDetails()
        {
            InitializeComponent(); // Always call InitializeComponent() first to initialize the form controls


        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            foreach (var column in dgvGstDetails.Columns)
            {
                column.Width = 100;
            }
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {
            string gstNumber = radTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(gstNumber))
            {
                MessageBox.Show("Please enter a valid GST number.");
                return;
            }

            try
            {
                string apiUrl = $"https://powerful-gstin-tool.p.rapidapi.com/v1/gstin/{gstNumber}/details";
                var customerDetails = await GetCustomerDetailsAsync(apiUrl);

                if (customerDetails != null)
                {
                    dgvGstDetails.AutoGenerateColumns = true; // Ensure columns are generated automatically
                    dgvGstDetails.DataSource = new List<Customers> { customerDetails }; // Wrap in a list
                }
                else
                {
                    MessageBox.Show("No details found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }


        private async Task<Customers> GetCustomerDetailsAsync(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "1d14ef7e57msh55a7a760b5e50cap1bea16jsn0702fa89a307");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "powerful-gstin-tool.p.rapidapi.com");

                HttpResponseMessage responseMessage = await client.GetAsync(apiUrl);

                if (responseMessage.IsSuccessStatusCode)
                {
                    string responseContent = await responseMessage.Content.ReadAsStringAsync();

                    // Deserialize the API response
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseContent);
                    return apiResponse?.data; // Return the `Customer` object
                }
                else
                {
                    string errorContent = await responseMessage.Content.ReadAsStringAsync();
                    throw new Exception($"API Error: {responseMessage.StatusCode} - {errorContent}");
                }
            }
        }


    }
}
