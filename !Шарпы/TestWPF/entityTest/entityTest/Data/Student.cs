using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityTest.Data
{
    internal sealed class Student
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Username { get; set; }
        
        // SHA-256
        [MaxLength(64)]
        public string Password { get; set; }

        // MaxLength by Gmail, Outlook and other
        [MaxLength(254)] 
        public string Email { get; set; }

        //List<Group> Groups { get; set; }

        Student() { }
    }
}
