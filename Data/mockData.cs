namespace PlatformeService;

public static class mockData
{
    public static void dataPopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            seedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }
    }


    private static void seedData(AppDbContext dbContext)
    {
        if (!dbContext.Platforms.Any())
        {
            Console.WriteLine("-->  Seeding data...");
            dbContext.AddRange(
                new Platform() { Name = ".NET8", Publisher = "Microsoft", Cost = "Free" },
                new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" },
                new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" }
            );

            dbContext.SaveChanges();
        }
        else
        {
            Console.WriteLine("-->  We already have data");
        }
    }
}
