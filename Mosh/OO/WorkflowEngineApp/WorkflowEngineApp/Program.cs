using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow flow = new Workflow();
            flow.Add(new VideoUploader());
            flow.Add(new VideoConverter());
            flow.Add(new MailSender());

            WorkflowEngine engine = new WorkflowEngine();
            engine.Run(flow);
        }
    }
}
