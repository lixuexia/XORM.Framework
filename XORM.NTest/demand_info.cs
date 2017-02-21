using System;
using XORM.NBase;
using XORM.NBase.Attr;

namespace XORM.NTest
{
	/// <summary>
	/// ����ʵ����:demand_info
	/// </summary>
	[DbSource("DEMAND")]
	public class demand_info : ModelBase<demand_info>
	{
		#region �ֶΡ�����
		/// <summary>
		/// ԭʼ�����������
		/// </summary>
		[AutoInCrement,PrimaryKey,DBCol]
		public Int64 id
		{
			get{ return this._id;}
			set{ this._id = value; ModifiedColumns.Add("[ID]"); }
		}
		private Int64 _id = 0L;
		/// <summary>
		/// ��ʵ����
		/// </summary>
		[DBCol]
		public string truename
		{
			get{ return this._truename;}
			set{ this._truename = value; ModifiedColumns.Add("[TRUENAME]"); }
		}
		private string _truename = "";
		/// <summary>
		/// �ֻ�����
		/// </summary>
		[DBCol]
		public string mobile
		{
			get{ return this._mobile;}
			set{ this._mobile = value; ModifiedColumns.Add("[MOBILE]"); }
		}
		private string _mobile = "";
		/// <summary>
		/// ʡ����
		/// </summary>
		[DBCol]
		public Int32 provinceid
		{
			get{ return this._provinceid;}
			set{ this._provinceid = value; ModifiedColumns.Add("[PROVINCEID]"); }
		}
		private Int32 _provinceid = 0;
		/// <summary>
		/// ʡ����
		/// </summary>
		[DBCol]
		public string provincename
		{
			get{ return this._provincename;}
			set{ this._provincename = value; ModifiedColumns.Add("[PROVINCENAME]"); }
		}
		private string _provincename = "";
		/// <summary>
		/// ���б���
		/// </summary>
		[DBCol]
		public Int32 cityid
		{
			get{ return this._cityid;}
			set{ this._cityid = value; ModifiedColumns.Add("[CITYID]"); }
		}
		private Int32 _cityid = 0;
		/// <summary>
		/// ��������
		/// </summary>
		[DBCol]
		public string cityname
		{
			get{ return this._cityname;}
			set{ this._cityname = value; ModifiedColumns.Add("[CITYNAME]"); }
		}
		private string _cityname = "";
		/// <summary>
		/// �������
		/// </summary>
		[DBCol]
		public Int64 regionid
		{
			get{ return this._regionid;}
			set{ this._regionid = value; ModifiedColumns.Add("[REGIONID]"); }
		}
		private Int64 _regionid = 0L;
		/// <summary>
		/// ��������
		/// </summary>
		[DBCol]
		public string regionname
		{
			get{ return this._regionname;}
			set{ this._regionname = value; ModifiedColumns.Add("[REGIONNAME]"); }
		}
		private string _regionname = "";
		/// <summary>
		/// ��Դ����
		/// </summary>
		[DBCol]
		public Int32 sourceid
		{
			get{ return this._sourceid;}
			set{ this._sourceid = value; ModifiedColumns.Add("[SOURCEID]"); }
		}
		private Int32 _sourceid = 0;
		/// <summary>
		/// αɾ����ǣ�0��1��
		/// </summary>
		[DBCol]
		public Int32 del
		{
			get{ return this._del;}
			set{ this._del = value; ModifiedColumns.Add("[DEL]"); }
		}
		private Int32 _del = 0;
		/// <summary>
		/// С������
		/// </summary>
		[DBCol]
		public Int64 estateid
		{
			get{ return this._estateid;}
			set{ this._estateid = value; ModifiedColumns.Add("[ESTATEID]"); }
		}
		private Int64 _estateid = 0L;
		/// <summary>
		/// С������
		/// </summary>
		[DBCol]
		public string estatename
		{
			get{ return this._estatename;}
			set{ this._estatename = value; ModifiedColumns.Add("[ESTATENAME]"); }
		}
		private string _estatename = "";
		/// <summary>
		/// �����ŵ����
		/// </summary>
		[DBCol]
		public Int64 merchantid
		{
			get{ return this._merchantid;}
			set{ this._merchantid = value; ModifiedColumns.Add("[MERCHANTID]"); }
		}
		private Int64 _merchantid = 0L;
		/// <summary>
		/// ��������ID���������У�
		/// </summary>
		[DBCol]
		public Int32 formid
		{
			get{ return this._formid;}
			set{ this._formid = value; ModifiedColumns.Add("[FORMID]"); }
		}
		private Int32 _formid = 0;
		/// <summary>
		/// 
		/// </summary>
		[DBCol]
		public string ip
		{
			get{ return this._ip;}
			set{ this._ip = value; ModifiedColumns.Add("[IP]"); }
		}
		private string _ip = "";
		/// <summary>
		/// ��Դ����
		/// </summary>
		[DBCol]
		public string utmsource
		{
			get{ return this._utmsource;}
			set{ this._utmsource = value; ModifiedColumns.Add("[UTMSOURCE]"); }
		}
		private string _utmsource = "";
		/// <summary>
		/// ƽ̨���ͣ�1��������װ��APP ;2:Wap ; 3:PC��4����APP
		/// </summary>
		[DBCol]
		public Int32 platformtype
		{
			get{ return this._platformtype;}
			set{ this._platformtype = value; ModifiedColumns.Add("[PLATFORMTYPE]"); }
		}
		private Int32 _platformtype = 0;
		/// <summary>
		/// ��̨���õ���ԴҳID
		/// </summary>
		[DBCol]
		public Int32 sourcepageid
		{
			get{ return this._sourcepageid;}
			set{ this._sourcepageid = value; ModifiedColumns.Add("[SOURCEPAGEID]"); }
		}
		private Int32 _sourcepageid = 0;
		/// <summary>
		/// ��Դҳ��url
		/// </summary>
		[DBCol]
		public string sourcepageurl
		{
			get{ return this._sourcepageurl;}
			set{ this._sourcepageurl = value; ModifiedColumns.Add("[SOURCEPAGEURL]"); }
		}
		private string _sourcepageurl = "";
		/// <summary>
		/// ǰ�˱���ʱ�����ݵñ�ʶ��ͬ������������ʱʹ��
		/// </summary>
		[DBCol]
		public string uniquecookie
		{
			get{ return this._uniquecookie;}
			set{ this._uniquecookie = value; ModifiedColumns.Add("[UNIQUECOOKIE]"); }
		}
		private string _uniquecookie = "";
		/// <summary>
		/// ǰ�˱���ʱ�����ݵñ�ʶ��ͬ������������ʱʹ��
		/// </summary>
		[DBCol]
		public string globalcookie
		{
			get{ return this._globalcookie;}
			set{ this._globalcookie = value; ModifiedColumns.Add("[GLOBALCOOKIE]"); }
		}
		private string _globalcookie = "";
		/// <summary>
		/// �б�ӿ���HidID��װ�޹��̼�ID��Sendorder��SourceObjID
		/// </summary>
		[DBCol]
		public Int64 targetid
		{
			get{ return this._targetid;}
			set{ this._targetid = value; ModifiedColumns.Add("[TARGETID]"); }
		}
		private Int64 _targetid = 0L;
		#endregion
	}
}