using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab_06_07_OOP.objects
{
    public abstract class Product
    {
        private List<Uri> images = new List<Uri>(5);
        private Uri preview;
        private int productCategory;
        private string productName;
        private long weight;
        private string productShortDesc;
        private string productLongDesc;
        private string productThumb;
        private Uri productStock;
        private float   productPrice;

        public List<Uri> Images => images;

        public Uri Preview => preview;

        public int ProductCategory => productCategory;

        public string ProductName => productName;

        public long Weight => weight;

        public string ProductShortDesc => productShortDesc;

        public string ProductLongDesc => productLongDesc;

        public string ProductThumb => productThumb;

        public Uri ProductStock => productStock;

        public float ProductPrice => productPrice;

        protected Product(Uri preview, int productCategory, string productName, long weight, string productShortDesc, string productLongDesc, string productThumb, Uri productStock, float productPrice)
        {
            this.preview = preview;
            this.productCategory = productCategory;
            this.productName = productName;
            this.weight = weight;
            this.productShortDesc = productShortDesc;
            this.productLongDesc = productLongDesc;
            this.productThumb = productThumb;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }

        protected Product()
        {
        }
    }

    public class Laptop : Product
    {


        public Laptop(Uri preview, int productCategory, string productName, long weight, string productShortDesc, string productLongDesc, string productThumb, Uri productStock, float productPrice) : base(preview, productCategory, productName, weight, productShortDesc, productLongDesc, productThumb, productStock, productPrice)
        {
        }

        public Laptop()
        {
        }
    }
}
