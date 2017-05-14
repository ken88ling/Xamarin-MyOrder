using SQLite;

namespace MyOrder.Persistence
{
    public interface ISqLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
