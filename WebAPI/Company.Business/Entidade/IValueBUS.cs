using Company.DomainModels;
using System.Collections.Generic;

namespace Company.Business.Entidade
{
    public abstract  class IValueBUS
    {
           
        public abstract  IEnumerable<Value> Get();

      
        public abstract Value GetByID(string id);


        public abstract IEnumerable<Value> Post(Value value);


        public abstract IEnumerable<Value> Put(string id, Value value);


        public abstract IEnumerable<Value> Delete(string id);
    }
}
