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

        public class ProjData
        {
            public string img;
            public string name;
            public string desc;
            public string url;
            public int w;
            public int h;
        }

        private static List<ProjData> pProjects = new List<ProjData>() {
             new ProjData {
                img = "artandar-.png",
                desc = "„Artă'n Dar” este un eveniment ce promovează cultura și arta în rândul studenților și în același timp urmărește scopul de a împărți bucurie și cadouri oamenilor care au cea mai mare nevoie.",
                name = "Artă’n Dar",
                url = "#"
            },
            new ProjData {
                img = "cariere.png",
                desc = "„Cariere” este un târg de joburi și internship-uri care oferă un sprijin în dezvoltarea pe plan profesional a studenților, realizând o legătură între aceștia (participanți) și o parte din cele mai cunoscute companii din piața IT din Romania.",
                name = "Cariere",
                url = "#"
            },
            new ProjData {
                img = "logo-zile-1.png",
                desc = "La mulți ani, drag ASMI! Anul acesta Asociația Studenților la Matematică și Informatică sărbătorește ziua de naștere <b>#stândacasă</b>. Te invităm să sărbătorești împreună cu noi pe cei 11 ani de voluntariat.",
                name = "Zilele ASMI",
                url = "#"
            },
            new ProjData {
                img = "smarthack.png",
                desc = "„Smarthack” este un hackathon de 24 de ore în care mai multe echipe de câte 3-4 studenţi lucrează la dezvoltarea unui produs software pe baza unei teme, care se finalizează cu jurizarea şi premierea celor mai bune echipe.",
                name = "SMARTHACK",
                url = "#"
            },
            new ProjData {
                img = "CaravanaEducationala.png",
                desc = "Descoperă Facultatea de Matematică și Informatică a Universității din București!",
                name = "CARAVANA EDUCAȚIONALĂ",
                url = "#"
            },
            new ProjData {
                img = "Logo_practica.png",
                desc = "„Practica” este proiectul care vine în ajutorul studenților din an terminal, cu scopul de a își echivala orele de practică necesare obținerii diplomei de licență.",
                name = "PRACTICA",
                url = "#"
            },
            new ProjData {
                img = "SOS-LOGO-FINAL.png",
                desc = "„Students' Organizations Showdown” este un campionat caritabil de CS:GO între asociațiile studențești, în cadrul căruia strângem donații pentru o cauză nobilă.",
                name = "Students’ Organizations Showdown",
                url = "#"
            },
            new ProjData {
                img = "logo-marea-ieseala.png",
                desc = "„Marea Ieșeală” este unul din primele proiecte ale asociației cu care te întâlnești ca boboc la Facultatea de Matematică și Informatică.",
                name = "Marea Ieșeală",
                url = "#"
            },
            new ProjData {
                img = "LogoDuckFinal.png",
                desc = "„Rățușca” este proiectul prin care intrăm în contact cu bobocii și îi introducem în viața de facultate. Încă din primele zile, voluntarii asociației se integrează cu grupele nou-formate, și îi ghidează prin primii pași de studenție.",
                name = "Rățusca",
                url = "#"
            },
            new ProjData {
                img = "Logo_Tre_Sa_Caut.png",
                desc = "„Tre' sa caut” este un treasure hunt ce se desfasoara in Bucuresti. Scopul este familiarizarea studentilor cu locuri interesant sau importante din jurul zonei universitatii, dar mai important este cunoasterea mai buna a colegilor si formarea de legaturi noi cu acestia.",
                name = "Tre’ sa caut",
                url = "#"
            },
            new ProjData {
                img = "logo_raport_cdos.png",
                desc = "Prin chestionarul CDOS se urmărește nivelul de satisfacție al studenților cu privire la condițiile oferite de facultate, cât și dacă le-au fost respectate drepturile sau nu.",
                name = "Raport CDOS",
                url = "#"
            },

        };
        

        private List<ProjData> EnumProjects(int cbCount)
        {
            if (cbCount == 0)
            {
                return pProjects;
            }
            return pProjects.GetRange(0, cbCount);
        }
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CalendarASMI()
        {
            return View();
        }
    
        public IActionResult Departamente()
        {
            List<DepData> pConfig = new List<DepData>() {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            ViewData["ProjData"] = EnumProjects(6);
            return View();
        }

        public IActionResult Proiecte()
        {
            ViewData["ProjData"] = EnumProjects(0);
            return View();
        }

        public IActionResult Recrutari()
        {
            return View();
        }
        public IActionResult Studenti()
        {
            return View();
        }     
    }
}
