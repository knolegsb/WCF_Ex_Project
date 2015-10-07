using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        #region IEvalService Members
        public List<Eval> GetEvals()
        {
            throw new NotImplementedException();
        }

        public void RemoveEval(string id)
        {
            throw new NotImplementedException();
        }

        public void SubmitEval(Eval eval)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
