using System;
using XORM.NBase;
using XORM.NBase.Attr;

namespace Db.Ebs.Model
{
	/// <summary>
	/// ����ʵ����:Admin_UserInfo
	/// </summary>
	[DbSource("EBS")]
	public class Admin_UserInfo : ModelBase<Admin_UserInfo>
	{
		#region �ֶΡ�����
		/// <summary>
		/// ����Ա����
		/// </summary>
		[AutoInCrement,PrimaryKey,DBCol]
		public Int32 ID
		{
			get{ return this._ID;}
			set{ this._ID = value; ModifiedColumns.Add("[ID]"); }
		}
		private Int32 _ID = 0;
		/// <summary>
		/// ����Ա��¼��
		/// </summary>
		[DBCol]
		public string UserName
		{
			get{ return this._UserName;}
			set{ this._UserName = value; ModifiedColumns.Add("[USERNAME]"); }
		}
		private string _UserName = "";
		/// <summary>
		/// ����Ա���룬MD5���ܺ��д
		/// </summary>
		[DBCol]
		public string Password
		{
			get{ return this._Password;}
			set{ this._Password = value; ModifiedColumns.Add("[PASSWORD]"); }
		}
		private string _Password = "";
		/// <summary>
		/// ��ʵ����
		/// </summary>
		[DBCol]
		public string TrueName
		{
			get{ return this._TrueName;}
			set{ this._TrueName = value; ModifiedColumns.Add("[TRUENAME]"); }
		}
		private string _TrueName = "";
		/// <summary>
		/// ����ID�����ŷָ�
		/// </summary>
		[DBCol]
		public string CityID
		{
			get{ return this._CityID;}
			set{ this._CityID = value; ModifiedColumns.Add("[CITYID]"); }
		}
		private string _CityID = "";
		/// <summary>
		/// �������ƣ����ŷָ�
		/// </summary>
		[DBCol]
		public string CityName
		{
			get{ return this._CityName;}
			set{ this._CityName = value; ModifiedColumns.Add("[CITYNAME]"); }
		}
		private string _CityName = "";
		/// <summary>
		/// ��ɫ����
		/// </summary>
		[DBCol]
		public Int32 RoleId
		{
			get{ return this._RoleId;}
			set{ this._RoleId = value; ModifiedColumns.Add("[ROLEID]"); }
		}
		private Int32 _RoleId = 0;
		/// <summary>
		/// ��ɫ��
		/// </summary>
		[DBCol]
		public string RoleName
		{
			get{ return this._RoleName;}
			set{ this._RoleName = value; ModifiedColumns.Add("[ROLENAME]"); }
		}
		private string _RoleName = "";
		/// <summary>
		/// �Ŷ�ID
		/// </summary>
		[DBCol]
		public Int32 GroupId
		{
			get{ return this._GroupId;}
			set{ this._GroupId = value; ModifiedColumns.Add("[GROUPID]"); }
		}
		private Int32 _GroupId = 0;
		/// <summary>
		/// �Ŷ����ƣ�Admin_GroupInfo��GroupName
		/// </summary>
		[DBCol]
		public string GroupName
		{
			get{ return this._GroupName;}
			set{ this._GroupName = value; ModifiedColumns.Add("[GROUPNAME]"); }
		}
		private string _GroupName = "";
		/// <summary>
		/// �û����ͣ�0�ڲ���1�ⲿ
		/// </summary>
		[DBCol]
		public Int32 UserType
		{
			get{ return this._UserType;}
			set{ this._UserType = value; ModifiedColumns.Add("[USERTYPE]"); }
		}
		private Int32 _UserType = 0;
		/// <summary>
		/// ��˾ID
		/// </summary>
		[DBCol]
		public Int32 CompanyId
		{
			get{ return this._CompanyId;}
			set{ this._CompanyId = value; ModifiedColumns.Add("[COMPANYID]"); }
		}
		private Int32 _CompanyId = 0;
		/// <summary>
		/// ��˾����
		/// </summary>
		[DBCol]
		public string CompanyName
		{
			get{ return this._CompanyName;}
			set{ this._CompanyName = value; ModifiedColumns.Add("[COMPANYNAME]"); }
		}
		private string _CompanyName = "";
		/// <summary>
		/// ״̬��1��Ч��0��Ч
		/// </summary>
		[DBCol]
		public Int32 Status
		{
			get{ return this._Status;}
			set{ this._Status = value; ModifiedColumns.Add("[STATUS]"); }
		}
		private Int32 _Status = 0;
		/// <summary>
		/// Logo��ַ
		/// </summary>
		[DBCol]
		public string LogoUrl
		{
			get{ return this._LogoUrl;}
			set{ this._LogoUrl = value; ModifiedColumns.Add("[LOGOURL]"); }
		}
		private string _LogoUrl = "";
		/// <summary>
		/// ��������
		/// </summary>
		[DBCol]
		public string EMail
		{
			get{ return this._EMail;}
			set{ this._EMail = value; ModifiedColumns.Add("[EMAIL]"); }
		}
		private string _EMail = "";
		/// <summary>
		/// �ֻ�����
		/// </summary>
		[DBCol]
		public string Mobile
		{
			get{ return this._Mobile;}
			set{ this._Mobile = value; ModifiedColumns.Add("[MOBILE]"); }
		}
		private string _Mobile = "";
		/// <summary>
		/// ��һ�ε�¼ʱ��
		/// </summary>
		[DBCol]
		public DateTime LastLoginTime
		{
			get{ return this._LastLoginTime;}
			set{ this._LastLoginTime = value; ModifiedColumns.Add("[LASTLOGINTIME]"); }
		}
		private DateTime _LastLoginTime = DateTime.Now;
		/// <summary>
		/// ����ʱ��
		/// </summary>
		[DBCol]
		public DateTime CreateTime
		{
			get{ return this._CreateTime;}
			set{ this._CreateTime = value; ModifiedColumns.Add("[CREATETIME]"); }
		}
		private DateTime _CreateTime = DateTime.Now;
		/// <summary>
		/// �Ƿ�ɾ����0��1��
		/// </summary>
		[DBCol]
		public Int32 IsDel
		{
			get{ return this._IsDel;}
			set{ this._IsDel = value; ModifiedColumns.Add("[ISDEL]"); }
		}
		private Int32 _IsDel = 0;
		/// <summary>
		/// ����Ȩ�޼���0���ˣ�1����˾��2���Ŷӣ�3ָ���Ŷӣ�4������
		/// </summary>
		[DBCol]
		public Int32 DataLevel
		{
			get{ return this._DataLevel;}
			set{ this._DataLevel = value; ModifiedColumns.Add("[DATALEVEL]"); }
		}
		private Int32 _DataLevel = 0;
		/// <summary>
		/// ��ͨ1,�߼�2
		/// </summary>
		[DBCol]
		public Int32 UserLevel
		{
			get{ return this._UserLevel;}
			set{ this._UserLevel = value; ModifiedColumns.Add("[USERLEVEL]"); }
		}
		private Int32 _UserLevel = 0;
		/// <summary>
		/// DataLevelΪָ���Ŷ�ʱ��Ч,�ֺŸ���
		/// </summary>
		[DBCol]
		public string GroupLevels
		{
			get{ return this._GroupLevels;}
			set{ this._GroupLevels = value; ModifiedColumns.Add("[GROUPLEVELS]"); }
		}
		private string _GroupLevels = "";
		/// <summary>
		/// �Ƿ�����û���0��1��
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