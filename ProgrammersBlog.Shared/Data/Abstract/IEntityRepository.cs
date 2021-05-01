using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Abstract
{
    // Generic repository -> Tip vericez verdiğimiz tip e göre repository işlem yapacak
    public interface IEntityRepository<T> where T : class, IEntity, new()  // şartladık sadece veritabanı nesnelerinin gelebileceğini belirtmiş olduk.
    {
        // Tüm entityler için DAL classlarında kullanabileceğimiz metodları oluşturuyoruz. Ortak kullanılabilecek metodlar.
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties);
        // bir kullanıcıyı yüklemek istediğimizde predicate ile bilgilerini giriyoruz ve includeProperties ile istediğimiz kadar include ekleyebiliriz
        Task<IList<T>> getAllAsync(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] includeProperties); // predicate null ise hepsini

        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate); // daha önce böyle bir email ile kayıt olundu mu tarzından kontrol sağlamak için
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
