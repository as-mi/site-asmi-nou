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
                //new DepData{ 
                //    title = "Consiliul Director" ,
                //    img="https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "Consiliul Director reprezintă conducerea ASMI și este alcătuit din Președinte, Prim-Vicepreședinte, Vicepreședinte, Director Executiv și Secretar General." , 
                //    desc1="Consiliul Director alături de directorii de departament au rolul de a ghida asociația după scopul si obiectivele asociatiei urmarind dezvoltarea continuă a acesteia.", 
                //    imgs = new List<string>{
                //        "https://www.asmi.ro/wp-content/uploads/2021/04/ASMI5-scaled.jpg", 
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    } 
                //},

                //new DepData
                //{
                //    title = "Fundraising", 
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg", 
                //    desc = "În spatele oricărui proiect de succes se află un proces complex de fundraising, motiv pentru care s-a înființat departamentul FUNDRAISING.",
                //    desc1 = "Principalul nostru obiectiv este să facem rost de sponsorizări consistente pentru a îmbunătăți pe cât posibil condițiile în care se desfășoară evenimentele asociației. Acest lucru îl realizăm intrând în contact direct cu diverse firme (atât din domeniul IT, cât și de barter) și stabilind întâlniri care se finalizează cu încheierea unor contracte de sponsorizare. Totodată, departamentul planifică bugetul proiectelor. Căutăm în principal persoane persuasive și pline de viață, îndrăznețe și prietenoase, și totuși suficient de diplomate pentru a păstra legăturile formate cu firmele partenere. Primim însă cu căldură pe oricine dorește să ni se alăture și dovedește dorința de a învăța și de a se implica. Departamentul nostru contribuie din umbră la fiecare eveniment, însă printre proiectele cărora le acordăm o atenție deosebită se numără: SmartHack (concurs de informatică), Cariere (târg de joburi) și Balul Bobocilor.",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},
                //new DepData
                //{
                //    title = "Proiecte",
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "Proiecte asigură distracția din viața studențească și bună funcționare a tuturor proiectelor. Sigur ne-ai remarcat activitatea încă de la începutul facultății, în cadrul petrecerii ce dă startul anului universitar și anume, Bumtzi party. Pe tot parcursul anului organizăm mai multe petreceri: Bumtzi, Ler, FMI Party, ASMI Party și Petrecerea de Trecere, fiecare dintre ele sărbătorind o ocazie specială. Pe lângă petrecăreală, voluntarii departamentului Proiecte se implică activ în fiecare proiect din cadrul asociației, mai ales pe partea de logistică, iar în timpul proiectului nostru principal, Zilele ASMI, organizăm și activități sportive indoor și outdoor.",
                //    desc1 = "",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},
                //new DepData
                //{
                //    title = "Design & PR",
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "Departamentul Design & PR se ocupă cu promovarea evenimentelor asociației, atât în mediul online, cât și în cel offline.",
                //    desc1 = "De la afișe, coveruri, stickere, și chiar rândurile pe care le citești acum, toate țin de activitatea departamentului Design & PR. Șansele sunt mari să fi auzit de noi de pe Facebook sau Instagram; tot Design & PR se ocupă de partea de social media a asociației. Acest department, spre deosebire de celelalte, nu are un proiect specific, întrucât se implică în fiecare proiect prin promovarea lui. Cel mai important lucru în acest departament este feedback-ul, element de bază in obținerea unor materiale de promovare cât mai bune, deși cunoștințele tehnice, sau dorința de a le învăța, sunt, de asemenea, foarte importante. Așadar, departamentul Design & PR este ,,fața asociației”, fiind populat de oameni ce știu atât să își exprime părerea, cât și să asculte alte opinii.",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},
                //new DepData
                //{
                //    title = "HR",
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "Buna comunicare este calitatea cheie a unui om din Departamentul de Resurse Umane. Într-o manieră prietenoasă, dar profesională, un bun HR reușește ușor să se facă înțeles și știe, la rândul lui, să îi asculte pe ceilalți. Obiectivul major al departamentului este să realizeze o conexiune strâns legată între membrii asociației. Pentru aceasta, este nevoie ca departamentul de HR să aibă în primul rând o legătură puternică cu restul voluntarilor, legătură castigata prin încredere, etică, imparțialitate și obiectivitate.",
                //    desc1 = "",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},
                //new DepData
                //{
                //    title = "Educațional",
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "Departamentul Educațional asigură buna desfășurare a proiectelor cu scop academic",
                //    desc1 = "Prin proiectele specifice precum Admiterea, Caravana Educațională, Rățusca, Ziua Porților Deschise și așa mai departe, el mediază contactul între facultate, studenți și viitori studenți. În același timp, departamentul se implică în activitatea academică a studenților prin inițiative de informare, cererea de feedback și căutând tutori pentru boboci. Astfel, prin activitatea sa, departamentul se concentrează pe a îmbunătăți viața academică a studentului, aducând mai aproape viziunea noastră de facultate.",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},
                //new DepData
                //{
                //    title = "Fundraising",
                //    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //    desc = "",
                //    desc1 = "",
                //    imgs = new List<string>{
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                //        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                //    }
                //},

                // -------------------------------------------------


                new DepData
                {
                    title = "Design & PR ",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Dacă am putea descrie acest departament în două cuvinte acelea sigur ar fi 'imaginea asociației'. Imaginează-ți pentru câteva secunde cum ar arăta un proiect fără afișe, postări pe Facebook sau pe Instagram. De exemplu Recrutările. Sau ce zici de o petrecere? Exact, informația ar ajunge la mult mai puțini oameni, sau cei care ar ști nu ar veni, deoarece nu i-a atras nimic auzind o informație doar prin viu grai. De aceea, avem nevoie de mult ajutor din partea acestui departament pentru a transmite informația într-un mod cât mai plăcut și mai atrăgător. Te pricepi la photoshop/editare video/grafică? Ai talent la desen sau pur și simplu îți dorești să înveți tot ce ți-am enumerat? Înseamnă că ai nimerit unde trebuie, la Design & PR îți poți dezvolta hard skillurile și poți să ajuți la toate proiectele asociației!",
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
                    desc = "Departamentul Educațional are ca scop îmbunătățirea calității vieții academice a studenților, reprezentând o punte de legătură între aceștia și Conducerea Facultății. Cu ce se ocupă mai exact Edu? Proiecte precum Admiterea, Tutoriate, Ziua Porților Deschise, Rățușca și, mai recent, Practica sunt organizate de voluntarii noștri, care sunt motivați să ajute studenții să aibă o experiență a anilor de Facultate cât mai plăcută. Membrii departamentului facilitează comunicarea cu Decanatul, învață public speaking, organizează evenimentele vitale desfășurării anului universitar și lucrează activ la identificarea și soluționarea problemelor studențești. Deci, dacă vrei să-ți ajuți colegii, ți-ar plăcea să îi reprezinți sau să contribui la organizarea proiectelor care îi influențează pe plan academic, Edu este pentru tine!",
                    desc1 = "",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },

                new DepData
                {
                    title = "Fundraising",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "În spatele oricărui proiect de succes se află un proces activ de Fundraising. Principalul nostru obiectiv este să facem rost de sponsorizări consistente pentru a îmbunătăți condițiile în care se desfășoară evenimentele asociației. Acest lucru îl realizăm intrând în contact direct cu diverse firme (atât din domeniul IT, cât și pentru produse), cu care încheiem contracte de sponsorizare. Ce câștigi dacă faci parte din acest departament? Abilități de public speaking, de negociere, contact cu mulți oameni din diverse companii pe care le poți fructifica și după facultate, acces la tehnici de influențare, traininguri speciale pentru fundraising (ex: LinkedIn (aplicația oamenilor mari)) și la mai multe goodies de la companii în timpul evenimentelor. În perioada pandemiei, departamentul a continuat să păstreze relația cu mediul de afaceri, și a adus sponsorizări, workshop-uri și alte oportunități pentru studenții noștri.",
                    desc1 = "",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },

                new DepData
                {
                    title = "Human Resources",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Noi suntem, în câteva cuvinte, 'inima asociației'! Ne ocupăm de integrarea bobocilor ce ni se alătură în fiecare toamnă și primăvară, astfel încât ei să ajungă să se simtă cu adevărat parte din familia noastră, dar și de bunăstarea tuturor voluntarilor, prin organizarea de joculețe interactive și de activități de socializare. În timpul pandemiei, am adaptat aceste activități de socializare în mediul online prin intermediul unor seri de jocuri sau de trivia. În plus, asigură dezvoltarea și motivarea constanta a voluntarilor noștri. Așa că, dacă îți place să comunici cu oamenii, să organizezi activități și să ajuți persoane, departamentul de Resurse Umane este pentru tine!",
                    desc1 = "",
                    imgs = new List<string>{
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                        "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg"
                    }
                },

                new DepData
                {
                    title = "Proiecte ",
                    img = "https://www.wrappixel.com/demos/ui-kit/wrapkit/assets/images/features/feature26/img2.jpg",
                    desc = "Simți că ai idei originale și interesante? Îți place să organizezi un eveniment la care să vină mulți oameni? Ești un perfecționist și vrei mereu să îmbunătățești ce ai făcut până acum? Dacă răspunsul la oricare din întrebările astea este da, departamentul Proiecte e pentru tine! Scopul nostru este să scriem proiecte noi și să le analizăm pe cele vechi ca să putem să le îmbunătățim de la o ediție la alta. Feedback-ul este cuvântul care ne definește, fiind mereu acolo ca să ascultăm ideile și sugestiile voluntarilor noștri. Proiectul nostru principal este Zilele ASMI, unde sărbătorim ziua de naștere a asociației prin organizarea mai multor activități indoor și outdoor. Pe lângă asta, participăm în mod activ la toate evenimentele, ne ocupăm de logistica proiectelor și de organizarea evenimentelor sociale.",
                    desc1 = "",
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
