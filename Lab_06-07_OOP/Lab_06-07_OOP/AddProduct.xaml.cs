using System.Data.Entity;
using System.Windows;

namespace Lab_06_07_OOP
{
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            using(UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };
 
                // добавляем их в бд
                db.Userss.Add(user1);
                db.Userss.Add(user2);
            }
        }
    }
    
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    class UserContext : DbContext
    {
        public UserContext()
            :base("DbConnection")
        { }
          
        public DbSet<User> Userss { get; set; }
    }
}