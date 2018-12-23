

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


    }

    internal interface IContactRepository
    {
    }
}