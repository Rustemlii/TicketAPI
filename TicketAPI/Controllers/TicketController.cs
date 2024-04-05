using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicket _ticket;

        public TicketController(ITicket ticket)
        {
            _ticket = ticket;
        }
        [HttpGet]
        public IActionResult TicketGet()
        {
            var values=_ticket.GetAll();
            return Ok(values);
        }
        [HttpGet("id")]
        public IActionResult TicketByID(int id)
        {
            var values=_ticket.GetbyId(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult TicketInsert(TicketDTO dto)
        {
            var answer = "Succesfully Added";
            _ticket.Insert(dto);
            return Ok(answer);
        }
        [HttpPut]
        public IActionResult TicketUpdate(TicketDTO dto,int id)
        {
            var values = _ticket.GetbyId(id);
            _ticket.Update(dto);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult TicketDelete(int id)
        {
            var answer = "Deleted";
            _ticket.Delete(id);
            return Ok(answer);
        }
    }
}
