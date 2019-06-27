using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    /// <summary>
    /// 备注信息1111
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// 主键备注
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
