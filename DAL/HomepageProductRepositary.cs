using System.Collections.Generic;
using System.Threading.Tasks;
using DTO;
using DTO.product;
using Entity.product;
using Entity.productSummary;
using Interface.homepage;

namespace DAL.homepage
{
    public class HomepageProductRepositary : IHomepageProductRepositary
    {
        public HomepageProductRepositary()
        {

        }

        public async Task<List<ProductSummary>> GetDealOfDayProductAsync()
        {
            List<ProductSummary> productSummary = await GetProductWithHighestDiscountAsync();
        }

        public async Task<List<ProductSummary>> GetProductWithHighestDiscountAsync()
        {
            List<ProductSummary> productSummary = new();
            string connectionString = "server=localhost; port=3306; database=ecommerce; user=root; password=9284@Mysim;";

            // Create a MySqlConnection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Define your SELECT query
                    string query = "SELECT * FROM YourTableName WHERE YourCondition";

                    // Create a MySqlCommand
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the SELECT query
                        using (MySqlDataReader reader = await command.ExecuteReader())
                        {
                            // Check if there are rows
                            if (reader.HasRows)
                            {
                                // Iterate through the rows
                                while (await reader.ReadAsync())
                                {
                                    // Access columns by name or index
                                    int id = reader.GetInt32("id");
                                    string name = reader.GetString("name");

                                    // Do something with the data
                                    Console.WriteLine($"ID: {id}, Name: {name}");
                                    productSummary.Add(new ProductSummary { });
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}