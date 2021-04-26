using ASMI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASMI.Controllers
{
    public class HomeController : Controller
    {
        public readonly ILogger<HomeController> _logger;

        public class DepData
        {
            public string title;
            public string img;
            public string desc;
            public string desc1;
            public List<String> imgs;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Departamente()
        {

            List<DepData> pConfig = new List<DepData>() {
                new DepData{ 
                    title = "Consiliul Director" ,
                    img="https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Consiliul Director reprezintă conducerea ASMI și este alcătuit din Președinte, Prim-Vicepreședinte, Vicepreședinte, Director Executiv și Secretar General." , 
                    desc1="Consiliul Director alături de directorii de departament au rolul de a ghida asociația după scopul si obiectivele asociatiei urmarind dezvoltarea continuă a acesteia.", 
                    imgs = new List<string>{
                        "https://www.asmi.ro/wp-content/uploads/2021/04/ASMI5-scaled.jpg", 
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    } 
                },

                new DepData
                {
                    title = "Fundraising", 
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg", 
                    desc = "În spatele oricărui proiect de succes se află un proces complex de fundraising, motiv pentru care s-a înființat departamentul FUNDRAISING.",
                    desc1 = "Principalul nostru obiectiv este să facem rost de sponsorizări consistente pentru a îmbunătăți pe cât posibil condițiile în care se desfășoară evenimentele asociației. Acest lucru îl realizăm intrând în contact direct cu diverse firme (atât din domeniul IT, cât și de barter) și stabilind întâlniri care se finalizează cu încheierea unor contracte de sponsorizare. Totodată, departamentul planifică bugetul proiectelor. Căutăm în principal persoane persuasive și pline de viață, îndrăznețe și prietenoase, și totuși suficient de diplomate pentru a păstra legăturile formate cu firmele partenere. Primim însă cu căldură pe oricine dorește să ni se alăture și dovedește dorința de a învăța și de a se implica. Departamentul nostru contribuie din umbră la fiecare eveniment, însă printre proiectele cărora le acordăm o atenție deosebită se numără: SmartHack (concurs de informatică), Cariere (târg de joburi) și Balul Bobocilor.",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },
                new DepData
                {
                    title = "Proiecte",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Proiecte asigură distracția din viața studențească și bună funcționare a tuturor proiectelor. Sigur ne-ai remarcat activitatea încă de la începutul facultății, în cadrul petrecerii ce dă startul anului universitar și anume, Bumtzi party. Pe tot parcursul anului organizăm mai multe petreceri: Bumtzi, Ler, FMI Party, ASMI Party și Petrecerea de Trecere, fiecare dintre ele sărbătorind o ocazie specială. Pe lângă petrecăreală, voluntarii departamentului Proiecte se implică activ în fiecare proiect din cadrul asociației, mai ales pe partea de logistică, iar în timpul proiectului nostru principal, Zilele ASMI, organizăm și activități sportive indoor și outdoor.",
                    desc1 = "",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },
                new DepData
                {
                    title = "Design & PR",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Departamentul Design & PR se ocupă cu promovarea evenimentelor asociației, atât în mediul online, cât și în cel offline.",
                    desc1 = "De la afișe, coveruri, stickere, și chiar rândurile pe care le citești acum, toate țin de activitatea departamentului Design & PR. Șansele sunt mari să fi auzit de noi de pe Facebook sau Instagram; tot Design & PR se ocupă de partea de social media a asociației. Acest department, spre deosebire de celelalte, nu are un proiect specific, întrucât se implică în fiecare proiect prin promovarea lui. Cel mai important lucru în acest departament este feedback-ul, element de bază in obținerea unor materiale de promovare cât mai bune, deși cunoștințele tehnice, sau dorința de a le învăța, sunt, de asemenea, foarte importante. Așadar, departamentul Design & PR este ,,fața asociației”, fiind populat de oameni ce știu atât să își exprime părerea, cât și să asculte alte opinii.",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },
                new DepData
                {
                    title = "HR",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Buna comunicare este calitatea cheie a unui om din Departamentul de Resurse Umane. Într-o manieră prietenoasă, dar profesională, un bun HR reușește ușor să se facă înțeles și știe, la rândul lui, să îi asculte pe ceilalți. Obiectivul major al departamentului este să realizeze o conexiune strâns legată între membrii asociației. Pentru aceasta, este nevoie ca departamentul de HR să aibă în primul rând o legătură puternică cu restul voluntarilor, legătură castigata prin încredere, etică, imparțialitate și obiectivitate.",
                    desc1 = "",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },
                new DepData
                {
                    title = "Educațional",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Departamentul Educațional asigură buna desfășurare a proiectelor cu scop academic",
                    desc1 = "Prin proiectele specifice precum Admiterea, Caravana Educațională, Rățusca, Ziua Porților Deschise și așa mai departe, el mediază contactul între facultate, studenți și viitori studenți. În același timp, departamentul se implică în activitatea academică a studenților prin inițiative de informare, cererea de feedback și căutând tutori pentru boboci. Astfel, prin activitatea sa, departamentul se concentrează pe a îmbunătăți viața academică a studentului, aducând mai aproape viziunea noastră de facultate.",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },
            };

            ViewData["DepData"] = pConfig;
            return View();
        }

        public IActionResult Studenti()
        {
            return View();
        }


        public IActionResult Smarthack()
        {
            return View();
        }

        public IActionResult GhidulBobocului()
        {
            return View();
        }

        public IActionResult CalendarASMI()
        {
            return View();
        }

        public IActionResult ZiarulASMI()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
