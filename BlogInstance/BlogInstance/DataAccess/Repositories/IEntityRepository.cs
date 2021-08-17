using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BlogInstance.DataAccess.Abstract;

namespace BlogInstance.DataAccess.Repositories
{
    public interface IEntityRepository<T>where T: class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>>predicate,params Expression<Func<T,object>>[] includeProperties);
        //var kullanici = repository.GetAsync(a=>a.Id==15) predicate tam olarak filtreleme yapıyor, ikinci kısım ise o filtreye ait diğer bilgiler için yani örn kullanıcının makalelerini de getirmek için 
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        //örn C# kategorisine ait tüm makaleleri listelemek için ise IList şeklinde yapıldı eğer tüm makaleleri listelemek için ise predicate=null şeklinde tanıtıldı.  


        //metodların async ile bitme nedeni asenkron metod olmasından kaynaklı
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        //bu mail adresiyle kayıtlı başka kullanıcı var mı?
        Task<int> CountAsync(Expression<Func<T, int>> predicate);


    }
}
