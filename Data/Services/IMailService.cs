using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Data.MailService
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequestViewModel mailRequest);

        void AddMail(MailRequest mailrequest);
       
    }
}
