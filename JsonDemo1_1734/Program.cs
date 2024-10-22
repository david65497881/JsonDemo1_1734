using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using static JsonDemo1_1734.Program;

namespace JsonDemo1_1734
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var employeeInfo = new EmployeeInfo
            {
                name = "王大為",
                Signintoday = "【8:30~9:16】",//本日簽到
                IpAddress = "172.16.12.144",
                LastLogin = new DateTime(2024,10,22,10,41,51),//上次登入
                Announcements = new List<Announcement> //公告
                {
                    new Announcement {Date = new DateTime(2024,09,27),Title = "公告113年007號-修訂個人電腦規格使用規範",Publisher = "羅燕秋"},
                    new Announcement {Date = new DateTime(2024,09,23),Title = "【管理處宣導】個資法宣導",Publisher = "戎廷嘉"},
                    
                },
                LifeTidbits = new List<LifeTidbits> 
                {
                    
                },
                SecurityInformation = new List<SecurityInformation>
                {
                    new SecurityInformation {Date = new DateTime(2024,10,09),Title = "[軟體授權宣導] Xmind 品牌軟體的授權需知",Publisher = "許琮棋"},
                    new SecurityInformation {Date = new DateTime(2024,09,23),Title = "[軟體授權宣導]Embarcadero 品牌軟體的授權需知",Publisher = "陳智民"}
                },
                InternalRecommendation = new List<InternalRecommendation>
                {

                },
                Propaganda = new List<Propaganda>
                {

                },
                VacationStatus = new VacationStatus//休假時數
                {
                    EmployeeName = "王大為",
                    TotalHours = 12,
                    UnscheduledHours = 12,
                    ScheduledHours = 0,
                    Hourtakenoff = 0,
                    RemainingPercentage = 100
                }
            };
            string JsonData = JsonConvert.SerializeObject(employeeInfo, Formatting.Indented);
            //.SerializeObject-->使用 Newtonsoft.Json 的 SerializeObject 方法將 employeeInfo 物件序列化為 JSON 字串
            //Formatting.Indented 用於美化或縮排生成的 JSON 輸出，使其更具可讀性，默認情況下，輸出的 JSON 是沒有縮排的
            Console.WriteLine(JsonData);
        }   
    }
    public class EmployeeInfo
    {
        
        /// <summary>
        /// 登入名字
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 登入IP
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// 本日簽到
        /// </summary>
        public string Signintoday { get; set; }
        /// <summary>
        /// 上次登入
        /// </summary>
        public DateTime LastLogin { get; set; }
        /// <summary>
        /// 行政公告
        /// </summary>
        public List<Announcement> Announcements { get; set; }
        /// <summary>
        /// 生活花絮
        /// </summary>
        public List<LifeTidbits> LifeTidbits {  get; set; }
        /// <summary>
        /// 資安公告
        /// </summary>
        public List<SecurityInformation> SecurityInformation { get; set; }
        /// <summary>
        /// 內部推薦
        /// </summary>
        public List<InternalRecommendation> InternalRecommendation { get; set; }    
        /// <summary>
        /// BU1宣導
        /// </summary>
        public List<Propaganda> Propaganda { get; set; }
        /// <summary>
        /// 特休時數
        /// </summary>
        public VacationStatus VacationStatus { get; set; }
    }



   

    public class Announcement
    {
        /// <summary>
        /// 公告日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發布人
        /// </summary>
        public string Publisher { get; set; }
    }

    public class LifeTidbits 
    {
        /// <summary>
        /// 公告日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發布人
        /// </summary>
        public string Publisher { get; set; }
    }

    public class SecurityInformation
    {
        /// <summary>
        /// 公告日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發布人
        /// </summary>
        public string Publisher { get; set; }
    }

    public class InternalRecommendation
    {
        /// <summary>
        /// 公告日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發布人
        /// </summary>
        public string Publisher { get; set; }
    }

    public class Propaganda
    {
        /// <summary>
        /// 公告日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發布人
        /// </summary>
        public string Publisher { get; set; }
    }

    public class VacationStatus
    {
        /// <summary>
        /// 同仁姓名
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// 總時數
        /// </summary>
        public int TotalHours { get; set; }
        /// <summary>
        /// 未排時數
        /// </summary>
        public int UnscheduledHours { get; set; }
        /// <summary>
        /// 已排時數
        /// </summary>
        public int ScheduledHours { get; set; }
        /// <summary>
        /// 已休時數
        /// </summary>
        public int Hourtakenoff { get; set; }
        /// <summary>
        /// 剩餘%數
        /// </summary>
        public int RemainingPercentage { get; set; }
    }
}
