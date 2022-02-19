using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.Workflow.Shared.WFBase
{
    public interface IModifyMark<T>
    {
        public string? ModifyUserName { get; set; }
        public T? ModifyUserId { get; set; }
    }
}
