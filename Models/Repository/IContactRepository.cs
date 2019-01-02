// this interface derives from our generic repository interface so it will inherit all operations like add , getall , remove ect, but
// also declares new methods

// so youre going to execute the query inside the repo and return a list of objects to the client

using Phonebook;
using Phonebook.Models;
using System;
using System.Collections.Generic;

namespace Contacts
{
    public interface IContactRepository : IRepositoryBase<Phonebook.Models.Contacts>
    {
      IEnumerable<Phonebook.Models.Contacts> GetAllContacts();  
    }
}
