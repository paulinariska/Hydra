using HydraAPI.DTOs.Candidate;
using HydraAPI.Services;
using HydraDataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HydraAPI.Controllers;

// [Authorize]
[ApiController]
[Route("api/v1/candidate")]
public class CandidateController : ControllerBase
{
    private readonly CandidateService _service;

    public CandidateController(CandidateService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get(int pageNumber, int pageSize, int batchBootcamp, string fullName="")
    {
        try
        {
            var cand = _service.Get(pageNumber, pageSize, fullName, batchBootcamp);
            if (cand.Count == 0){
                return NotFound(new ResponseDTO<string[]>(){
                    Message = ConstantConfigs.MESSAGE_NOT_FOUND("kandidat"),
                    Status = ConstantConfigs.STATUS_NOT_FOUND,
                    Data = Array.Empty<string>()
                });
            }

            return Ok(new ResponseWithPaginationDTO<List<CandidateResponseDTO>>(){
                Message = ConstantConfigs.MESSAGE_GET("kandidat"),
                Status = ConstantConfigs.STATUS_OK,
                Data = cand,
                Pagination = new PaginationDTO(){
                    Page = pageNumber,
                    PageSize = pageSize,
                    TotalData = _service.Count(fullName, batchBootcamp)
                }

            });
        }catch(System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpPost]
    public IActionResult Insert(CandidateInsertDTO dto)
    {
        try{
            _service.Insert(dto);

            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_POST("kandidat"),
                Status = ConstantConfigs.STATUS_OK
            });
        }catch (System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
            Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpPut("id")]
    public IActionResult Update(CandidateUpdateDTO dto)
    {
        try{
            _service.Update(dto);
            
            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_PUT("kandidat"),
                Status = ConstantConfigs.STATUS_OK
            });
        }catch (System.Exception)
        {
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        try{
            _service.Delete(id);

            return Ok(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_DELETE("kandidat"),
                Status = ConstantConfigs.STATUS_OK
            });
        }catch (System.Exception){
            return BadRequest(new ResponseDTO<string>(){
                Message = ConstantConfigs.MESSAGE_FAILED,
                Status = ConstantConfigs.STATUS_FAILED
            });
        }
    }
}
