using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    // out T yapmamızın nedeni istersek liste istersek tek bir entity taşıyabiliriz. Aşağıdaki gibi farklılıkları bir arada kullanabilmek için "out T" olarak Interface i kullandık.
    public interface IDataResult<out T>:IResult
    {
        public T Data { get;}   
                                // new DataResult<Category>(ResultStatus.Success,category);
                                // new DataResult<IList<Category>>(ResultStatus.Success,categoryList);
    }
}
