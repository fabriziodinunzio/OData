using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }

        public string FullName { get => String.Concat(Nome, " ", Cognome); }
    }

    public class PersonEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;
            if (Object.ReferenceEquals(x, y))
            {
                return true;
            }
            return x.Id.Equals(y.Id);
        }

        public int GetHashCode(Person obj)
        {
            int idHashCode = obj.Id.GetHashCode();
            int nomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
            int cognomeHashCode = obj.Cognome == null ? 0 : obj.Cognome.GetHashCode();
            return idHashCode ^ nomeHashCode ^ cognomeHashCode;
        }
    }
}
