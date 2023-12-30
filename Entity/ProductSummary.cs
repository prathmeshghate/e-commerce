namespace Entity.productSummary
{

    public class ProductSummary
    {

        public int Productid { get; set; } //empty , will be created in logic file
        public string ProductName { get; set; } // Halloween, round neck
        public string ProductCategory { get; set; } // Clothing
        public string ProductSubCategory { get; set; } // Tshirt
        public string ProductBrand { get; set; } // H&M
        public int ShopKartAssured { get; set; } // 1
        public int ProductDescriptionId { get; set; } //empty , will be created in logic file
        public string Colours { get; set; } // L,R,G,B
        public string ImagePaths { get; set; } // ecommerce/ui/abc.jpg,ecommerce/ui/abc.jpg
        public string Attribute1 { get; set; }
        public string Attribute1Value { get; set; } 
        public string Attribute2 { get; set; } // material 
        public string Attribute2Value { get; set; } //silk
        public string Attribute3 { get; set; }
        public string Attribute3Value { get; set; }
        public string ProductDescription { get; set; } //....
        public float ProductPrice { get; set; }//
        public float ProductDiscount { get; set; }
        public string Sku { get; set; } //6,9,10
        public float Rating { get; set; }

    }
}