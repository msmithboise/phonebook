using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    [Table("contacts")]
    public class Contacts
    {
        

        public int ContactId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public interface IContactRepository
        {
        }
    }
}
