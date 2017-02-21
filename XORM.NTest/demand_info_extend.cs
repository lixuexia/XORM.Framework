using System;
using XORM.NBase;
using XORM.NBase.Attr;

namespace XORM.NTest
{
	/// <summary>
	/// ����ʵ����:demand_info_extend
	/// </summary>
	[DbSource("DEMAND")]
	public class demand_info_extend : ModelBase<demand_info_extend>
	{
		#region �ֶΡ�����
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
		/// ���ID,��������ID
		/// </summary>
		[DBCol]
		public Int64 demandid
		{
			get{ return this._demandid;}
			set{ this._demandid = value; ModifiedColumns.Add("[DEMANDID]"); }
		}
		private Int64 _demandid = 0L;
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
		/// Ԥ����(�б�/����)
		/// </summary>
		[DBCol]
		public double budget
		{
			get{ return this._budget;}
			set{ this._budget = value; ModifiedColumns.Add("[BUDGET]"); }
		}
		private double _budget = 0;
		/// <summary>
		/// Ԥ�㷶Χ9:1.5����,8:1.5��-3������,2:3��-5��,3:5��-10������,4:10��-15������,5:15��-20������,6:20��-30������,7:30������
		/// </summary>
		[DBCol]
		public Int32 budgetrange
		{
			get{ return this._budgetrange;}
			set{ this._budgetrange = value; ModifiedColumns.Add("[BUDGETRANGE]"); }
		}
		private Int32 _budgetrange = 0;
		/// <summary>
		/// Ԥ����(�б�/����)
		/// </summary>
		[DBCol]
		public double budgetwithoutfurniture
		{
			get{ return this._budgetwithoutfurniture;}
			set{ this._budgetwithoutfurniture = value; ModifiedColumns.Add("[BUDGETWITHOUTFURNITURE]"); }
		}
		private double _budgetwithoutfurniture = 0;
		/// <summary>
		/// װ�޷�ʽ��1ȫ����2���(����)
		/// </summary>
		[DBCol]
		public Int32 way
		{
			get{ return this._way;}
			set{ this._way = value; ModifiedColumns.Add("[WAY]"); }
		}
		private Int32 _way = 0;
		/// <summary>
		/// ���ͣ�1һ�ӣ�2���ӣ�3���ӣ�0����(�б�/����)
		/// </summary>
		[DBCol]
		public Int32 layout
		{
			get{ return this._layout;}
			set{ this._layout = value; ModifiedColumns.Add("[LAYOUT]"); }
		}
		private Int32 _layout = 0;
		/// <summary>
		/// �����ַ(�б�)
		/// </summary>
		[DBCol]
		public string email
		{
			get{ return this._email;}
			set{ this._email = value; ModifiedColumns.Add("[EMAIL]"); }
		}
		private string _email = "";
		/// <summary>
		/// ƫ�÷��,1�ִ���Լ��2��԰���3��ʽ�ŵ䣬4��ʽ�ŵ䣬5ŷ�����6�����Ƿ��7����ͷ��8�պ����9��ʽ���10��ŷ���11�¹ŵ���12�����13���к����14����(�б�/����)
		/// </summary>
		[DBCol]
		public Int32 style
		{
			get{ return this._style;}
			set{ this._style = value; ModifiedColumns.Add("[STYLE]"); }
		}
		private Int32 _style = 0;
		/// <summary>
		/// �������(�б�/����)
		/// </summary>
		[DBCol]
		public double area
		{
			get{ return this._area;}
			set{ this._area = value; ModifiedColumns.Add("[AREA]"); }
		}
		private double _area = 0;
		/// <summary>
		/// ��ע��Ϣ(�б�)
		/// </summary>
		[DBCol]
		public string remark
		{
			get{ return this._remark;}
			set{ this._remark = value; ModifiedColumns.Add("[REMARK]"); }
		}
		private string _remark = "";
		/// <summary>
		/// 1.��װ,2.��װ(����)
		/// </summary>
		[DBCol]
		public Int32 type
		{
			get{ return this._type;}
			set{ this._type = value; ModifiedColumns.Add("[TYPE]"); }
		}
		private Int32 _type = 0;
		/// <summary>
		/// 1.�·�,2.�ɷ�(����)
		/// </summary>
		[DBCol]
		public Int32 housetype
		{
			get{ return this._housetype;}
			set{ this._housetype = value; ModifiedColumns.Add("[HOUSETYPE]"); }
		}
		private Int32 _housetype = 0;
		/// <summary>
		/// װ��ʱ��1.������,2һ����,3������,4��������(����)
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