using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using Db.Ebs.Model;
using XORM.NBase;

namespace XORM.NTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region 测试：添加-返回Id
            //Admin_UserInfo.Add(new Admin_UserInfo()
            //{
            //    Id = 100,
            //    SoufunName = "ccc123",
            //    TrueName = "ccc123456"
            //}, out NewId);
            //Console.WriteLine(NewId.ToString());
            //#endregion

            //#region 测试：添加-不返回Id
            //if (Suit_Info.Add(new NTest.Suit_Info()
            //{
            //    CityName = "北京",
            //    ID = 246,
            //    SuitName = "测试套装161206001"
            //}))
            //    Console.WriteLine(NewId.ToString());
            //#endregion

            //#region 测试：查询单个对象
            //Admin_UserInfo userObj0 = Admin_UserInfo.Get("Id=@Id", true, new object[] { 1 });
            //Console.WriteLine(userObj0.SoufunName);
            //#endregion

            //#region 测试：单实体获取
            //Suit_Info suitinfo = Suit_Info.Get("Id=249", true);
            //#endregion

            //#region 测试：查询统计信息
            //Console.WriteLine(Admin_UserInfo.Count("IsDel=0 AND Status=@Status", true, new object[] { 1 }));
            //#endregion

            //#region 测试：无分页列表查询
            //List<Suit_Info> suits = Suit_Info.List("IsDel=0 AND CityName=@CityName", "CreateTime Desc", true, new object[] { "北京" });
            //if (suits != null && suits.Count > 0)
            //{
            //    suits.ForEach(item =>
            //    {
            //        Console.WriteLine(item.SuitName);
            //    });
            //}
            //Console.WriteLine("/*无分页列表查询*/");
            //#endregion

            //#region 测试：分页列表查询
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //long RecordCount = 0L;
            ////第一页
            //List<Suit_Info> psuits1 = Suit_Info.List("IsDel=0 AND CityName=@CityName", "CreateTime Desc", out RecordCount, 1, 50, true, new object[] { "北京" });
            //if (psuits1 != null && psuits1.Count > 0)
            //{
            //    psuits1.ForEach(item =>
            //    {
            //        Console.WriteLine(item.SuitName);
            //    });
            //}
            //Console.WriteLine("/*分页列表查询.第一页*/");
            ////第二页
            //List<Suit_Info> psuits2 = Suit_Info.List("IsDel=0 AND CityName=@CityName", "CreateTime Desc", out RecordCount, 2, 50, true, new object[] { "北京" });
            //if (psuits2 != null && psuits2.Count > 0)
            //{
            //    psuits2.ForEach(item =>
            //    {
            //        Console.WriteLine(item.SuitName);
            //    });
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds.ToString());
            //Console.WriteLine("/*分页列表查询,第二页*/");
            //#endregion

            //#region 测试：逻辑删除
            //Suit_Info.Del("Id=@Id", new object[] { 246 });
            //#endregion

            //#region 测试：物理删除
            //Suit_Info.DbDel("Id=@Id", new object[] { 247 });
            //#endregion

            //#region 测试：非实体更新
            //Suit_Info.Update("CreateTime=@CreateTime,CityId=@CityId,SuitName=@SuitName", "Id=@Id", new object[] { DateTime.Now, 203, "测试套装-ORM测试", 248 });
            ////默认时间测试
            //Suit_Info.Update("CreateTime=@CreateTime,CityId=@CityId,SuitName=@SuitName", "Id=@Id", new object[] { new DateTime(), 203, "测试套装-ORM测试-默认时间测试", 249 });
            //#endregion

            //#region 测试：指定更新范围-动态类型
            ////动态类型
            //Suit_Info.Update(new { SuitName = "测试套装-", CityId = "203" }, new { Id = 250 });
            //#endregion

            //#region 测试：指定更新范围-自动属性
            ////自动属性
            //dynamic set = new ExpandoObject();
            //set.SuitName = "测试动态更新";
            //set.CityName = "上海";
            //dynamic where = new ExpandoObject();
            //where.Id = 248;
            //Suit_Info.Update(set, where);
            //#endregion

            //#region 测试：更新模型-动态条件
            //Suit_Info suit = new Suit_Info()
            //{
            //    CityName = "北京",
            //    ID = 246,
            //    SuitName = "测试套装161206001",
            //    CreateTime = DateTime.Now,
            //    MinArea = 60,
            //    SinglePrice = 120
            //};
            //Suit_Info.Update(suit, new { id = 248 });
            //#endregion

            //#region 测试：更新模型-自动属性条件
            //Suit_Info suit1 = new Suit_Info()
            //{
            //    CityName = "北京",
            //    ID = 246,
            //    SuitName = "测试套装-AutoProperty1",
            //    CreateTime = DateTime.Now,
            //    MinArea = 62,
            //    SinglePrice = 139
            //};
            //dynamic where1 = new ExpandoObject();
            //where1.Id = 249;
            //where1.isdel = 0;
            //Suit_Info.Update(suit1, where1);
            //#endregion

            //long RecordCount;
            //var orders = Db.Ebs.Model.N_Order_Base.List(new { IsDel = 0, CiyName = "北京" }, "", out RecordCount, 1, 100, true);
            //orders.ForEach(item =>
            //{
            //    Console.WriteLine(item.OrderId);
            //});

            //N_Order_Base.Where(c => c.CityName.Contains("北京") && c.StatusId > 10000);
            //Console.WriteLine(N_Order_Base.Count(c => c.CityName.Contains("北京") && c.IsDel == 0, true));
            //N_Order_Base nob = N_Order_Base.Get(o => o.OrderId == "J01201505260007149");
            //nob.TrueName = "测试更新";
            //N_Order_Base.Update(nob);

            //List<QueryResult> qrs = N_Order_Base.INNER_JOIN<N_Order_Operation>("O", "SRCTAB.OrderId=O.OrderId AND SRCTAB.CityName=@CityName", new object[] { "北京" })
            //    .Where("SRCTAB.IsDel=0 AND SRCTAB.CreateTime>'2016-12-8'", null)
            //    .List(true);
            //Stopwatch sw = Stopwatch.StartNew();
            //foreach (QueryResult qr in qrs)
            //{
            //    N_Order_Operation noo = qr.Get<N_Order_Operation>("O");
            //    N_Order_Base nob = qr.Get<N_Order_Base>();
            //    sw.Stop();
            //    Console.WriteLine(string.Format("TIME:{3}\t,OrderId:{0}\t,Amount:{1}\t,TrueName:{2}", noo.OrderId, noo.Amount, nob.TrueName, sw.ElapsedMilliseconds.ToString()));
            //    sw.Restart();
            //}

            //N_Order_Base N = N_Order_Base.Get("CityId=@CItyId", true, new object[] { 203 });
            //Console.WriteLine(N.TrueName);
            long demandId = 0L;
            demand_info.Add(new NTest.demand_info()
            {
                cityid = 203,
                cityname = "北京市",
                del = 0,
                estateid = 100001,
                estatename = "幸福港湾",
                formid = 1,
                globalcookie = "",
                ip = "127.0.0.1",
                merchantid = 0,
                mobile = "13811026314",
                platformtype = 0,
                provinceid = 0,
                provincename = "北京市",
                regionid = 0,
                regionname = "",
                sourceid = 1,
                sourcepageid = 1,
                sourcepageurl = "http://home.fang.com",
                targetid = 523011,
                truename = "测试接入",
                uniquecookie = "",
                utmsource = ""
            }, out demandId);
            Console.WriteLine(demandId.ToString());
            demand_info_extend.Add(new NTest.demand_info_extend()
            {
                area = 100,
                demandid = demandId
            });

            Console.Read();
        }
    }
}