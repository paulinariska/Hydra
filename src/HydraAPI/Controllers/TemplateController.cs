using Microsoft.AspNetCore.Mvc;

namespace HydraAPI;

// [ApiController]
// [Route("api/v1/category")]
public class TemplateController : ControllerBase
{
    // private readonly CategoryService _service;
    // public CategoryController(CategoryService service)
    // {
    //     _service = service;
    // }

    // [HttpGet]
    // public IActionResult Get(int page, int pageSize, string name = ""){
    //     try
    //     {
    //         var res = _service.Get(page, pageSize, name);
    //         if (res.Count == 0)
    //             return NotFound(new ResponseDTO<string[]>(){
    //                 Message = ConstantConfigs.MESSAGE_NOT_FOUND("kategori"),
    //                 Status = ConstantConfigs.STATUS_NOT_FOUND,
    //                 Data = Array.Empty<string>()
    //             });

    //         return Ok(new ResponseWithPaginationDTO<List<CategoryResponseDTO>>(){
    //             Message = ConstantConfigs.MESSAGE_GET("kategori"),
    //             Status = ConstantConfigs.STATUS_OK,
    //             Data = res,
    //             Pagination = new PaginationDTO(){
    //                 Page = page,
    //                 PageSize = pageSize,
    //                 TotalData = _service.CountData(name),
    //             }
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }

    // [HttpGet("all")]
    // public IActionResult Get(){
    //     try
    //     {
    //         var res = _service.Get();
    //         if (res.Count == 0)
    //             return NotFound(new ResponseDTO<string[]>(){
    //                 Message = ConstantConfigs.MESSAGE_NOT_FOUND("kategori"),
    //                 Status = ConstantConfigs.STATUS_NOT_FOUND,
    //                 Data = Array.Empty<string>()
    //             });

    //         return Ok(new ResponseDTO<List<CategoryResponseDTO>>(){
    //             Message = ConstantConfigs.MESSAGE_GET("kategori"),
    //             Status = ConstantConfigs.STATUS_OK,
    //             Data = res,
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }

    // [HttpGet("{id}")]
    // public IActionResult GetDetail(string id){
    //     try
    //     {
    //         var res = _service.Get(id);
    //         if (res is null)
    //             return NotFound(new ResponseDTO<string>(){
    //                 Message = ConstantConfigs.MESSAGE_NOT_FOUND("kategori"),
    //                 Status = ConstantConfigs.STATUS_NOT_FOUND,
    //             });

    //         return Ok(new ResponseDTO<CategoryResponseDTO>(){
    //             Message = ConstantConfigs.MESSAGE_GET("kategori"),
    //             Status = ConstantConfigs.STATUS_OK,
    //             Data = new CategoryResponseDTO(){
    //                 Id = res.Id,
    //                 Name = res.Name,
    //             }
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }

    // [HttpPost]
    // public IActionResult Insert([FromBody] CategoryInsertDTO req){
    //     try
    //     {
    //         _service.Insert(req);
            
    //         return Ok(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_POST("kategori"),
    //             Status = ConstantConfigs.STATUS_OK
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }

    // [HttpPut("{id}")]
    // public IActionResult Update([FromBody] CategoryUpdateDTO req){
    //     try
    //     {
    //         _service.Update(req);
            
    //         return Ok(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_PUT("kategori"),
    //             Status = ConstantConfigs.STATUS_OK
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }

    // [HttpDelete("{id}")]
    // public IActionResult Delete(string id){
    //     try
    //     {
    //         _service.Delete(id);
            
    //         return Ok(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_DELETE("kategori"),
    //             Status = ConstantConfigs.STATUS_OK
    //         });
    //     }
    //     catch (System.Exception)
    //     {
    //         return BadRequest(new ResponseDTO<string>(){
    //             Message = ConstantConfigs.MESSAGE_FAILED,
    //             Status = ConstantConfigs.STATUS_FAILED,
    //         });
    //     }
    // }
}
