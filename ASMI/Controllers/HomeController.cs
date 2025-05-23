﻿using ASMI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
            public List<String> desc;
            public List<String> imgs;
            public string director;
            public string facebook;
            public string linkedin;
            public string github;
            public string instagram;
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

        public class ZPDData
        {
            public string categ;
            public List<String> imgs;
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
                desc = "Sunt o oportunitate de practică pentru studenții de ani mai mari, de a-i ajuta pe cei de anul I sau II pe parcursul semestrului prin lecții organizate fizic în facultate. În cadrul acestora se lucrează exerciții pentru fixarea și însușirea noțiunilor studiate la curs, seminar sau laborator.",
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
                  "oportunitatea de a socializa și de a se distra. Printre acestea se numără Bumtzi (prima petrecere din anul universitar) și FeMeI Party.",
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
                    title = "Design & PR",
                    img = "images/DeliaDDDesign.jpg",
                    director = "Delia Tapai",
                    desc =  new List<string>{
                        "Dacă am putea descrie acest departament în două cuvinte acelea sigur ar fi \"Imaginea Asociației\". Imaginează-ți pentru câteva secunde cum ar arăta un proiect fără afișe, postări pe Facebook sau pe Instagram. Fie că este vorba de Recrutări sau Petreceri, fără o promovare ca la carte, lumea nu ar fi atrasă de evenimentele noastre iar informația ar ajunge la mult mai puțini oameni. De aceea, avem nevoie de mult ajutor din partea acestui departament pentru a transmite informația într-un mod cât mai plăcut și mai atrăgător.",
                        "Te consideri creativ și mereu ți-ai dorit să înveți concepte de bază în editare grafică? Sau deja te pricepi la programe de editare foto/video? Ai talent la desen, pasiune pentru fotografie sau pur și simplu îți dorești să înveți tot ce ți-am enumerat? Înseamnă că ai nimerit unde trebuie! La Design & PR îți poți dezvolta hard skillurile și poți să ajuți la toate proiectele Asociației!"
                        },
                    facebook = "https://www.facebook.com/delia.tapai.9",
                    linkedin = null,
                    instagram = "https://www.instagram.com/dwlwa/",
                    github = null,
                    imgs = new List<string>{
                        "images/design/d1.jpg",
                        "images/design/d2.JPG",
                        "images/design/d3.png",
                        "images/design/d4.jpg",
                        "images/design/d5.jpg",
                        "images/design/d6.jpg",
                        "images/design/d7.jpeg",
                        "images/design/d8.jpeg"
                    }
                },

                new DepData
                {
                    title = "Educațional",
                    img = "images/MateiDDEdu.jpg",
                    director = "Matei-Octavian Andrei",
                    desc = new List<string>{"Departamentul Educațional se ocupă direct de întreaga interacțiune atât cu studenții facultății noastre, cât și cu elevi care și-ar dori să urmeze FMI. Noi coordonăm voluntarii din întreaga Asociație în gestionarea proiectelor precum: Rățușca, Admiterea, Caravana Educațională, Ziua Porților Deschise. Cu ajutorul acestora reușim să motivăm și să oferim ajutor constant studenților pentru a le crea o experiență de neuitat într-una din cele mai semnificative perioade a vieții lor.", "Membrii departamentului dezvoltă abilităţi de public speaking, project management, teamwork şi leadership pe care le pot folosi în proiectele Asociaţiei și nu numai.", "În câteva cuvinte, Edu este cu şi pentru studenţi!", "Dacă şi tu vrei să îţi ajuţi colegii şi să încerci să faci anii petrecuţi în facultate mai buni, hai în echipa Edu!"},
                    facebook = "https://www.facebook.com/profile.php?id=61551758288923",
                    linkedin = null,
                    github = null,
                    instagram = "https://www.instagram.com/matei_21/",
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
                    img = "images/RobertDDHR.jpg",
                    director = "Robert-Gabriel Sîrbu",
                    desc = new List<string>{
                    "Noi suntem, pe scurt, „inima Asociației” ! Ne ocupăm de integrarea bobocilor ce ni se alătură în fiecare toamnă și primăvară, astfel încât aceștia să ajungă să se simtă cu adevărat parte din familia noastră. De asemenea, asigurăm dezvoltarea și motivarea constantă a voluntarilor noștri prin organizarea activităților de socializare.", "Pe lângă procesul de recrutare, proiecte precum Marea Ieșeală, Tre' să Caut, chiar și Petrecerile, sunt organizate de voluntarii acestui departament. Așa că, dacă ești o persoană empatică, altruistă, îți place să ajuți, să comunici cu oamenii și să organizezi activități, departamentul Human Resources te așteaptă cu brațele deschise!"
                    },
                    facebook = "https://www.facebook.com/robert.sirbu.18",
                    linkedin = null,
                    github = null,
                    instagram = null,
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
                },


                new DepData{
                    title = "Management & Fundraising",
                    img = "images/VladDDMF.jpg",
                    director = "Vlad Apostol",
                    desc = new List<string> { "Pentru ca un proiect să decurgă cum ne dorim este nevoie de muncă, dedicare și comunicare, însă pentru a crea ceva memorabil este nevoie de un element special, ceva să unească efortul comun și să ne dea aripi viselor. Aici intervin sponsorii noștrii care ne susțin în încercarea de a-i ajuta pe studenți. Noi suntem reprezentanții externi fiind primii cu care iau legătura firmele atunci când ne oferă sprijinul lor. De asemenea noi oferim o voce oamenilor dornici să spună ce le-a plăcut în cadrul evenimentelor, dar și ce trebuie îmbunătățit, astfel încât edițiile următoare să fie din ce în ce mai bune. În cadrul departamentului vei învăța ce înseamnă să organizezi un proiect, cum să discuți și să negociezi cu firme mari din domeniul IT și nu numai, dar și ce înseamnă munca în echipa, gestionarea resurselor și distracția alături de colegi. Dacă te interesează legătura dintre Asociație și companiile partenere și îți dorești să consolidezi mai departe aceste relații, dar și să creezi unele noi, atunci Management & Fundraising te așteaptă!" },
                    facebook = "https://www.facebook.com/vlad.apostol.71",
                    linkedin = null,
                    github = null,
                    instagram = "https://www.instagram.com/vlad._.avg/",
                    imgs = new List<string>{
                            "images/mf/d1.jpg",
                            "images/mf/d2.jpg",
                            "images/mf/d3.jpeg",
                            "images/mf/d4.jpeg",
                            "images/mf/d5.JPG",
                            "images/mf/d6.jpg",
                            "images/mf/d7.JPG"
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

        public IActionResult ButonulRosu()
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
        public IActionResult Elevi()
        {
            List<Proiect> proiecte = new List<Proiect>
            {
                new Proiect("Caravana Edu",
				"Ești elev de liceu și nu știi către ce facultate să te îndrepți? Ei bine, voluntarii ASMI te ajută să descoperi Facultatea de Matematică și Informatică a Universității din București!",
				new DateTime(2025,3,10), new DateTime(2025,3,14), "caravana.asmi.ro", "../images/CaravanaEducationala2.png"),

                new Proiect("Ziua Porților Deschise",
                "Dacă vrei să vezi cu ochii tăi facultatea în care îți poți petrece anii studenției, te invităm să participi la tururile ghidate, cursurile demonstrative și prezentările ofertei educaționale din cadrul Zilei Porților Deschise. În tot acest timp, voluntarii ASMI și profesorii Facultății vor fi alături de tine pentru a-ți răspunde la întrebări și curiozități.",
                new DateTime(2025,4,26), new DateTime(2025,4,27), "asmi.ro/zpd", "../images/zpd.png"),

                new Proiect("Hello FMI",
                "”Hello FMI” este o serie de evenimente sociale și academice organizate de ASMI cu scopul ca noii studenți să se acomodeze cât mai repede cu Facultatea și cu colegii lor. Printre acestea se numără Marea Ieșeală(serie de jocuri de cunoaștere prin care să-ți cunoști colegii), Tre' să caut (treasure hunt în București), Bumtzi(petrecere de început de an) și Dialog Deschis(prezentare a celor mai importante aspecte din viața de student și sesiune de Q&A cu voluntarii ASMI).",
                null, null, null, "../images/hellofmi.png"),

                new Proiect("Rățușca",
                "„Rățușca” este proiectul prin care intrăm în contact cu bobocii și îi introducem în viața de student al FMI. Încă din primele zile, voluntarii asociației se integrează cu grupele nou formate, și îi ghidează către primii pași ai studenției.",
                null, null, null, "../images/LogoDuckFinal.png")
			};

            ViewBag.Proiecte = proiecte;
            return View();
        }


        public IActionResult Zpd()
        {
            List<ZPDData> PozeZPD = new List<ZPDData> {

                new ZPDData{
                    categ = "Exterior",
                    imgs = new List<string>{
                        "images/zpd/e1.jpg",
                        "images/zpd/e2.jpg",
                        "images/zpd/e3.jpg",
                        "images/zpd/e4.jpg",
                        "images/zpd/e5.jpg",
                        "images/zpd/e6.jpg",
                        "images/zpd/e7.jpg"
                    }
                },

                new ZPDData{
                    categ = "Laboratorul Softbinator",
                    imgs = new List<string>{
                        "images/zpd/sb1.jpg",
                        "images/zpd/sb2.jpg",
                        "images/zpd/sb3.jpg",
                        "images/zpd/sb4.jpg",
                        "images/zpd/sb5.jpg",
                    }
                },

                new ZPDData
                {
                    categ = "Sala Google",
                    imgs = new List<string>{
                        "images/zpd/g1.jpg",
                        "images/zpd/g2.jpg",
                        "images/zpd/g3.jpg",
                        "images/zpd/g4.jpg",
                        "images/zpd/g5.jpg",
                        "images/zpd/g6.jpg"
                    }
                },

                new ZPDData
                {
                    categ = "Laboratorul de Robotică",
                    imgs = new List<string>
                    {
                        "images/zpd/rb1.jpg",
                        "images/zpd/rb2.jpg",
                        "images/zpd/rb3.jpg",
                        "images/zpd/rb4.jpg",
                        "images/zpd/rb5.jpg",
                        "images/zpd/rb6.jpg",
                        "images/zpd/rb7.jpg",
                        "images/zpd/rb8.jpg",
                        "images/zpd/rb9.jpg",
                        "images/zpd/rb10.jpg",
                        "images/zpd/rb11.jpg"
                    }
                },

                new ZPDData
                {
                    categ = "Săli și holuri",
                    imgs = new List<string>
                    {
                        "images/zpd/s1.jpg",
                        "images/zpd/s2.jpg",
                        "images/zpd/s3.jpg",
                        "images/zpd/s4.jpg",
                        "images/zpd/s5.jpg",
                        "images/zpd/s6.jpg"
                    }
                }
            };

            ViewBag.Poze = PozeZPD;
            return View();
        }

        public IActionResult Admitere()
        {
            return View();
        }
        public IActionResult DespreFMI()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

    
    }
}
