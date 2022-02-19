using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.Workflow.Shared.WFBase
{
    /// <summary>
    /// 是否需要进入流程
    /// </summary>
    /// <typeparam name="T">流程状态</typeparam>
    public interface INeedWf<T> where T : Enum
    {
        /// <summary>
        /// 是否需要流程
        /// </summary>
        public bool IsNeedWf { get; set; }
        /// <summary>
        /// 流程是否结束
        /// </summary>
        public bool IsEnd { get; set; }
        /// <summary>
        /// 流程流转状态
        /// </summary>
        public T State { get; set; }
    }
}
