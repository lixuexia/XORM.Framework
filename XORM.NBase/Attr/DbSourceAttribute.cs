using System;
using System.ComponentModel;

namespace XORM.NBase.Attr
{
    /// <summary>
    /// 标记特性:用于标记数据源配置节点名称，如：EBS
    /// </summary>
    [Description("标记特性，用于标记数据源配置节点名称，如：EBS")]
    public class DbSourceAttribute : Attribute
    {
        public DbSourceAttribute(string _DbConnMark)
        {
            DbConnectionMark = _DbConnMark;
        }
        /// <summary>
        /// 数据源配置节点名称，如：EBS
        /// </summary>
        public string DbConnectionMark { get; private set; }
    }
}