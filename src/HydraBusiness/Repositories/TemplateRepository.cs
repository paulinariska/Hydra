namespace HydraBusiness;

public class TemplateRepository
{
    // private readonly WmsurojoyoContext _context;

    // public CategoryRepository(WmsurojoyoContext context)
    // {
    //     _context = context;
    // }
    
    // public List<Category> Get() => 
    //     _context.Categories
    //         .Where(category => category.DeletedDate == null)
    //         .ToList();

    // public List<Category> Get(int page, int pageSize, string name) =>
    //     _context.Categories
    //         .Where(category => 
    //             category.Name.ToLower().Contains(name ?? "".ToLower()) &&
    //             category.DeletedDate == null
    //         )
    //         .Skip((page - 1) * pageSize)
    //         .Take(pageSize)
    //         .ToList();

    // public Category? Get(string id) => 
    //     _context.Categories
    //     .FirstOrDefault(category => category.Id == id);

    // public void Insert(Category req){
    //     try
    //     {
    //         _context.Categories.Add(req);
    //         _context.SaveChanges();
    //     }
    //     catch (System.Exception)
    //     {
    //         throw;
    //     }
    // }

    // public void Update(Category req){
    //     try
    //     {
    //         _context.Categories.Update(req);
    //         _context.SaveChanges();
    //     }
    //     catch (System.Exception)
    //     {
    //         throw;
    //     }
    // }

    // public void Delete(string id){
    //     try
    //     {
    //         _context.Categories.Remove(_context.Categories.First(category => category.Id == id));
    //         _context.SaveChanges();
    //     }
    //     catch (System.Exception)
    //     {
    //         throw;
    //     }
    // }

    // public int CountData(string name) => 
    //     _context.Categories
    //         .Count(category => category.Name.ToLower().Contains(name ?? "".ToLower()));
}
