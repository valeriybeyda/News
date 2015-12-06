using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Entity;
namespace News.Repositories
{
    public interface INewsRepository
    {
        List<NewsEntity> GetAll();
    }
}
