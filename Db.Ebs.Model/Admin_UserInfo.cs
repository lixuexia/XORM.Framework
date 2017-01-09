using System;
using XORM.NBase;
using XORM.NBase.Attr;

namespace Db.Ebs.Model
{
	/// <summary>
	/// 数据实体类:Admin_UserInfo
	/// </summary>
	[DbSource("EBS")]
	public class Admin_UserInfo : ModelBase<Admin_UserInfo>
	{
		#region 字段、属性
		/// <summary>
		/// 管理员编码
		/// </summary>
		[AutoInCrement,PrimaryKey,DBCol]
		public Int32 ID
		{
			get{ return this._ID;}
			set{ this._ID = value; ModifiedColumns.Add("[ID]"); }
		}
		private Int32 _ID = 0;
		/// <summary>
		/// 管理员登录名
		/// </summary>
		[DBCol]
		public string UserName
		{
			get{ return this._UserName;}
			set{ this._UserName = value; ModifiedColumns.Add("[USERNAME]"); }
		}
		private string _UserName = "";
		/// <summary>
		/// 管理员密码，MD5加密后大写
		/// </summary>
		[DBCol]
		public string Password
		{
			get{ return this._Password;}
			set{ this._Password = value; ModifiedColumns.Add("[PASSWORD]"); }
		}
		private string _Password = "";
		/// <summary>
		/// 真实姓名
		/// </summary>
		[DBCol]
		public string TrueName
		{
			get{ return this._TrueName;}
			set{ this._TrueName = value; ModifiedColumns.Add("[TRUENAME]"); }
		}
		private string _TrueName = "";
		/// <summary>
		/// 城市ID，逗号分割
		/// </summary>
		[DBCol]
		public string CityID
		{
			get{ return this._CityID;}
			set{ this._CityID = value; ModifiedColumns.Add("[CITYID]"); }
		}
		private string _CityID = "";
		/// <summary>
		/// 城市名称，逗号分割
		/// </summary>
		[DBCol]
		public string CityName
		{
			get{ return this._CityName;}
			set{ this._CityName = value; ModifiedColumns.Add("[CITYNAME]"); }
		}
		private string _CityName = "";
		/// <summary>
		/// 角色编码
		/// </summary>
		[DBCol]
		public Int32 RoleId
		{
			get{ return this._RoleId;}
			set{ this._RoleId = value; ModifiedColumns.Add("[ROLEID]"); }
		}
		private Int32 _RoleId = 0;
		/// <summary>
		/// 角色名
		/// </summary>
		[DBCol]
		public string RoleName
		{
			get{ return this._RoleName;}
			set{ this._RoleName = value; ModifiedColumns.Add("[ROLENAME]"); }
		}
		private string _RoleName = "";
		/// <summary>
		/// 团队ID
		/// </summary>
		[DBCol]
		public Int32 GroupId
		{
			get{ return this._GroupId;}
			set{ this._GroupId = value; ModifiedColumns.Add("[GROUPID]"); }
		}
		private Int32 _GroupId = 0;
		/// <summary>
		/// 团队名称，Admin_GroupInfo表GroupName
		/// </summary>
		[DBCol]
		public string GroupName
		{
			get{ return this._GroupName;}
			set{ this._GroupName = value; ModifiedColumns.Add("[GROUPNAME]"); }
		}
		private string _GroupName = "";
		/// <summary>
		/// 用户类型，0内部，1外部
		/// </summary>
		[DBCol]
		public Int32 UserType
		{
			get{ return this._UserType;}
			set{ this._UserType = value; ModifiedColumns.Add("[USERTYPE]"); }
		}
		private Int32 _UserType = 0;
		/// <summary>
		/// 公司ID
		/// </summary>
		[DBCol]
		public Int32 CompanyId
		{
			get{ return this._CompanyId;}
			set{ this._CompanyId = value; ModifiedColumns.Add("[COMPANYID]"); }
		}
		private Int32 _CompanyId = 0;
		/// <summary>
		/// 公司名称
		/// </summary>
		[DBCol]
		public string CompanyName
		{
			get{ return this._CompanyName;}
			set{ this._CompanyName = value; ModifiedColumns.Add("[COMPANYNAME]"); }
		}
		private string _CompanyName = "";
		/// <summary>
		/// 状态，1有效，0无效
		/// </summary>
		[DBCol]
		public Int32 Status
		{
			get{ return this._Status;}
			set{ this._Status = value; ModifiedColumns.Add("[STATUS]"); }
		}
		private Int32 _Status = 0;
		/// <summary>
		/// Logo地址
		/// </summary>
		[DBCol]
		public string LogoUrl
		{
			get{ return this._LogoUrl;}
			set{ this._LogoUrl = value; ModifiedColumns.Add("[LOGOURL]"); }
		}
		private string _LogoUrl = "";
		/// <summary>
		/// 电子邮箱
		/// </summary>
		[DBCol]
		public string EMail
		{
			get{ return this._EMail;}
			set{ this._EMail = value; ModifiedColumns.Add("[EMAIL]"); }
		}
		private string _EMail = "";
		/// <summary>
		/// 手机号码
		/// </summary>
		[DBCol]
		public string Mobile
		{
			get{ return this._Mobile;}
			set{ this._Mobile = value; ModifiedColumns.Add("[MOBILE]"); }
		}
		private string _Mobile = "";
		/// <summary>
		/// 上一次登录时间
		/// </summary>
		[DBCol]
		public DateTime LastLoginTime
		{
			get{ return this._LastLoginTime;}
			set{ this._LastLoginTime = value; ModifiedColumns.Add("[LASTLOGINTIME]"); }
		}
		private DateTime _LastLoginTime = DateTime.Now;
		/// <summary>
		/// 创建时间
		/// </summary>
		[DBCol]
		public DateTime CreateTime
		{
			get{ return this._CreateTime;}
			set{ this._CreateTime = value; ModifiedColumns.Add("[CREATETIME]"); }
		}
		private DateTime _CreateTime = DateTime.Now;
		/// <summary>
		/// 是否删除，0否，1是
		/// </summary>
		[DBCol]
		public Int32 IsDel
		{
			get{ return this._IsDel;}
			set{ this._IsDel = value; ModifiedColumns.Add("[ISDEL]"); }
		}
		private Int32 _IsDel = 0;
		/// <summary>
		/// 数据权限级别，0本人，1本公司，2本团队，3指定团队，4本部门
		/// </summary>
		[DBCol]
		public Int32 DataLevel
		{
			get{ return this._DataLevel;}
			set{ this._DataLevel = value; ModifiedColumns.Add("[DATALEVEL]"); }
		}
		private Int32 _DataLevel = 0;
		/// <summary>
		/// 普通1,高级2
		/// </summary>
		[DBCol]
		public Int32 UserLevel
		{
			get{ return this._UserLevel;}
			set{ this._UserLevel = value; ModifiedColumns.Add("[USERLEVEL]"); }
		}
		private Int32 _UserLevel = 0;
		/// <summary>
		/// DataLevel为指定团队时有效,分号隔开
		/// </summary>
		[DBCol]
		public string GroupLevels
		{
			get{ return this._GroupLevels;}
			set{ this._GroupLevels = value; ModifiedColumns.Add("[GROUPLEVELS]"); }
		}
		private string _GroupLevels = "";
		/// <summary>
		/// 是否测试用户，0否，1是
		/// </summary>
		[DBCol]
		public Int32 IsTestUser
		{
			get{ return this._IsTestUser;}
			set{ this._IsTestUser = value; ModifiedColumns.Add("[ISTESTUSER]"); }
		}
		private Int32 _IsTestUser = 0;
		#endregion
	}
}