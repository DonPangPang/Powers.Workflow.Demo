using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.Workflow.Shared.WFBase
{
    public abstract class WFEntityBase<T>
    {
        public T? Id { get; set; }
        public string? Name { get; set; }

        

        
    }
}
