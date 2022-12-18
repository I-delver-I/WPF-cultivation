using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLogic
{
    public interface ICowDatabase
    {
        public void Insert(CowModel cow);
        public void Delete(CowModel cow);
        public void Update(CowModel cow);
        public CowModel Find(Guid id);
        public IEnumerable<CowModel> FindBy(string breed, int age);
    }
}