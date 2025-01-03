﻿using AutoMapper;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.TransactionViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JewelryStoreManagement.Controllers;

[ApiController]
[Route("Transaction")]
public class TransactionController : Controller
{
    private readonly ITransactionService _transaction;
    private readonly IMapper _mapper;

    public TransactionController(ITransactionService transaction, IMapper mapper)
    {
        _transaction = transaction;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("GetAllTransaction")]
    // 
    public async Task<IActionResult> GetAllTransaction()
    {
        var transactions = await _transaction.GetAllTransactions();
        
        var result = _mapper.Map<ICollection<GetAllTransaction>>(transactions);
        return Ok(result);
    }

    [HttpGet]
    [Route("GetTransactionById/{transactionId}")]
    //Authorize 
    public async Task<IActionResult> GetTransactionById(Guid transactionId)
    {
        var transaction = await _transaction.GetTransactionsByTransactionId(transactionId);
        if (transaction.PointMinus == 0)
        {
            return Ok(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Transaction not found!"
            });
        }
        else
        {
            return Ok(transaction);
        }
    }

    [HttpPost]
    [Route("ExchangeGiftUser")]
    // 
    public async Task<IActionResult> ExchangeGiftUser(Guid customerId, Guid giftId)
    {
        var result = await _transaction.ExchangeGiftUser(customerId, giftId);
        if (result != "")
        {
            return BadRequest(result);
        }
        else
        {
            return Ok("Make request successfully");
        }
    }

    [HttpGet]
    [Route("GetTransactionByCustomerId/{customerId}")]
    public async Task<IActionResult> GetTransactionByCustomerId(Guid customerId)
    {
        var transaction = await _transaction.GetTransactionsByCustomerId(customerId);
        if (transaction.Count == 0)
        {
            return Ok(new ApiResponse
            {
                IsSuccess = false,
                Data = null,
                Message = "Transaction of this customer not found!"
            });
        }
        else
        {
            return Ok(transaction);
        }
    }
    
    
}