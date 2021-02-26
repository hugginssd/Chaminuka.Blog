using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.MailService;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailController(IMailService mailService)
        {
            this._mailService = mailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequestViewModel request)
        {
            try
            {
                await _mailService.SendEmailAsync(request);
                var addmail = new MailRequest
                {
                    Id  = request.Id,
                    Name = request.Name,
                    ToEmail = request.ToEmail,
                    Body    = request.Body,
                    Subject = request.Subject
                };
                _mailService.AddMail(addmail);

                return RedirectToAction("Contact");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(request);
            }
            

        }
    }
}
