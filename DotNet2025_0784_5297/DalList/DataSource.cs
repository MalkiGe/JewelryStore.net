using DO;

namespace Dal
{
    internal static class DataSource
    {
        /// <summary>
        /// רשימות שמכילות הפניות לישות מאותו הטיפוס
        /// </summary>
        internal static List<Customer?> customers = new List<Customer?>();
        internal static List<Sale?> sales = new List<Sale?>();
        internal static List<Product?> products = new List<Product?>();

        internal static class Config
        {
            internal const int ProductId = 1000;
            private static int _productId = ProductId;
            public static int ProductNext
            {
                get { return _productId++; }
            }

            internal const int SaleId = 1000;
            private static int _SaleId = SaleId;
            public static int SaleNext
            {
                get { return _SaleId++; }
            }
        }
    }
}
