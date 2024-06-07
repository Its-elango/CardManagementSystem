using CardManagementSystem.Models;
using CardManagementSystem.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace CardManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardTransactionController : ControllerBase
    {
        private readonly ICardTransaction _cardTransaction;

        public CardTransactionController(ICardTransaction cardTransaction)
        {
            _cardTransaction = cardTransaction;
        }

        #region GET Methods

        [HttpGet("GetCardById")]
        public async Task<IActionResult> GetCardById([FromQuery] int cardId)
        {
            return Ok(await _cardTransaction.GetCardById(cardId));
        }

        [HttpGet("GetCardByCustomer")]
        public async Task<IActionResult> GetCardByCustomer([FromQuery] int CustomerId)
        {
            return Ok(await _cardTransaction.GetCardByCustomer(CustomerId));
        }

        [HttpGet("GetTransactions")]
        public async Task<IActionResult> GetTransactions([FromQuery]int? transactionId=null)
        {
            return Ok(await _cardTransaction.GetTransactions(transactionId));
        }
        [HttpGet("GetCustomer")]
        public async Task<IActionResult> GetCustomer([FromQuery] int? CustomerId = null)
        {
            return Ok(await _cardTransaction.GetCustomer(CustomerId));
        }



        #endregion GET Methods

        #region POST Methods

        [HttpPost("CreateCard")]
        public async Task<IActionResult> CreateCard([FromBody] Card card)
        {
            return Ok(await _cardTransaction.CreateCard(card));
        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            return Ok(await _cardTransaction.CreateCustomer(customer));

        }

        [HttpPost("CreateTransaction")]
        public async Task<IActionResult> CreateTransaction([FromBody] Transactions transaction)
        {
            return Ok(await _cardTransaction.CreateTransaction(transaction));
        }

        #endregion POST Methods

        #region PUT Methods

        [HttpPut("UpdateCardStatus")]
        public async Task<IActionResult> UpdateCardStatus([FromBody] CardStatus cardStatus)
        {
            return Ok(await _cardTransaction.UpdateCardStatus(cardStatus));
        }

        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] Customer customer)
        {
            return Ok(await _cardTransaction.UpdateCustomer(customer));
        }

        #endregion PUT Methods
    }
}
