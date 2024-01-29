namespace Entity.productDesc
{

    public class ProductDescription
    {
        public int ProductId {get; set;}
        public int ProductDescriptionId { get; set; } //empty , will be created in logic file
        public string Colour { get; set; } // L
        public string ImagePath { get; set; } // ecommerce/ui/abc.jpg
        public string Attribute1 { get; set; }
        public string Attribute1Value { get; set; } 
        public string Attribute2 { get; set; } // material 
        public string Attribute2Value { get; set; } //silk
        public string Attribute3 { get; set; }
        public string Attribute3Value { get; set; }
        public string ProductDesc  { get; set; } //....
        public float ProductPrice { get; set; }//
        public float ProductDiscount { get; set; }
        public int Sku { get; set; }
        public float Rating { get; set; }

    }
}