using Company.Business.Entidade;
using Company.DataAcess;
using Company.DomainModels;
using System.Collections.Generic;

namespace Company.Business
{
    public class ValueBUS : IValueBUS
    {
        public override IEnumerable<Value> Get()
        {

            ValueDATA vData = new ValueDATA();

            var values = vData.getValue();

            return values;

        }

        public override Value GetByID(string id)
        {
            ValueDATA vData = new ValueDATA();

            var values = vData.getValueByID(id);

            return values;
        }

        public override IEnumerable<Value> Post(Value pValue)
        {
            ValueDATA vData = new ValueDATA();

            var value = vData.postValue(pValue);

            return value;
        }

        public override IEnumerable<Value> Put(string id, Value pValue)
        {
            ValueDATA vData = new ValueDATA();

            var value = vData.putValue(id, pValue);

            return value;
        }

        public override IEnumerable<Value> Delete(string id)
        {
            ValueDATA vData = new ValueDATA();

            var value = vData.deleteValue(id);

            return value;
        }
    }
}
