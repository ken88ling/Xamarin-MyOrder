using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder.Persistence
{
    public interface ISqLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
