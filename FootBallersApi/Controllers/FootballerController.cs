using FootBallersApi.DTOs;
using FootBallersApi.Models;
using FootBallersApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootBallersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FootballerController : Controller
    {
        private readonly IFootballerService _footballerService;
        public FootballerController(IFootballerService footballerService)
        {
            _footballerService = footballerService;
        }

        [HttpGet("GetAllFootballer")]
        public ApiResponse<List<FootballerDto>> GetAllFootballer()
        {
            return new ApiResponse<List<FootballerDto>>(
                success: true,
                message: "Footballers retrieved successfully",
                data: _footballerService.GetFootballers());
        }

        [HttpGet("GetFootballerById/{id}")]

        public ApiResponse<FootballerDto> GetFootballerById(int id)
        {
            var footballer = _footballerService.GetFootballerById(id);
            if (footballer == null)
            {
                return new ApiResponse<FootballerDto>(
                    success: false,
                    message: "Footballer not found");
            }
            return new ApiResponse<FootballerDto>(
                success: true,
                message: "Footballer retrieved successfully",
                data: footballer);
        }

        [HttpPost("CreateFootballer")]
        public ApiResponse<FootballerDto> CreateFootballer([FromBody] FootballerDto footballerDto)
        {
            var footballer = _footballerService.CreateFootballer(footballerDto);
            return new ApiResponse<FootballerDto>(
                success: true,
                message: "Footballer created successfully",
                data: footballer);
        }

        [HttpPut("UpdateFootballer/{id}")]
        public ApiResponse<FootballerDto> UpdateFootballer(int id, [FromBody] FootballerDto footballerDto)
        {
            var footballer = _footballerService.UpdateFootballer(id, footballerDto);
            if (footballer == null)
            {
                return new ApiResponse<FootballerDto>(
                    success: false,
                    message: "Footballer not found");
            }
            return new ApiResponse<FootballerDto>(
                success: true,
                message: "Footballer updated successfully",
                data: footballer);
        }

        [HttpDelete("DeleteFootballer/{id}")]
        public ApiResponse<FootballerDto> DeleteFootballer(int id)
        {
            _footballerService.DeleteFootballer(id);
            return new ApiResponse<FootballerDto>(
                success: true,
                message: "Footballer deleted successfully");
        }
    }
}
