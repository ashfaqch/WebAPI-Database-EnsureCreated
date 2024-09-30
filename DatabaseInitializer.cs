using WebAPI.Entities;

namespace WebAPI;

public static class DatabaseInitializer
{
    public static WebApplication DatabaseEnsureCreated(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        try
        {
            context.Database.EnsureCreated();
            var todoItem = context.TodoItems.FirstOrDefault();
            if (todoItem == null)
            {
                context.TodoItems.AddRange(new TodoItem { Id = 1, IsComplete = false, Name = "Task 1" });
                context.TodoItems.AddRange(new TodoItem { Id = 2, IsComplete = true, Name = "Task 2" });
                context.SaveChanges();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return app;
    }
}