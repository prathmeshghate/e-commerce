using Entity.product;
using Interface.CreateUpdate;
using Interface.CreateUpdateRepo;
using utility.response;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using Entity.productPrimary;
using Entity.productDesc;
using utility.DbResponse;


namespace DAL.CreateUpdate
{
    public class CreateUpdateDbRepositary : ICreateUpdateDbRepositary
    {
        public async Task<DbResponseDetails> InsertPrimaryDetailsAsync(ProductPrimaryDetails product)
        {
            DbResponseDetails response = new();
            string incrementedId;
            string connectionString = "server=localhost; port=3306; database=ecommerce; user=root; password=9284@Mysim;";

            // data for insertion
            string productName = product.ProductName;
            string productCategory = product.ProductCategory;
            string productSubCategory = product.ProductSubCategory;
            string productBrand = product.ProductBrand;
            int shopKartAssured = product.ShopKartAssured;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    // Step 1: Insert into the first table
                    string sqlInsertQuery1 = "INSERT INTO ecommerce.products (productName, productCategory,productSubCategory,productBrand,shopKartAssured) VALUES (@ProductName, @ProductCategory,@ProductSubCategory,@ProductBrand,@ShopKartAssured)";
                    using (SqlCommand command1 = new SqlCommand(sqlInsertQuery1, connection))
                    {
                        command1.Parameters.AddWithValue("@ProductName", productName);
                        command1.Parameters.AddWithValue("@ProductCategory", productCategory);
                        command1.Parameters.AddWithValue("@ProductSubCategory", productSubCategory);
                        command1.Parameters.AddWithValue("@ProductBrand", productBrand);
                        command1.Parameters.AddWithValue("@ShopKartAssured", shopKartAssured);
                        await command1.ExecuteNonQueryAsync();
                    }
                    incrementedId = "SELECT LAST_INSERT_ID()";
                    // Commit the transaction if both steps are successful
                }
                catch (Exception ex)
                {
                    response.Message = (ex.Message, nameof(InsertPrimaryDetailsAsync)).ToString();
                    response.IsValid = false;
                    return response;
                }

            }
            response.Message = ("DataInsertedSuccessfully", nameof(InsertPrimaryDetailsAsync)).ToString();
            response.IsValid = true;
            response.IncrementedId = int.Parse(incrementedId);
            return response;

        }

        public async Task<ResponseDetails> InsertDescriptionAsync(ProductDescription product, int incrementedId)
        {
            string connectionString = "server=localhost; port=3306; database=ecommerce; user=root; password=9284@Mysim;";
            ResponseDetails response = new();
            // Sample data for insertion
            int productId = incrementedId;
            string colour = product.Colour;
            string imagePath = product.ImagePath;
            string attribute1 = product.Attribute1;
            string attribute1Value = product.Attribute1Value;
            string attribute2 = product.Attribute2;
            string attribute2Value = product.Attribute2Value;
            string attribute3 = product.Attribute3;
            string attribute3Value = product.Attribute3Value;
            string productDesc = product.ProductDesc;
            float productPrice = product.ProductPrice;
            float productDiscount = product.ProductDiscount;
            int sku = product.Sku;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                try
                {
                    // Step 1: Insert into the first table
                    string sqlInsertQuery1 = "INSERT INTO ecommerce.productdescription (productId, attr1, attr1Value,attr2,attr2Value,attr3,attr3Value,productDescription,sku,colours,imagePaths) VALUES (@ProductId, @Attribute1, @Attribute1Value, @Attribute2, @Attribute2Value, @Attribute3, @Attribute3Value, @ProductDescription, @Sku, @Colour, @ImagePath)";
                    using (SqlCommand command1 = new SqlCommand(sqlInsertQuery1, connection))
                    {
                        command1.Parameters.AddWithValue("@ProductId", productId);
                        command1.Parameters.AddWithValue("@Attribute1", attribute1);
                        command1.Parameters.AddWithValue("@Attribute1Value", attribute1Value);
                        command1.Parameters.AddWithValue("@Attribute2", attribute2);
                        command1.Parameters.AddWithValue("@Attribute2Value", attribute2Value);
                        command1.Parameters.AddWithValue("@Attribute3", attribute3);
                        command1.Parameters.AddWithValue("@Attribute3Value", attribute3Value);
                        command1.Parameters.AddWithValue("@ProductDescription", productDesc);
                        command1.Parameters.AddWithValue("@Sku", sku);
                        command1.Parameters.AddWithValue("@Colour", colour);
                        command1.Parameters.AddWithValue("@ImagePath", imagePath);
                        await command1.ExecuteNonQueryAsync();
                    }


                }
                catch (Exception ex)
                {
                    response.Message = (ex.Message, nameof(InsertPrimaryDetailsAsync)).ToString();
                    response.IsValid = false;
                    return response;
                }

            }
            response.Message = ("DataInsertedSuccessfully", nameof(InsertPrimaryDetailsAsync)).ToString();
            response.IsValid = true;
            return response;

        }

    }
}