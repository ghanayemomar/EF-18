using C01.BasicSaveWithTracking.Data;
using C01.BasicSaveWithTracking.Entities;
using C01.BasicSaveWithTracking.Helpers;

class Program
{
    public static void Main(String[] args)
    {
        RunAddRelatedEntity();
    }

    public static void RunBasicSave()
    {
        using (var context = new AppDbContext())
        {
            var author = new Author { Id = 1, FName = "Owen", LName = "Ghanayem" };
            context.Authors.Add(author);
            context.SaveChanges();
        }
    }
    public static void RunBasicUpdate()
    {
        using (var context = new AppDbContext())
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == 1);
            author.FName = "Wayeeeeeeeeen";
            context.SaveChanges();
        }
    }
    public static void RunBasicDelete()
    {
        using (var context = new AppDbContext())
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == 1);
            context.Authors.Remove(author);
            context.SaveChanges();
        }
    }
    public static void RunMiltipleOperationsWithSingleSave()
    {
        using (var context = new AppDbContext())
        {
            var author1 = new Author { Id = 1, FName = "Eric", LName = " Evans" };
            context.Authors.Add(author1);

            var author2 = new Author { Id = 2, FName = "John", LName = " Nully" };
            context.Authors.Add(author2);

            var author3 = new Author { Id = 3, FName = "ditya", LName = " Evans" };
            context.Authors.Add(author3);
            author3.FName = "Aditya";
            context.SaveChanges();
        }
    }
    public static void RunAddRelatedEntity()
    {
        using (var context = new AppDbContext())
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == 1);
            author.Books.Add(new Book
            {
                Id = 1,
                Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software"
            });
            context.SaveChanges();
        }
    }
}