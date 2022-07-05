using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    internal class Pipeline
    {
        private Handler handler;

        public Pipeline(Handler handler)
        {
            this.handler = handler;
        }

        public void Execute(PipelineRequest request)
        {
            handler.handle(request);
        }
    }
}
