using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;
using Entity.productSummary;
using Interface.homepage;
using MySql.Data.MySqlClient;

namespace DAL.homepage
{
    public class HomepageProductRepositary : IHomepageProductRepositary
    {
        public HomepageProductRepositary()
        {

        }

        public async Task<List<Product>> GetDealOfDayProductAsync()
        {
            List<Product> products = new();
            List<ProductDescription> productDesc = await GetProductDescWithHighestDiscountAsync();
            int productDescLength = productDesc.Count;
            for (int i = 0; i < productDescLength; i++)
            {
                Product product = new();
                ProductPrimaryDetails productPrimaryDetails = new();
                productPrimaryDetails = await GetProductPrimaryDetails(productDesc[i].ProductId);
                product.ProductPrimaryDetails = productPrimaryDetails;
                product.ProductDescription = productDesc[i];
                products.Add(product);
            }
            return products;
        }

        public async Task<List<ProductDescription>> GetProductDescWithHighestDiscountAsync()
        {
            List<ProductDescription> productSummary = new();
            string connectionString = "server=localhost; port=3306; database=ecommerce; user=root; password=9284@Mysim;";

            // Create a MySqlConnection
            using (MySqlConnection connection = new(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Define your SELECT query
                    string query2 = "select * from ecommerce.productDescription order by productDiscount desc limit 10";

                    using (MySqlCommand command = new(query2, connection))
                    {
                        // Execute the SELECT query
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows
                            if (reader.HasRows)
                            {
                                // Iterate through the rows
                                while (await reader.ReadAsync())
                                {
                                    ProductDescription productDescription = new();

                                    productDescription.ProductId = reader["productId"] is DBNull ? 0 : reader.GetInt32("productId");
                                    productDescription.ProductDescriptionId = reader["productDescriptionId"] is DBNull ? 0 : reader.GetInt32("productDescriptionId");
                                    productDescription.Attribute1 = reader["attr1"] is DBNull ? string.Empty : reader.GetString("attr1");
                                    productDescription.Attribute1Value = reader["attr1Value"] is DBNull ? string.Empty : reader.GetString("attr1Value");
                                    productDescription.Attribute2 = reader["attr2"] is DBNull ? string.Empty : reader.GetString("attr2");
                                    productDescription.Attribute2Value = reader["attr2Value"] is DBNull ? string.Empty : reader.GetString("attr2Value");
                                    productDescription.Attribute3 = reader["attr3"] is DBNull ? string.Empty : reader.GetString("attr3");
                                    productDescription.Attribute3Value = reader["attr3Value"] is DBNull ? string.Empty : reader.GetString("attr3Value");
                                    productDescription.ProductDesc = reader["productDescription"] is DBNull ? string.Empty : reader.GetString("productDescription");
                                    productDescription.ProductPrice = reader["productPrice"] is DBNull ? 0.0f : reader.GetFloat("productPrice");
                                    productDescription.ProductDiscount = reader["productDiscount"] is DBNull ? 0.0f : reader.GetFloat("productDiscount");
                                    productDescription.Sku = reader["sku"] is DBNull ? 0 : reader.GetInt32("sku");
                                    productDescription.Colour = reader["colours"] is DBNull ? string.Empty : reader.GetString("colours");
                                    productDescription.ImagePath = reader["imagePaths"] is DBNull ? string.Empty : reader.GetString("imagePaths");

                                    productSummary.Add(productDescription);
                                }

                            }
                            else
                            {
                                throw new Exception("No Rows Returned,homePageRepositary");
                            }

                        }
                    }
                    return productSummary;

                }
                catch (Exception ex)
                {
                    throw new Exception($"error {ex.Message} in homepagerepo file,GetProductDescWithHighestDiscountAsync method");
                }
            }
        }

        public async Task<ProductPrimaryDetails> GetProductPrimaryDetails(int productId)
        {

            ProductPrimaryDetails productPrimary = new();
            string connectionString = "server=localhost; port=3306; database=ecommerce; user=root; password=9284@Mysim;";

            // Create a MySqlConnection
            using (MySqlConnection connection = new(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Define your SELECT query
                    string query1 = "SELECT * FROM ecommerce.products where productId=@productId";

                    // Create a MySqlCommand
                    using (MySqlCommand command = new(query1, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);

                        // Execute the SELECT query
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows

                            if (reader.HasRows)
                            {

                                // Iterate through the rows
                                while (await reader.ReadAsync())
                                {
                                    ProductPrimaryDetails productPrimaryDetails = new();

                                    productPrimaryDetails.ProductId = reader["productId"] is DBNull ? 0 : reader.GetInt32("productId");
                                    productPrimaryDetails.ProductName = reader["productName"] is DBNull ? string.Empty : reader.GetString("productName");
                                    productPrimaryDetails.ProductCategory = reader["productCategory"] is DBNull ? string.Empty : reader.GetString("productCategory");
                                    productPrimaryDetails.ProductSubCategory = reader["ProductSubCategory"] is DBNull ? string.Empty : reader.GetString("ProductSubCategory");
                                    productPrimaryDetails.ProductBrand = reader["productBrand"] is DBNull ? string.Empty : reader.GetString("productBrand");
                                    productPrimaryDetails.ShopKartAssured = reader["shopKartAssured"] is DBNull ? 0 : reader.GetInt32("shopKartAssured");


                                    productPrimary = productPrimaryDetails;

                                }
                            }

                        }
                    }
                    return productPrimary;
                }
                catch (Exception ex)
                {
                    throw new Exception($"error {ex.Message} in homepagerepo file,GetProductPrimaryDetails method");
                }
            }

        }
    }
}