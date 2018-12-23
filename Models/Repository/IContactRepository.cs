
using Phonebook;
using Phonebook.Models;
using System;
using System.Collections.Generic;

namespace Contacts
{
    public interface IContactRepository : IRepositoryBase<Phonebook.Models.Contacts>
    {
    }
}
