using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.ViewModels
{
    public class MailRequestViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ToEmail { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Body { get; set; } = "";
        [NotMapped]
        public List<IFormFile> Attachments { get; set; } = null;
    }
}
