namespace HydraAPI;

public class TemplateServices
{
    // private readonly ICategoryRepository _rep;

    // public CategoryService(ICategoryRepository rep)
    // {
    //     _rep = rep;
    // }

    // public List<CategoryResponseDTO> Get() =>
    //     _rep.Get()
    //         .Select(x => new CategoryResponseDTO
    //         {
    //             Id = x.Id,
    //             Name = x.Name,
    //         })
    //         .ToList();

    // public List<CategoryResponseDTO> Get(int page, int pageSize, string name) =>
    //     _rep.Get(page, pageSize, name)
    //         .Select(x => new CategoryResponseDTO
    //         {
    //             Id = x.Id,
    //             Name = x.Name,
    //         })
    //         .ToList();
    
    // public int CountData(string name) => _rep.CountData(name);

    // public Category? Get(string id) => _rep.Get(id);

    // public void Insert(CategoryInsertDTO req) => 
    //     _rep.Insert(new Category
    //         {
    //             Id = Guid.NewGuid().ToString(),
    //             Name = req.Name
    //         });

    // public void Update(CategoryUpdateDTO req) =>
    //     _rep.Update(new Category
    //         {
    //             Id = req.Id,
    //             Name = req.Name
    //         });
    
    // public void Delete(string id) => _rep.Delete(id);
}
