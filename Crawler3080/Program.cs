using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler3080
{
    class Program
    {
        const string chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando processo...");

            var th1 = new Thread(SearchASUS);
            var th2 = new Thread(SearchZOTAC1);
            var th3 = new Thread(SearchZOTAC2);
            var th4 = new Thread(SearchMSI1);
            var th5 = new Thread(SearchMSI2);
            var th6 = new Thread(SearchEVGA);
            var th7 = new Thread(SearchGIGA1);
            var th8 = new Thread(SearchGIGA2);


            Console.WriteLine("Iniciando varredura das seguintes vgas: ASUS TUF-RTX3080-10G, ZOTAC ZT-A30800D-10P, MSI Gaming X Trio, MSI Ventus 3X, ZOTAC ZT-A30800J-10P, EVGA 10G-P5-3883-KR, GIGABYTE GV-N3080GAMING e GIGABYTE GV-N3080EAGLE OC-10GD.");

            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();
            th7.Start();

            Console.WriteLine("Pressione qualquer tecla para sair.");

            Console.ReadKey();

            th1.Abort();
            th2.Abort();
            th3.Abort();
            th4.Abort();
            th5.Abort();
            th6.Abort();
            th7.Abort();
            th8.Abort();
        }

        static void SearchASUS()
        {

            var url = "https://www.kabum.com.br/produto/121138/placa-de-v-deo-asus-nvidia-geforce-rtx3080-10gb-gddr6-tuf-rtx3080-10g-gaming";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("ASUS - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchZOTAC1()
        {
            var url = "https://www.kabum.com.br/produto/126895/placa-de-v-deo-zotac-nvidia-geforce-rtx-3080-10gb-gddr6x-zt-a30800d-10p";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("ZOTAC1 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchZOTAC2()
        {
            var url = "https://www.kabum.com.br/produto/127513/placa-de-v-deo-zotac-geforce-rtx-3080-zt-a30800j-10p";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("ZOTAC2 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchMSI1()
        {
            var url = "https://www.kabum.com.br/produto/127409/placa-de-v-deo-msi-nvidia-geforce-rtx-3080-gaming-x-trio-10g-gddr6x";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("MSI1 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchMSI2()
        {
            var url = "https://www.kabum.com.br/produto/127410/placa-de-v-deo-msi-nvidia-geforce-rtx-3080-ventus-3x-10g-oc-gddr6x";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("MSI2 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchEVGA()
        {
            var url = "https://www.kabum.com.br/produto/128077/placa-de-v-deo-gigabyte-nvidia-geforce-rtx-3080-10gb-gddr6x-gv-n3080gaming-oc-10gd";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("EVGA1 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }

        static void SearchGIGA1()
        {
            var url = "https://www.kabum.com.br/produto/128078/placa-de-v-deo-gigabyte-nvidia-geforce-rtx-3080-10gb-gddr6x-gv-n3080eagle-oc-10gd";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("GIGA1 - Indisponivel");
                }
                Thread.Sleep(2500);
            }
        }

        static void SearchGIGA2()
        {
            var url = "https://www.kabum.com.br/produto/128078/placa-de-v-deo-gigabyte-nvidia-geforce-rtx-3080-10gb-gddr6x-gv-n3080eagle-oc-10gd";

            while (true)
            {
                var web = new HtmlWeb();
                var page = web.Load(url);

                if (!page.DocumentNode.InnerHtml.Contains("AVISEME"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("===================================> ASUS - DISPONÍVEL! <============================");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Process.Start(chrome, url);
                }
                else
                {
                    Console.WriteLine("GIGA2 - Indisponivel");
                }

                Thread.Sleep(2500);
            }
        }
    }
}
