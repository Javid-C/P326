using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncronous
{
    internal class Program
    {
        #region Thread, Race condition
        static int Count;
        static object lockObj = new object();
        static void Increase()
        {
            for (int i = 0; i < 10000000; i++)
            {
                lock (lockObj)
                {
                    Count++;
                }
            }
        }
        static void Decrease()
        {
            for (int i = 0; i < 10000000; i++)
            {
                lock (lockObj)
                {
                    Count--;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Thread, Race condition
            //Stopwatch sw = Stopwatch.StartNew();
            ////Loop();
            ////Loop100();
            //Thread t1 = new Thread(Loop);
            //Thread t2 = new Thread(Loop100);
            //t1.Start();
            //t2.Start();
            //t2.Join();
            //Thread t1 = new Thread(Increase);
            //Thread t2 = new Thread(Decrease);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.WriteLine(Count);
            #endregion
            #region Asynchronous
            //LoopAsync().Wait();
            //Stopwatch sw = Stopwatch.StartNew();
            ////SeherYemeyi();
            ////SeherYemeyiAsync().Wait();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion
            GetString();
            GetStringAsync();
        }
        #region Asynchronous
        //static void SeherYemeyi() {
        //    Yumurta();
        //    Cay();
        //    Sufre();
        //}
        //static void Cay()
        //{
        //    Console.WriteLine("Qazin alti yandi");
        //    Console.WriteLine("Caydan uste qoyuldu");
        //    Thread.Sleep(8000);
        //    Console.WriteLine("Caydan qaynadi");
        //}
        //static void Yumurta()
        //{
        //    Thread.Sleep(500);
        //    Console.WriteLine("Yumutra qirildi");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Yumurta qarisdirildi");
        //    Console.WriteLine("Yumurta tavaya tokuldu");
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Yumurta bishdi");
        //}
        //static void Sufre()
        //{
        //    Console.WriteLine("Sufre hazirlanir...");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Nush olsun");
        //}
        //static async Task SeherYemeyiAsync()
        //{
        //    Task.WhenAll(CayAsync(),YumurtaAsync()).Wait();
        //    await SufreAsync();
        //}
        //static async Task CayAsync()
        //{
        //    Console.WriteLine("Qazin alti yandi");
        //    Console.WriteLine("Caydan uste qoyuldu");
        //    //Thread.Sleep(8000);
        //    await Task.Delay(8000);
        //    Console.WriteLine("Caydan qaynadi");
        //}
        //static async Task YumurtaAsync()
        //{
        //    await Task.Delay(500);
        //    Console.WriteLine("Yumutra qirildi");
        //    await Task.Delay(1000);
        //    Console.WriteLine("Yumurta qarisdirildi");
        //    Console.WriteLine("Yumurta tavaya tokuldu");
        //    await Task.Delay(5000);
        //    Console.WriteLine("Yumurta bishdi");
        //}
        //static async Task SufreAsync()
        //{
        //    await Task.Delay(1000);
        //    Console.WriteLine("Sufre hazirlandi");
        //}


        //static async Task LoopAsync() 
        //{
        //    await Task.Run(() => {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });
        //}

        #endregion

        static void GetString()
        {
            Stopwatch sw = Stopwatch.StartNew();
            HttpClient client = new HttpClient();
            foreach (var item in GetData())
            {
                client.GetStringAsync(item).Wait();
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        static void GetStringAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            HttpClient client = new HttpClient();
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (var item in GetData())
            {
                tasks.Add(client.GetStringAsync(item));
            }
            Task.WhenAll(tasks).Wait();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static string[] GetData()
        {
            return new string[] 
            {
                "https://docs.microsoft.com",
                "https://docs.microsoft.com/aspnet/core",
                "https://docs.microsoft.com/azure",
                "https://docs.microsoft.com/azure/devops",
                "https://docs.microsoft.com/dotnet",
                "https://docs.microsoft.com/dynamics365",
                "https://docs.microsoft.com/education",
                "https://docs.microsoft.com/enterprise-mobility-security",
                "https://docs.microsoft.com/gaming",
                "https://docs.microsoft.com/graph",
                "https://docs.microsoft.com/microsoft-365",
                "https://docs.microsoft.com/office",
                "https://docs.microsoft.com/powershell"
            };
        }

        static void Loop()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Loop100()
        {
            for (int i = 1000; i < 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
