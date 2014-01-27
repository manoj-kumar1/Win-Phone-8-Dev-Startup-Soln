using DemoDataBoundApp.Common;
using GoogleNews.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleNews.DAL
{
    public interface IDataService
    {
        Task<IList<Item>> GetItems(string queryParameter);
    }
}
