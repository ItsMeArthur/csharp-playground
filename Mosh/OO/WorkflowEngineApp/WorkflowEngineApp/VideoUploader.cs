using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class VideoUploader : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded.");
        }
    }
}
