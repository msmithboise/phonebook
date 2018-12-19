using System;
using System.Collections.Generic;

namespace Phonebook.Models
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
