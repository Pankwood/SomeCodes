using Company.DomainModels;
using System.Collections.Generic;

namespace Company.DataAcess
{
    public class ValueDATA
    {
        public IEnumerable<Value> getValue()
        {
            Context dc = new Context();

            dc.Value.Add(new Value { ID = "1", Description = "Description01" });
            dc.Value.Add(new Value { ID = "2", Description = "Description02" });
            dc.Value.Add(new Value { ID = "3", Description = "Description03" });

            return dc.Value.Local;
            

        }

        public Value getValueByID(string id)
        {
            Context dc = new Context();

            dc.Value.Add(new Value { ID = "1", Description = "Description01" });
            dc.Value.Add(new Value { ID = "2", Description = "Description02" });
            dc.Value.Add(new Value { ID = "3", Description = "Description03" });


            return dc.Value.Find(id);


        }

        public IEnumerable<Value> postValue(Value pValue)
        {
            Context dc = new Context();

            dc.Value.Add(new Value { ID = "1", Description = "Description01" });
            dc.Value.Add(new Value { ID = "2", Description = "Description02" });
            dc.Value.Add(new Value { ID = "3", Description = "Description03" });
            dc.Value.Add(pValue);


            return dc.Value.Local;


        }

        public IEnumerable<Value> putValue(string id, Value pValue)
        {
            Context dc = new Context();

            dc.Value.Add(new Value { ID = "1", Description = "Description01" });
            dc.Value.Add(new Value { ID = "2", Description = "Description02" });
            dc.Value.Add(new Value { ID = "3", Description = "Description03" });

            if (dc.Value.Find(id) != null)
            {
                dc.Value.Remove(dc.Value.Find(id));
                dc.Value.Add(pValue);
            }


            return dc.Value.Local;


        }

        public IEnumerable<Value> deleteValue(string id)
        {
            Context dc = new Context();

            dc.Value.Add(new Value { ID = "1", Description = "Description01" });
            dc.Value.Add(new Value { ID = "2", Description = "Description02" });
            dc.Value.Add(new Value { ID = "3", Description = "Description03" });

            if (dc.Value.Find(id) != null)
              dc.Value.Remove(dc.Value.Find(id));

            return dc.Value.Local;


        }
    }
}
