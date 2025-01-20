using Ardalis.Result;
using FinanceMan.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using FinanceMan.Server.Dtos;

namespace FinanceMan.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController(TransactionService transactionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions(int userId, 
            [Required] int page = 1, [Required] int pageSize = 10)
        {
            var result = await transactionService.GetAllUserTransactions(userId);
            if (result.IsNotFound())
            {
                return NotFound(new ApiResponse<List<TransactionDto>>()
                {
                    Data = null,
                    StatusCode = HttpStatusCode.NotFound,
                    Title = "Transactions not found",
                    Detail = $"No transactions found for user {userId}",
                });
            }

            return Ok(new ApiResponse<List<TransactionDto>>()
            {
                Data = result.Value.Select(x=> x.ToDto()).ToList(),
                StatusCode = HttpStatusCode.OK,
                Title = "All transactions",
                Detail = $"Page {page} of {pageSize}",
                Errors = null
            });
        }
    }
}
