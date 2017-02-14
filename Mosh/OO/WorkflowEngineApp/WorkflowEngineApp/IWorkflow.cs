using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public interface IWorkflow
    {
        void Add(IWorkflowActivity activity);
        void Remove(IWorkflowActivity activity);
        IEnumerable<IWorkflowActivity> GetActivities();
    }
}
