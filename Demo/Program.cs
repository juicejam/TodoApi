using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Demo
{
    class Program
    {
       static void Main(string[] args)
       {
            //new LinqExpress().CallFunction();
            //Operation.ExecuteFunc();
            //new AsyncDemo().CallFunction();
            //new AsyncDemo().CallFunction();
            //new AsyncDemo().CallFunction();
            //new AsyncDemo().CallFunction();
            //new Sort().CallFunction();
            //new ThreadLearning().CallFunction();


            //UrlNewMethod();
            //NewMethod();
            //XDocument();

            //PassWordNewMethod();
            //StringJoinNewMethod();


            //  var dt = DateTime.Now;
            //  Console.WriteLine(dt.ToString("yyyyMMddHHmmssfff"));
            //  var expireDate = Convert.ToDateTime("2020-5-20");
            //  var t = dt > expireDate;

            //VerifyPassword();
            //string test = "{\"errcode\":0,\"errmsg\":\"成功！\",\"data\":{\"switch_notice\":true,\"is_mock_open\":false,\"strice\":false,\"is_json5\":false,\"name\":\"礼品分组（敏感）\",\"basepath\":\"\",\"members\":[],\"project_type\":\"private\",\"uid\":22,\"group_id\":17,\"icon\":\"code-o\",\"color\":\"yellow\",\"add_time\":1595227714,\"up_time\":1595227714,\"env\":[{\"header\":[],\"_id\":\"5f153e42ffb9845c23a03af0\",\"name\":\"local\",\"domain\":\"http://127.0.0.1\",\"global\":[]}],\"tag\":[],\"_id\":405,\"__v\":0}}";
            //var response = Newtonsoft.Json.JsonConvert.DeserializeObject<YapiBaseModel>(test);
            //var jsonResponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);

            //        var path = "rt54654r34344345wergferwertwertwertwertewrtwertwertwertewrg";

            //        var isPath = System.Text.RegularExpressions.Regex.IsMatch(
            //path,"^()$");
            //        Console.WriteLine(isPath);
            //string s = "ABCDEFG";
            //Console.WriteLine(s.Substring(3)+s.Substring(3,5));


            //var serviceUrl = "https://www.abcdefg/{memberNumber}/transactio/{code}/register";


            //var leftBracket = serviceUrl.IndexOf('{');
            //var rightBracket = serviceUrl.IndexOf('}');
            //if (leftBracket < rightBracket && leftBracket > -1)
            //{

            //}

            //var stack = new Stack<char>();
            //var dynamicParams = new List<string>();
            //var tempParam = new StringBuilder();
            //foreach (var item in serviceUrl)
            //{
            //    if (item == '{' || item == '}')
            //    {
            //        switch (item)
            //        {
            //            //左括号入栈
            //            case '{':
            //                stack.Push(item);
            //                break;
            //            //右括号出栈
            //            case '}':
            //                stack.Pop();
            //                //出栈后保存花括号里面的内容
            //                dynamicParams.Add(tempParam.ToString());
            //                tempParam = new StringBuilder();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        if (stack.Count>0&&stack.Peek() == '{')
            //        {
            //            tempParam.Append(item);
            //        }
            //    }
            //}

            //foreach (var item in dynamicParams)
            //{
            //    Console.WriteLine(item);
            //}
            //DateTime.TryParse("2019-10-31 13:30:23", out var expiryDate);
            //if (expiryDate.Year == 1)
            //{
            //    Console.WriteLine("错误");
            //}

            //var tempDate = expiryDate.AddMonths(1);
            //expiryDate = new DateTime(tempDate.Year, tempDate.Month, 1).AddSeconds(-1);

            //date.AddMonths(1).AddDays(-date.AddMonths(1).Day).ToString();
            //var test =expiryDate.AddDays(1 - DateTime.Now.Day).Date.AddMonths(1).AddSeconds(-1);


            //var page = 1;
            //int pageCount;//5页
            //var pageSize = 100;
            //do
            //{
            //    var apiListRrl = $"/api/Apis/List?page={page}&pageSize={pageSize}";

            //    //409
            //    var resTotalCount = 190;
            //    pageCount = (int)Math.Ceiling((double)resTotalCount / pageSize);
            //    page++;
            //} while (page <= pageCount);

            //var str = "abcdefghijklmn";
            //var res = str.EndsWith("jkl");
            //Console.WriteLine(CreatSign());


            //var list = Enumerable.Range(0, 10).ToList();
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //list.ForEach(i =>
            //{
            //    if (i == 5)
            //    {
            //        return;
            //    }
            //    Console.WriteLine(i);
            //});

            //var nowDate = Convert.ToDateTime("2021-02-02 9:29:33");
            //var createDate = Convert.ToDateTime("2021-02-03 15:03:33").Date;
            //if (nowDate.Date.AddDays(-1) > createDate || (nowDate.Date.AddDays(-1) == createDate && (nowDate.Hour == 9 && nowDate.Minute >= 30 || nowDate.Hour > 9)))
            //{
            //    Console.WriteLine("到了第二天九点半以后了");
            //}



            Console.ReadKey();
        }

        private  void ShowDuplicatedTimes()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
        }

        public  string CreatSign()
        {
            var stringToSign = @"sv=&ss=&srt=o&sp=r&se=2020-10-24T14:57:50Z&st=2020-10-24T06:57:50Z&spr=https";

            var StringToSign = "GET\n\n\n\n\n\n\n\n\n\n\n\nx-ms-date:Fri, 26 Jun 2015 23:39:12 GMT\nx-ms-version:2015-02-21\n/myaccount/mycontainer\ncomp:metadata\nrestype:container\ntimeout:20";


            //var utf8 = new UTF8Encoding();  //   Create   a   UTF-8   encoding. 
            //string s1 = utf8.GetString(utf8.GetBytes(stringToSign));

            //var s2 = System.Web.HttpUtility.UrlDecode(s1);
            //var sig = SHA256.Create().ComputeHash(s2);


            //var buffer = Encoding.UTF8.GetBytes(stringToSign);
            //var data = SHA256.Create().ComputeHash(buffer);
            //var sb = new StringBuilder();
            //foreach (var t in data)
            //{
            //    sb.Append(t.ToString());
            //};
            var sb = new StringBuilder();
            var key = Encoding.UTF8.GetBytes("OHNR7OD2tNRfpy+dBvJEc4ZeUKjwwByWY8ZkIx96B9QMuVcTOKgrDx0AxRIWOWRHXbJU1e/xv0HFpjDyGQIAXw==");
            using (var hmacsha256 = new HMACSHA256(key))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(StringToSign));

                
                foreach (var t in hashmessage)
                {
                    sb.Append(t.ToString("x2"));
                };
            }
           

            var sig = sb.ToString();


            return sig;
        }



        private  void VerifyPassword()
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^(?=.*\d)(?=.*[a-zA-Z]).{8,16}$", System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace);
            if (regex.IsMatch("12347*^……12"))
            {
                Console.WriteLine("通过");
            }
        }

        private  void StringJoinNewMethod()
        {
            List<Product> p = new List<Product>()
            {
                new Product()
                {
                    Name = "张三",
                    Price = 100000
                },
                new Product()
                {
                    Name = "李四",
                    Price = 100000
                }
            };
            p = new List<Product>();
            p.RemoveAll(m => m.Name == "张三");
            p.RemoveAll(m => m.Name == "王五");

            var test = string.Join(',', null);
        }

        private  void PassWordNewMethod()
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            //string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            //    password: password,
            //    salt: salt,
            //    prf: KeyDerivationPrf.HMACSHA1,
            //    iterationCount: 10000,
            //    numBytesRequested: 256 / 8));
            //Console.WriteLine($"Hashed: {hashed}");
        }

        private  XDocument XDocument()
        {
            var xmlString1 =
                "<policies>\r\n\t<inbound>\r\n\t\t<base />\r\n\t\t<rate-limit-by-key calls=\"20\" renewal-period=\"60\" counter-key=\"@(context.Subscription?.Key ?? &quot;anonymous&quot;)\" />\r\n\t\t<rate-limit-by-key calls=\"1000\" renewal-period=\"60\" counter-key=\"@(context.Subscription?.Key ?? &quot;anonymous&quot;)\" increment-condition=\"@(context.Response.StatusCode &gt;= 200 &amp;&amp; context.Response.StatusCode &lt; 300)\" />\r\n\t\t<rate-limit-by-key calls=\"800\" renewal-period=\"60\" counter-key=\"@(context.Request.IpAddress)\" />\r\n\t</inbound>\r\n\t<backend>\r\n\t\t<base />\r\n\t</backend>\r\n\t<outbound>\r\n\t\t<base />\r\n\t</outbound>\r\n\t<on-error>\r\n\t\t<base />\r\n\t</on-error>\r\n</policies>";
            var xmlStringLocal =
                "<policies><inbound><base /><rate-limit-by-key calls=\"20\" renewal-period=\"60\" counter-key=\"@(context.Subscription?.Key ?? &quot; anonymous & quot;)\" /></inbound><backend><base /></backend><outbound><base /></outbound><on-error><base /></on-error></policies>";
            var xml = System.Xml.Linq.XDocument.Parse(xmlString1);
            if (xml.Element("policies")?.Element("inbound")?.Element("rate-limit-by-key") == null)
            {
                var xElement = new XElement("rate-limit-by-key");
                xElement.SetAttributeValue("calls", 100);
                xElement.SetAttributeValue("renewal-period", 100);
                xElement.SetAttributeValue("counter-key", "@(context.Subscription?.Key ?? &quot;anonymous&quot;)");
                xml.Element("policies")?.Element("inbound").Add(xElement);
            }
            else
            {
                xml.Element("policies")?.Element("inbound")?.Element("rate-limit-by-key")?.SetAttributeValue("calls", 999);
            }

            return xml;
        }

        private  void NewMethod()
        {
            Product p = null;
            if ("".Contains("e"))
            {
                p = new Product();
            }

            bool test = p?.Name?.Contains("45652002c8f3d4") ?? false;
            Console.WriteLine(test);
        }

        private  void UrlNewMethod()
        {
            try
            {
                var urlString =
                    "http://139.196.254.102:8023/Dashbord.aspx,http://www.baidu.com/{number}/transaction,http://192.168.1.174:966/,https://bmempuat.capitaland.com.cn/,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempuat.capitaland.com.cn/apidefine_manage,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/tips/index,https://bmempuat.capitaland.com.cn/,https://mall30.capitaland.com.cn/getmoney,https://api30.capitaland.com.cn,https://mall.capitaland.com.cn,https://www.baidu.com,https://www.baidu.com,https://mall30apiuat.capitaland.com.cn/api/mall/mallList,https://mall30apiuat.capitaland.com.cn/api/Member/GetIsRead?mallId=10&portalId=2,Https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://www.npmjs.com/package/copy-to-clipboard,https://ant.design/components/icon-cn/,Http://www.baidu.com,http://192.168.1.180:9666/,HTTPS://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://mall30apiuat.capitaland.com.cn/api/Index/IndexMallService?mallId=10&portalId=2,https://mall30.capitaland.com.cn,https://kamall30.capitaland.com.cn,http://192.168.1.180:9666/,http://www.baidu.com,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,http://192.168.1.180:9666/,http://192.168.1.180:9666/,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://uatopen.capitastar.com.cn/api/Order/Shipments,https://uatopen.capitastar.com.cn/api/Order/Shipments,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://mall30apiuat.capitaland.com.cn/api/Activity/ActivityList?page=1&pageSize=10&bussinessTypeID=0&typeId=0&mallId=37&portalId=24,http://192.168.1.180:9666/mai,https://mall30apiuat.capitaland.com.cn/api/Index/IndexShopList?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/IndexShopList?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Shop/List?page=1&pageSize=10&type=0&floorId=0&mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/Banner?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/Navigation?mallId=37&portalId=24,https://bmempapiuat.capitaland.com.cn/api/tips/index,https://mall30apiuat.capitaland.com.cn/api/Shop/List?page=1&pageSize=10&type=0&floorId=0&mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/BottomNavigation?mallId=37&portalId=24,http://192.168.1.180:9666/23123,https://mall30apiuat.capitaland.com.cn/api/Activity/IndexActivityList?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Activity/IndexActivityList?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/Banner?mallId=37&portalId=24,https://bmempapiuat.capitaland.com.cn/api/tips/index,https://bmempapiuat.capitaland.com.cn/api/useraudit/list?page=1&pageSize=10,https://mall30apiuat.capitaland.com.cn/api/ElecMyAddress/List?mallId=37&portalId=24,http://192.168.1.180:9666/3fdfd,https://mall30apiuat.capitaland.com.cn/api/MyCenter/H5Login,https://mall30apiuat.capitaland.com.cn/api/Index/Navigation?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/Layout?mallId=37&portalId=24,https://mall30apiuat.capitaland.com.cn/api/Index/Navigation?mallId=37&portalId=24,https://uatopenwode.capitastar.com.cn/indexwode,https://bmempuat.capitaland.com.cn/shopname,https://bmempapiuat.capitaland.com.cn/api/tips/indexsss,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=2&pageSize=10,https://largescreenapi.capitastar.com.cn/swagger/api/VirtualCoupon/ConsumeCoupon,https://api30uat.capitaland.com.cn/CommonAPI/mallshops,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://bmempapiuat.capitaland.com.cn,https://bmempuat.capitaland.com.cn/,https://bmempapiuat.capitaland.com.cn/api/tips/index,https://bmempapiuat.capitaland.com.cn/api/tips/index,https://mallapi.capitaland.com.cn/api/Index/Banner?mallId=10&portalId=2,https://mallapi.capitaland.com.cn/api/Index/Banner?mallId=10&portalId=2,https://mallapi.capitaland.com.cn/api/Index/IndexMallService?mallId=92&portalId=78,https://mallapi.capitaland.com.cn/api/Index/Banner?mallId=10&portalId=2,https://mallapi.capitaland.com.cn/api/Shop/List,https://mallapi.capitaland.com.cn/api/Shop/List,https://mallapi.capitaland.com.cn/api/Index/IndexMallService?mallId=92&portalId=78,https://mallapi.capitaland.com.cn/api/Index/Banner?mallId=10&portalId=2,https://mallapi.capitaland.com.cn/api/Activity/ActivityList?page=1&pageSize=10&bussinessTypeID=0&typeId=0&mallId=10&portalId=2,https://mallapi.capitaland.com.cn/api/Index/IndexMallService?mallId=92&portalId=78,https://mallapi.capitaland.com.cn/api/Index/IndexMallService?mallId=92&portalId=78,https://mallapi.capitaland.com.cn/api/Shop/List?page=1&pageSize=10,https://largescreenapi.capitastar.com.cn/api/ShopOrder/setOrderState,https://largescreenapi.capitastar.com.cn/api/IShopOrder/List,https://uatopen.capitastar.com.cn/swagger/api/IShopOrder/List,https://uatopen.capitastar.com.cn/api/VirtualCoupon,https://uatopen.capitastar.com.cn/api/VirtualCoupon,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/swagger/api/Order/Shipments,https://uatopen.capitastar.com.cn/api/Order/FilterExpress,https://uatopen.capitastar.com.cn/api/Order/OrderDetail,https://uatopen.capitastar.com.cn/api/Order/OrderList,https://uatopen.capitastar.com.cn/api/ExternalService/GetCouponPackeges,https://uatopen.capitastar.com.cn/api/ExternalService/GetCoupons,https://uatopen.capitastar.com.cn/api/ExternalService/GetRecGoodsByStoreCode,https://uatopen.capitastar.com.cn/api/ExternalService/GetGoods,https://uatopen.capitastar.com.cn/api/Advert/GetIndexImage,https://uatopen.capitastar.com.cn/api/Auth/RefreshToken,https://uatopen.capitastar.com.cn/api/Auth/Login,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/camelot/merchant_api,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/api/coupon_grant,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/APP_API/index,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/api/message,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/amos_pos/merchant,https://api30uat.capitaland.com.cn/amos_pos/merchant,https://api30uat.capitaland.com.cn/rtmaps/merchants,https://api30uat.capitaland.com.cn/rtmaps/merchants,https://api30uat.capitaland.com.cn/rtmaps/merchants,https://api30uat.capitaland.com.cn/rtmaps/merchants,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/api/member,https://api30uat.capitaland.com.cn/api/templatemessage,https://api30uat.capitaland.com.cn/api/templatemessage,https://api30uat.capitaland.com.cn/api/templatemessage,https://api30uat.capitaland.com.cn/api/integral,https://api30uat.capitaland.com.cn/api/integral,https://api30uat.capitaland.com.cn/reaktor-event,https://api30uat.capitaland.com.cn/bigscreen/bigscreen,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://mall30apiuat.capitaland.com.cn/api/mall/mallList,https://mempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://mall30apiuat.capitaland.com.cn/api/mall/mallList?id=1,https://mall30apiuat.capitaland.com.cn/api/MyCenter/H5Login,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempuat.capitaland.com.cn/,https://bmempuat.capitaland.com.cn/,https://bmempuat.capitaland.com.cn/,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/Add,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/Add,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/Add,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/AlertRule/List?page=1&pageSize=10,https://bmempapi.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/Add,https://uateshop.capitastar.com.cn/api/GoodsMarketCategory/Add,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempuat.capitaland.com.cn/main.html,https://uateshop.capitastar.com.cn/api/UserAuth/Tree?feature=1,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://uateshop.capitastar.com.cn/api/LiveGoods/List?page=1&pageSize=100&liveId=25,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/ApiGroup/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/member/{memberNumber}/transaction,https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=APPID&secret=APPSECRET,https://cduatscrmapi.companycn.net/api/OffLineGoods/Detail,https://cduatscrmapi.companycn.net/api/OffLineGoods/Detail,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempapiuat.capitaland.com.cn/api/Apis/List?page=1&pageSize=10,https://bmempuat.capitaland.com.cn/,https://bmempuat.capitaland.com.cn/,https://bmempuat.capitaland.com.cn/main.html,https://bmempuat.capitaland.com.cn/main.html,https://bmempuat.capitaland.com.cn/,https://api30uat.capitaland.com.cn/api/mall,https://bmempapiuat.capitaland.com.cn/Saml/LogIn,https://bmempuat.capitaland.com.cn/main.htm,https://bmempuat.capitaland.com.cn,https://bmempuat.capitaland.com.cn,https://bmempuat.capitaland.com.cn,https://bmempuat.capitaland.com.cn/main.html,http://10.171.96.16/api/Encrypt/Decode,http://10.171.96.16/api/Encrypt/Encode,http://10.171.98.13/gbssweb/getInfo,http://postman-echo.com/delete,https://postman-echo.com/post,http://www.baidu.com,http://10.171.100.132/123,http://10.171.100.132/main.,http://10.171.100.132/ma,http://10.171.100.132/ma,http://10.171.100.132/ma,http://10.171.100.132/ma,http://10.171.100.132/main.hta1g2fws1,http://10.171.100.132/main.hta1g2fws1,http://10.171.100.132/main.hta1g2fws1,http://10.171.100.132/main.hta1g2fws1,http://10.171.100.132/main.hta1g2fws1,http://10.171.100.132/main.hta1gfws1,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,https://api30uat.capitaland.com.cn/rtmaps/member_api,http://10.171.100.132/main.hta1fws1,http://10.171.100.132/main.hta1fs1,http://10.171.100.132/main.hta1fs1,https://api30uat.capitaland.com.cn/rtmaps/member_api,http://10.171.100.132/main.hta1f1,https://api30uat.capitaland.com.cn/rtmaps/member_api,http://10.171.100.132/main.hta1f,http://10.171.100.132/main.hta1f,http://10.171.100.132/main.hta1f,http://10.171.100.132/main.hta1,https://api30uat.capitaland.com.cn/api/member,http://10.171.100.132/main.hta,http://10.171.100.132/main.ht,https://postman-echo.com/post,https://postman-echo.com/get,https://postman-echo.com/get,http://10.171.100.132/,https://cduatscrmapi.companycn.net/api/OffLineGoods/Add,https://cduatscrmapi.companycn.net/api/OffLineGoods/List,http://10.171.100.132/,http://10.171.100.132/main.htm,https://cduatscrmapi.companycn.net/api/OffLineGoods/Detail,http://10.171.100.132/,http://10.171.100.131/project/29/interface/api/77,http://10.171.100.132/main,http://10.171.100.132/main,https://api30uat.capitaland.com.cn/chargingpost/coupon,https://api30uat.capitaland.com.cn/chargingpost/coupon,http://10.171.100.128/api/apigroup/List,https://fanyi.baidu.com/702,https://fanyi.baidu.com/1,https://fanyi.baidu.com/,http://10.171.100.132/main.html/add1,http://10.171.100.132/main.htm,https://cduatscrmapi.companycn.net/api/OffLineGoods/List,https://www.baidu.cim,http://iworkflowuat.dc.capitaland.com/wfapi/api/TATravelApplyForEntranceGuard/TATravelApplyList,https://iworkflowuat.dc.capitaland.com/wfapi/api/TATravelApplyForEntranceGuard/TATravelApplyList,https://dev.azure.com/CLNexTen/BME/_apps/hub/TimeLog.time-logging-extension.time-log-summary,https://www.baidu.com/,http://10.171.100.132/,https://bmempapiuat.capitaland.com.cn/api/MetricAlert/TestForException,https://bmempapiuat.capitaland.com.cn/api/AlertRule/List,https://api30uat.capitaland.com.cn/api/shop5f7bf64cf5c84293a94c1b070b767710,https://api30uat.capitaland.com.cn/api/shop89d20bd8e553459cbc01e07aa3e0d6ec,https://api30uat.capitaland.com.cn/api/shop9cd21ecca5894770a6f15997aabdee04,https://api30uat.capitaland.com.cn/api/shop18a30d4015bc4e8d88f263e37a7be9bd,https://api30uat.capitaland.com.cn/api/shop2dc55c3ec9954dbdbac54eaee3685b03,https://api30uat.capitaland.com.cn/api/shop082ccccea44f40cb8111f39c0c9f5f01,https://api30uat.capitaland.com.cn/api/shope6c737e2565442ebae4b87a37f549254,https://api30uat.capitaland.com.cn/api/shopc8ba3adce15c4bec90a001eac5ae3ecd,https://api30uat.capitaland.com.cn/api/shope92df9349a2641c7863b2d3e149390fa,https://api30uat.capitaland.com.cn/api/shop9f3e8b3768d4493fb1da98ee39d654d1,https://bmempapi.capitaland.com.cn/api/tips/index1,https://api30.capitaland.com.cn/CommonAPI/percent99,https://api30.capitaland.com.cn/CommonAPI/mallshop,https://api30uat.capitaland.com.cn/api/shop,https://api30uat.capitaland.com.cn/api/shop,https://api30uat.capitaland.com.cn/api/shop,https://api30uat.capitaland.com.cn/api/shop,https://cduatscrmapi.companycn.net/api/OffLineGoods/List";
                //Uri u = new Uri("http://localhost:3000/project/{code}/interface/api/2245");

                string[] urlArray = urlString.Split(',');
                foreach (var item in urlArray)
                {
                    Uri u = new Uri(item);
                    
                    
                    Console.WriteLine(item + "------" + u.Scheme+"://"+u.Authority);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


    }
    
    public enum Member_Gender
    {
        男 = 1,
        女 = 2,
        未知 = 0,
    }

    public enum enumColor
    {
        Red = 1,
        Yellow,
        Green,
        Blue,
        White,
        Black
    }


    public class Student

    {

        public string Name { get; set; }

        public int Sex { get; set; }

        public string Age { get; set; }

        public DateTime Birth { get; set; }

    }

    public class Dto_Student

    {

        public string n { get; set; }

        public string s { get; set; }

        public int a { get; set; }

        public string b { get; set; }

    }

    public class V_Student

    {

        public string Name { get; set; }

        public int Sex { get; set; }

        public string Age { get; set; }

        public DateTime Birth { get; set; }

    }

    public class YapiBaseModel
    {
        public int Errcode { get; set; }
        public string Errmsg { get; set; }
        public object Data { get; set; }
    }
}
