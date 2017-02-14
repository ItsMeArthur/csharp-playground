using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class Workflow : IWorkflow
    {
        public readonly List<IWorkflowActivity> _activities;

        public Workflow()
        {
            _activities = new List<IWorkflowActivity>();
        }

        public void Add(IWorkflowActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IWorkflowActivity> GetActivities()
        {
            return _activities;
        }

        public void Remove(IWorkflowActivity activity)
        {
            _activities.Remove(activity);
        }


    }
}
