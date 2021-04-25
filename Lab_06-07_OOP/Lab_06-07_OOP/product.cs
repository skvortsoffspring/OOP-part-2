using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Lab_06_07_OOP.Annotations;
using Lab_06_07_OOP.ServicesClasses;

namespace Lab_06_07_OOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class product : INotifyPropertyChanged
    {
        private BitmapImage _productThumbBitmapImage;
        private BitmapImage _productImageFBitmapImage;
        private BitmapImage _productImageSBitmapImage;
        private BitmapImage _productImageTBitmapImage;
        private int? _productCategory;
        private string _productName;
        private int? _productWeight;
        private string _productShortDesc;
        private string _productLongDesc;
        private string _productDetails;
        private int? _productStock;
        private double? _productPrice;
        private byte[] _productThumb;
        private byte[] _productImageF;
        private byte[] _productImageS;
        private byte[] _productImageT;

        public IEnumerable<productcategory> ProductCategories { get; set; } = MainWindow.Market.productcategories.ToList();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.orderdetails = new HashSet<orderdetail>();
            this.productoptions = new HashSet<productoption>();
        }
    
        public int ProductID { get; set; }

        public Nullable<int> ProductCategory
        {
            get
            {
                return _productCategory;
            }        
            set
            {
                _productCategory = value;
                
            }
        }

        public Nullable<int> ProductCategoryMvvm
        {
            get
            {
                var productCategory = MainWindow.ViewModel.ProductCategories.Where(productCategory => productCategory.CategoryID == _productCategory).First();
                return MainWindow.ViewModel.ProductCategories.IndexOf(productCategory);    
            }

            set
            {
                _productCategory = MainWindow.ViewModel.ProductCategories[(int) value].CategoryID;
                OnPropertyChanged("ProductCategory");
            }
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        public Nullable<int> ProductWeight
        {
            get => _productWeight;
            set
            {
                _productWeight = value;
                OnPropertyChanged("ProductWeight");
            }
            
        }

        public string ProductShortDesc
        {
            get => _productShortDesc;
            set { 
                _productShortDesc = value; 
                OnPropertyChanged("ProductShortDesc"); 
            }
        }

        public string ProductLongDesc
        {
            get => _productLongDesc;
            set
            {
                _productLongDesc = value;  
                OnPropertyChanged("ProductLongDesc");
            }
        }

        public string ProductDetails
        {
            get => _productDetails;
            set
            { 
                _productDetails = value;
                OnPropertyChanged("ProductDetails");
            } 
        }

       

        public BitmapImage ProductThumbBitmapImage
        {
            get { return  ServicesConvert.ByteToBitmapImage(ProductThumb); }
            set
            {
                _productThumbBitmapImage = ServicesConvert.ByteToBitmapImage(ProductThumb);
            }
        }
        public BitmapImage ProductImageFBitmapImage
        {
            get { return  ServicesConvert.ByteToBitmapImage(ProductImageF); }
            set { _productImageFBitmapImage = ServicesConvert.ByteToBitmapImage(ProductImageF); }
        }
        public BitmapImage ProductImageSBitmapImage
        {
            get { return  ServicesConvert.ByteToBitmapImage(ProductImageS); }
            set { _productImageSBitmapImage = ServicesConvert.ByteToBitmapImage(ProductImageS); }
        }
        public BitmapImage ProductImageTBitmapImage
        {
            get { return  ServicesConvert.ByteToBitmapImage(ProductImageT); }
            set { _productImageTBitmapImage = ServicesConvert.ByteToBitmapImage(ProductImageT); }
        }
        public byte[] ProductThumb
        {
            get => _productThumb;
            set
            {
                _productThumb = value;
                OnPropertyChanged("ProductThumbBitmapImage");
            }
        }

        public byte[] ProductImageF
        {
            get => _productImageF;
            set
            {
                _productImageF = value;
                OnPropertyChanged("ProductImageFBitmapImage");
            }
        }

        public byte[] ProductImageS
        {
            get => _productImageS;
            set
            {
                _productImageS = value;
                OnPropertyChanged("ProductImageSBitmapImage");
            }
        }

        public byte[] ProductImageT
        {
            get => _productImageT;
            set
            {
                _productImageT = value;
                OnPropertyChanged("ProductImageTBitmapImage");
            }
        }

        public Nullable<int> ProductStock
        {
            get => _productStock;
            set
            {
                _productStock = value;
                OnPropertyChanged("ProductStock");
            }
        }

        public Nullable<double> ProductPrice
        {
            get => _productPrice;
            set
            {

                _productPrice = value;
                OnPropertyChanged("ProductPrice");

            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderdetail> orderdetails { get; set; }
        public virtual productcategory productcategory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productoption> productoptions { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
