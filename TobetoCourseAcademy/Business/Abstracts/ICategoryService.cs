using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService : IGenericService<Category>
    {

    }
}
/*
Interface (Arayüz) : Bir sınıfın belirli bir işlevselliği taşıyan metotları ve özellikleri tanımlayan bir sözleşmedir.
                     Arayüz, sınıflar arası bir sözleşme sağlar. Yani, 'ICategoryService' arayüzünü uygulayan bir sınıf, bu arayüzde tanımlanan metotları sağlamak zorundadır.
                     Bu, kodun daha modüler ve genişletilebilir olmasına olanak tanır. Birden fazla sınıf, aynı arayüzü kullanarak benzer davranışları paylaşabilir.

GenericService : Genel bir servis yapısı. Bu yapı sayesinde, başka bir nesne ile çalışmak istediğimizde yeni bir servis oluşturmak                  yerine mevcut olanı genişletebiliriz.


 */