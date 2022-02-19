using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.Workflow.Shared.WFBase
{
    public interface ICreateMark
    {
        public T? CreateUserId { get; set; }
        public string? CreateUserName { get; set; }
    }
}
