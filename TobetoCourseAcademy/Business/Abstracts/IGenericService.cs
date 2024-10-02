using Core.Entities;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> Get(int id);
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Update(T entity);
    }
}
/*
 Entity Framework, veritabanı işlemlerini yönetmek için kullanılan bir ORM(Object-Relational Mapping) framework'üdür. Entity Framework, nesne odaklı programlamayı destekler ve veritabanındaki tabloları nesne olarak ele almamızı sağlar.

Entity Framework'ün temel kavramlarından bazıları;
1.Entity (Varlık): Bir "Entity", veritabanındaki tabloya karşılık gelen bir nesnedir. Örneğin, bir "Product" tablosu için C# tarafında bir "Product" sınıfı oluşturabiliriz.

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

2.DbContext(Veritabanı Bağlamı): "DbContext", Entity Framework ile veritabanı arasında bir köprü görevi görür. Bu sınıf, bağlı olduğumuz veritabanındaki tabloları ve ilişkileri temsil eder.

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}

3.Migration(Taşınabilirlik): Entity Framework Migration, veritabanı şemasını güncellemek için kullanılır. Yani, C# tarafında yaptığımız değişiklikleri veritabanına uygulamak için migration'ları kullanabiliriz.

dotnet ef migrations add InitialCreate
dotnet ef database update

4.LINQ(Language Integrated Query): Entity Framework ile veritabanı sorgularını yazmak için LINQ kullanabiliriz. LINQ, C#'ın sorgularını ifade etmek için özel dil özelliklerini kullanmasını sağlar.

using (var context = new ApplicationDbContext())
{
    var expensiveProducts = context.Products.Where(p => p.Price > 100);
}

5.Cade-First ve Database-First: Entity Framework ile iki temel yaklaşım vardır: Code-First ve Database-First. Code-First yaklaşımında, önce C# sınıflarını tanımlarız ve ardından bu sınıflara dayalı olarak veritabanını oluştururuz. Database-First yaklaşımında ise var olan bir veritabanını temel alarak C# sınıflarımızı oluşturabiliriz.

Entity Framework, veritabanı işlemlerini büyük ölçüde birleştirir ve nesne odaklı programlamanın getirdiği avantajları veritabanı işlemleriyle birleştirerek geliştiricilere daha esnek bir yaklaşım sunar.
 */