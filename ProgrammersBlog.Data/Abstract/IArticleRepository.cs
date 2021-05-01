using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    // Article yazdığımız için <T> olarak değil de Article olarak alıyoruz artık bu sayede her yerde tanımlamaya gerek kalmıyor.
    public interface IArticleRepository : IEntityRepository<Article>  // Generik repositorydeki genel metodlar bulunuyor.
    {

    }
}
