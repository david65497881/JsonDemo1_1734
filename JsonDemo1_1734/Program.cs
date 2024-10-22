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
                    new Announcement {Date = new DateTime(2024,10,09),Title = "[軟體授權宣導] Xmind 品牌軟體的授權需知",Publisher = "許琮棋"},
                    new Announcement {Date = new DateTime(2024,09,23),Title = "[軟體授權宣導]Embarcadero 品牌軟體的授權需知",Publisher = "陳智民"}
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
        public string name { get; set; }
        public string IpAddress { get; set; }
        public string Signintoday { get; set; }
        public DateTime LastLogin { get; set; }
        public List<Announcement> Announcements { get; set; }
        public VacationStatus VacationStatus { get; set; }
    }



   

    public class Announcement
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
    }

    public class VacationStatus
    {
        public string EmployeeName { get; set; }
        public int TotalHours { get; set; }
        public int UnscheduledHours { get; set; }
        public int ScheduledHours { get; set; }
        public int Hourtakenoff { get; set; }
        public int RemainingPercentage { get; set; }
    }
}
