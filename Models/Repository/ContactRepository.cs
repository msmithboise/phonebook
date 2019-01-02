

using System.Collections.Generic;
using Phonebook;
using Phonebook.Models;


namespace Repository
{
    public class ContactRepository : RepositoryBase<Phonebook.Models.Contacts>, IContactRepository
    {
        public ContactRepository(Phonebook11Context repositoryContext)
            : base(repositoryContext)
        {

        }

        public Contact UpdateContact(Contact updatedContact)
        {
        return null;
        }

        public IEnumerable<Phonebook.Models.Contacts> GetAllContacts()
        {
        return Phonebook11Context.Contacts;
        }

        public Phonebook11Context Phonebook11Context
        {
            get {return Context as Phonebook11Context;}
        }
    }

    internal interface IContactRepository
    {
    }
}