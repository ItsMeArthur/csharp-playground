using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            IEnumerable<IWorkflowActivity> activities = workflow.GetActivities();

            foreach (var item in activities)
            {
                item.Execute();
            }
        }
    }
}
