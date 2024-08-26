using Microsoft.EntityFrameworkCore;

public class TaskContext : DbContext
{
    #nullable disable
    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {
        throw new NotImplementedException();
    }

    public DbSet<Task> Tasks { get; set; }
}