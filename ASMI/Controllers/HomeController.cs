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
            public string director;
            public string facebook;
            public string linkedin;
            public string github;
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
                desc = "„Artă'n Dar” este un eveniment care promovează cultura și arta în rândul studenților și, în același timp, urmărește scopul de a împărți bucurie și cadouri oamenilor care au cea mai mare nevoie.",
                name = "Artă’n Dar",
                url = null
            },
            new ProjData {
                img = "cariere.png",
                desc = "„Cariere” este un târg de joburi și internship-uri care oferă un sprijin în dezvoltarea pe plan profesional a studenților, realizând o legătură între aceștia și o parte dintre cele mai cunoscute companii de pe piața IT din România.",
                name = "Cariere",
                url = "https://cariere.asmi.ro/"
            },
            new ProjData {
                img = "logo-zile-1.png",
                desc = "Acest eveniment este organizat pentru sărbătorirea zilei înființării asociației. Este dedicat tuturor studenților FMI care vor să își facă prieteni noi, să participe la competiții sportive, seri de boardgames, seri de teatru, campionate de CS/LOL etc.",
                name = "Zilele ASMI",
                url = null
            },
            new ProjData {
                img = "smarthack.png",
                desc = "„Smarthack” este un hackathon de 24 de ore în care mai multe echipe formate din câte 3-4 studenţi, lucrează la dezvoltarea unui produs software pe baza unei teme, care se finalizează cu jurizarea şi premierea celor mai bune echipe de către cele mai mari firme din IT din România.",
                name = "SMARTHACK",
                url = "https://smarthack.asmi.ro/"
            },
            new ProjData {
                img = "CaravanaEducationala.png",
                desc = "Ești elev de liceu și nu știi către ce facultate să te îndrepți? Ei bine, voluntarii ASMI te ajută să descoperi Facultatea de Matematică și Informatică a Universității din București!",
                name = "CARAVANA EDUCAȚIONALĂ",
                url = "https://caravana.asmi.ro/"
            },
            new ProjData {
                img = "Logo_practica.png",
                desc = "„Practica” este proiectul care vine în ajutorul studenților din an terminal, cu scopul de a își echivala orele de practică necesare obținerii diplomei de licență.",
                name = "PRACTICA",
                url = null
            },
            new ProjData {
                img = "SOS-LOGO-FINAL.png",
                desc = "„Students' Organizations Showdown” este un campionat caritabil de CS:GO între asociațiile studențești, în cadrul căruia strângem donații pentru o cauză nobilă.",
                name = "Students’ Organizations Showdown",
                url = null
            },
            new ProjData {
                img = "logo-marea-ieseala.png",
                desc = "„Marea Ieșeală” este unul dintre primele proiecte ale asociației cu care te întâlnești ca boboc la Facultatea de Matematică și Informatică.",
                name = "Marea Ieșeală",
                url = null
            },
            new ProjData {
                img = "LogoDuckFinal.png",
                desc = "„Rățușca” este proiectul prin care intrăm în contact cu bobocii și îi introducem în viața de student al FMI. Încă din primele zile, voluntarii asociației se integrează cu grupele nou formate, și îi ghidează către primii pași ai studenției.",
                name = "Rățusca",
                url = null
            },
            new ProjData {
                img = "Logo_Tre_Sa_Caut.png",
                desc = "„Tre' să caut” este un treasure hunt care se desfășoară în București. Scopul este familiarizarea studenților cu locuri importante din jurul zonei universității, dar mai ales, scopul lui îl reprezintă cunoașterea mai bună a colegilor și formarea de legături noi cu aceștia.",
                name = "Tre’ să caut",
                url = null
            },
            new ProjData {
                img = "logo_raport_cdos.png",
                desc = "Prin chestionarul CDOS se urmărește nivelul de satisfacție al studenților cu privire la condițiile oferite de facultate, cât și dacă le-au fost respectate drepturile sau nu.",
                name = "Raport CDOS",
                url = "https://drive.google.com/file/d/1pwDIlcFrw_NOgOtDSq8pvnbA6eF8vtVJ/view?usp=sharing"
            },
            new ProjData
            {
                img = null,
                desc = "Acest eveniment este dedicat noilor studenți FMI. În cadrul acestuia au loc diverse probe prin care trec candidații " +
                "pentru Miss și Mister FMI, iar în urma acestora, sunt desemnați câștigătorii titlurilor.",
                name = "Balul Bobocilor",
                url = null
            },
            new ProjData
            {
                img = null,
                desc = "În cadrul acestui proiect, voluntarii asociației ajută la buna desfășurare a procesului de admitere, creând un grup de Facebook " +
                "în care ei răspund la toate întrebările candidaților, îndrumându-i către sălile de depunere a dosarelor și ajutându-i să completeze " +
                "documentele necesare și multe altele.",
                name = "Admitere",
                url = null
            },
            new ProjData
            {
                img = null,
                desc = "Acest proiect este organizat la începutul anului universitar, fiind adresat " +
                "noilor studenți și constă în discuții voluntari-boboci, pentru a le oferi informații " +
                "și a  le răspunde la întrebări.",
                name = "Dialog Deschis",
                url = null
            },
             new ProjData
             {
                img = null,
                desc = "Acest proiect se desfășoară la începutul anului universitar, deoarece scopul său este de a motiva și de a " +
                 "pregăti studenții să aplice la firmele de top din domeniu (Google, Facebook, Amazon etc.). Constă într-o " +
                 "prezentare din partea diverselor persoane care au fost interni în cadrul acestora.",
                name = "InternView",
                url = null
             },

             new ProjData
             {
                img = null,
                desc = "Sunt o oportunitate de practică pentru studenții de ani mai mari, de a-i ajuta pe cei de anul I sau II pe parcursul semestrului prin lecții organizate online. În cadrul acestora se lucrează exerciții pentru fixarea și însușirea noțiunilor studiate la curs, seminar sau laborator.",
                name = "Tutoriate",
                url = null
             },

             new ProjData
             {
                img = null,
                desc = "Acest proiect se desfășoară imediat înainte de începerea recrutărilor din toamnă. El constă într-o prezentare a asociației, " +
                 "a departamentelor și a proiectelor sale și are rolul de a oferi studenților o înțelegerea mult mai bună a asociației cât și să îi " +
                 "motiveze să participe la procesul de recrutare pentru a deveni voluntari.",
                name = "Meet ASMI",
                url = null
             },
              new ProjData
              {
                img = null,
                desc = "Pentru a asigura continuitatea asociației și bunul mers al proiectelor, sunt organizate 2 sesiuni de recrutare în ASMI. Prima " +
                  "sesiune are loc în luna octombrie, odată cu venirea noilor studenți, iar cealaltă în luna mai, pentru a le oferi ocazia de a se " +
                  "implica și celor care nu au avut șansa să intre în asociație în toamnă.",
                name = "Recrutări",
                url = null
              },
              new ProjData
              {
                img = null,
                desc = "ASMI organizează o multitudine de petreceri pentru a le face viața studențească mai frumoasă și pentru a le oferi studenților " +
                  "oportunitatea de a socializa și de a se distra. Printre acestea se numără Bumtzi (prima petrecere din anul universitar), FeMeI Party,"  +
                  "ASMI Party și Petrecerea de Trecere. ",
                name = "Petreceri ASMI",
                url = null
              }
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
                    title = "Management & Fundraising",
                    img = "images/dd_mf.jpg",
                    director = "Andreea Gherghescu",
                    desc = "Principalul nostru obiectiv este să îmbunătățim condițiile în care decurg evenimentele asociației. Acest lucru îl realizăm prin supervizarea desfășurării proiectelor ASMI și dezvoltarea acestora pe mai departe, dar și intrând în contact direct cu diverse firme (din domeniul IT și nu numai), cu care încheiem contracte de sponsorizare. Un alt lucru important pentru noi este feedback-ul, fiind mereu acolo ca să ascultăm ideile și sugestiile voluntarilor noștri. În perioada pandemiei, asociația a continuat să păstreze relația cu mediul de afaceri, și a adus sponsorizări și oportunități pentru studenții FMI. Ce câștigi dacă faci parte din acest departament? Abilități de negociere, contact cu mulți oameni din diverse companii pe care le poți fructifica după facultate și traininguri speciale (project management, Linkedin, fundraising). Simți că ai idei originale și interesante? Îți place să organizezi un eveniment până la cel mai mic detaliu? Dacă răspunsul la oricare din întrebările acestea este da, departamentul Management & Fundraising este pentru tine!",
                    facebook = "https://www.facebook.com/andreea.gherghescu.94/",
                    linkedin = null,
                    github = "https://github.com/AndreeaGherghescu",
                    imgs = new List<string>{
                        "images/mf/d1.jpg",
                        "images/mf/d2.jpg",
                        "images/mf/d3.jpeg",
                        "images/mf/d4.jpeg",
                        "images/mf/d5.JPG",
                        "images/mf/d6.jpg",
                        "images/mf/d7.JPG"
                    }
                },

                new DepData
                {
                    title = "Design & PR",
                    img = "images/dd_design.jpg",
                    director = "Andreea Ciurescu",
                    desc = "Dacă am putea descrie acest departament în două cuvinte acelea sigur ar fi 'imaginea asociației'. Imaginează-ți pentru câteva secunde cum ar arăta un proiect fără afișe, postări pe Facebook sau pe Instagram, de exemplu Recrutările sau ce zici de o petrecere? Exact, informația ar ajunge la mult mai puțini oameni, sau cei care ar ști nu ar veni, deoarece nu i-a atras nimic auzind o informație doar prin viu grai. De aceea, avem nevoie de mult ajutor din partea acestui departament pentru a transmite informația într-un mod cât mai plăcut și mai atrăgător. Te pricepi la photoshop/editare video/grafică? Ai talent la desen sau pur și simplu îți dorești să înveți tot ce ți-am enumerat? Înseamnă că ai nimerit unde trebuie, la Design & PR îți poți dezvolta hard skillurile și poți să ajuți la toate proiectele asociației!",
                    facebook = "https://www.facebook.com/andreea.ciurescu",
                    linkedin = "https://www.linkedin.com/in/andreea-ciurescu-4527601bb/",
                    github = null,
                    imgs = new List<string>{
                        "images/design/d1.jpg",
                        "images/design/d2.JPG",
                        "images/design/d3.jpg",
                        "images/design/d4.jpeg",
                        "images/design/d5.jpg",
                        "images/design/d6.jpg",
                        "images/design/d7.JPG"
                    }
                },

                new DepData
                {
                    title = "Educațional",
                    img = "images/dd_edu.jpeg",
                    director = "Liviu Păun",
                    desc = "Departamentul Educațional are ca scop îmbunătățirea calității vieții academice a studenților, reprezentând o punte de legătură între aceștia și Conducerea Facultății. Cu ce se ocupă mai exact Edu? Proiecte precum Admiterea, Tutoriate, Ziua Porților Deschise, Rățușca și, mai recent, Practica sunt organizate de voluntarii noștri, care sunt motivați să ajute studenții să aibă o experiență a anilor de Facultate cât mai plăcută. Membrii departamentului facilitează comunicarea cu Decanatul, învață public speaking, organizează evenimentele vitale desfășurării anului universitar și lucrează activ la identificarea și soluționarea problemelor studențești. Deci, dacă vrei să-ți ajuți colegii, ți-ar plăcea să îi reprezinți sau să contribui la organizarea proiectelor care îi influențează pe plan academic, Edu este pentru tine!",
                    facebook = "https://www.facebook.com/liviu.paun.779",
                    linkedin = "https://www.linkedin.com/in/liviu-p%C4%83un-149813222",
                    github = null,
                    imgs = new List<string>{
                        "images/edu/d1.jpeg",
                        "images/edu/d2.jpeg",
                        "images/edu/d3.jpeg",
                        "images/edu/d4.jpeg",
                        "images/edu/d5.jpeg",
                        "images/edu/d6.jpeg",
                        "images/edu/d7.jpeg",
                        "images/edu/d8.jpeg"
                    }
                },

                new DepData
                {
                    title = "Human Resources",
                    img = "images/dd_hr.jpeg",
                    director = "Miruna Vasiliu",
                    desc = "Noi suntem, în câteva cuvinte, 'inima asociației'! Ne ocupăm de integrarea bobocilor ce ni se alătură în fiecare toamnă și primăvară, astfel încât ei să ajungă să se simtă cu adevărat parte din familia noastră, dar și de bunăstarea tuturor voluntarilor, prin organizarea de joculețe interactive și de activități de socializare. În timpul pandemiei, am adaptat aceste activități de socializare în mediul online prin intermediul unor seri de jocuri sau de trivia. În plus, asigurăm dezvoltarea și motivarea constanta a voluntarilor noștri. Așa că, dacă îți place să comunici cu oamenii, să organizezi activități și să ajuți persoane, departamentul de Resurse Umane este pentru tine!",
                    facebook = "https://www.facebook.com/miruna.vasiliu.39/",
                    linkedin = "https://www.linkedin.com/in/miruna-vasiliu-258064215/",
                    github = null,
                    imgs = new List<string>{
                        "images/hr/d1.jpg",
                        "images/hr/d2.JPG",
                        "images/hr/d3.png",
                        "images/hr/d4.jpg",
                        "images/hr/d5.png",
                        "images/hr/d6.jpg",
                        "images/hr/d7.jpeg",
                        "images/hr/d8.jpeg"
                       
                    }
                }

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
        public IActionResult Galerie()
        {
            return View();
        }     
    }
}
