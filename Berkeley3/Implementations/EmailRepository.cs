using Berkeley3.Domain;
using Berkeley3.Interfaces;
using System.Collections.Generic;

namespace Berkeley3.Implementations
{
    public class EmailRepository : IEmailRepository
    {
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Email GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Email Insert(Email entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Email> List()
        {
            return new List<Email>() { new Email { Address = "matthew@claygate.com" }, new Email { Address = "bertie@claygatek9s.com" }, new Email { Address = "ruby@esherk9s.com" } , new Email { Address = "dexter@waltonk9s.com" } };
        }

        public void Update(Email entity)
        {
            throw new System.NotImplementedException();
        }
    }
}