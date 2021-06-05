using Microsoft.EntityFrameworkCore;


namespace sillypub{
    public class DataContext: DbContext {
        public DataContext(DbContextOptions<DataContext> options): base(options) {

        }
    }  
}