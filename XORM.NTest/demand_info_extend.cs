using System;
using XORM.NBase;
using XORM.NBase.Attr;

namespace XORM.NTest
{
	/// <summary>
	/// 数据实体类:demand_info_extend
	/// </summary>
	[DbSource("DEMAND")]
	public class demand_info_extend : ModelBase<demand_info_extend>
	{
		#region 字段、属性
		/// <summary>
		/// 
		/// </summary>
		[AutoInCrement,PrimaryKey,DBCol]
		public Int64 id
		{
			get{ return this._id;}
			set{ this._id = value; ModifiedColumns.Add("[ID]"); }
		}
		private Int64 _id = 0L;
		/// <summary>
		/// 外键ID,报名主表ID
		/// </summary>
		[DBCol]
		public Int64 demandid
		{
			get{ return this._demandid;}
			set{ this._demandid = value; ModifiedColumns.Add("[DEMANDID]"); }
		}
		private Int64 _demandid = 0L;
		/// <summary>
		/// 伪删除标记，0否，1是
		/// </summary>
		[DBCol]
		public Int32 del
		{
			get{ return this._del;}
			set{ this._del = value; ModifiedColumns.Add("[DEL]"); }
		}
		private Int32 _del = 0;
		/// <summary>
		/// 预算金额(招标/完善)
		/// </summary>
		[DBCol]
		public double budget
		{
			get{ return this._budget;}
			set{ this._budget = value; ModifiedColumns.Add("[BUDGET]"); }
		}
		private double _budget = 0;
		/// <summary>
		/// 预算范围9:1.5以下,8:1.5万-3万以下,2:3万-5万,3:5万-10万以下,4:10万-15万以下,5:15万-20万以下,6:20万-30万以下,7:30万以上
		/// </summary>
		[DBCol]
		public Int32 budgetrange
		{
			get{ return this._budgetrange;}
			set{ this._budgetrange = value; ModifiedColumns.Add("[BUDGETRANGE]"); }
		}
		private Int32 _budgetrange = 0;
		/// <summary>
		/// 预算金额(招标/完善)
		/// </summary>
		[DBCol]
		public double budgetwithoutfurniture
		{
			get{ return this._budgetwithoutfurniture;}
			set{ this._budgetwithoutfurniture = value; ModifiedColumns.Add("[BUDGETWITHOUTFURNITURE]"); }
		}
		private double _budgetwithoutfurniture = 0;
		/// <summary>
		/// 装修方式，1全包，2半包(完善)
		/// </summary>
		[DBCol]
		public Int32 way
		{
			get{ return this._way;}
			set{ this._way = value; ModifiedColumns.Add("[WAY]"); }
		}
		private Int32 _way = 0;
		/// <summary>
		/// 户型，1一居，2二居，3三居，0其他(招标/完善)
		/// </summary>
		[DBCol]
		public Int32 layout
		{
			get{ return this._layout;}
			set{ this._layout = value; ModifiedColumns.Add("[LAYOUT]"); }
		}
		private Int32 _layout = 0;
		/// <summary>
		/// 邮箱地址(招标)
		/// </summary>
		[DBCol]
		public string email
		{
			get{ return this._email;}
			set{ this._email = value; ModifiedColumns.Add("[EMAIL]"); }
		}
		private string _email = "";
		/// <summary>
		/// 偏好风格,1现代简约，2田园风格，3中式古典，4西式古典，5欧美风格，6东南亚风格，7混合型风格，8日韩风格，9中式风格，10简欧风格，11新古典风格，12混搭风格，13地中海风格，14其他(招标/完善)
		/// </summary>
		[DBCol]
		public Int32 style
		{
			get{ return this._style;}
			set{ this._style = value; ModifiedColumns.Add("[STYLE]"); }
		}
		private Int32 _style = 0;
		/// <summary>
		/// 建筑面积(招标/完善)
		/// </summary>
		[DBCol]
		public double area
		{
			get{ return this._area;}
			set{ this._area = value; ModifiedColumns.Add("[AREA]"); }
		}
		private double _area = 0;
		/// <summary>
		/// 备注信息(招标)
		/// </summary>
		[DBCol]
		public string remark
		{
			get{ return this._remark;}
			set{ this._remark = value; ModifiedColumns.Add("[REMARK]"); }
		}
		private string _remark = "";
		/// <summary>
		/// 1.整装,2.局装(完善)
		/// </summary>
		[DBCol]
		public Int32 type
		{
			get{ return this._type;}
			set{ this._type = value; ModifiedColumns.Add("[TYPE]"); }
		}
		private Int32 _type = 0;
		/// <summary>
		/// 1.新房,2.旧房(完善)
		/// </summary>
		[DBCol]
		public Int32 housetype
		{
			get{ return this._housetype;}
			set{ this._housetype = value; ModifiedColumns.Add("[HOUSETYPE]"); }
		}
		private Int32 _housetype = 0;
		/// <summary>
		/// 装修时间1.半月内,2一月内,3二月内,4二月以上(完善)
		/// </summary>
		[DBCol]
		public Int32 decorationtime
		{
			get{ return this._decorationtime;}
			set{ this._decorationtime = value; ModifiedColumns.Add("[DECORATIONTIME]"); }
		}
		private Int32 _decorationtime = 0;
		#endregion
	}
}