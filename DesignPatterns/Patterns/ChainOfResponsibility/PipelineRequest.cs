using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.ChainOfResponsibility
{
    internal class PipelineRequest
    {

        private string data;

        public void setData(string data)
        {
            this.data = data;
        }

        public string getData()
        {
            return data;
        }
    }
}
