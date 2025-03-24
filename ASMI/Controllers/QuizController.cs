using System.Collections.Generic;
using System;
using ASMI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;

namespace ASMI.Controllers
{
    public class QuizController : Controller
    {

        private Quiz getQuiz()
        {
            Quiz quiz = new Quiz();

            QuizQuestion question1 = new QuizQuestion(
                "Dacă ai fi un animal de companie, ce ai fi?",
                new List<string> { "O pisică", "O bufniță", "Un golden retriever", "O vulpe" });

            QuizQuestion question2 = new QuizQuestion(
            "Ești într-un film horror. Ce faci?",
            new List<string> {
                "Desenez o hartă artistică a casei bântuite ca să găsesc ieșirea",
                "Sun un prieten și îi explic toată situația logic, poate are o idee bună",
                "Îi conving pe toți să ne ținem aproape și să nu ne despărțim",
                "Negociez cu fantoma"
            });

            QuizQuestion question3 = new QuizQuestion(
                "Ce superputere ai vrea să ai?",
                new List<string> {
                "Să creez orice din aer",
                "Să absorb instant orice informație",
                "Să citesc gândurile oamenilor",
                "Să conving pe oricine să-mi dea ce vreau"
                });

            QuizQuestion question4 = new QuizQuestion(
                "Ce emoji te reprezintă cel mai bine?",
                new List<string> {
                "🎨",
                "🧐",
                "🤗",
                "💰"
                });

            QuizQuestion question5 = new QuizQuestion(
                "Ce ai face dacă ai fi blocatx pe o insulă pustie?",
                new List<string> {
                "Aș sculpta niște semne artistice pe copaci, poate mă salvează cineva",
                "Aș scrie un jurnal detaliat despre fiecare zi",
                "Aș găsi un mod de a face totul distractiv și să păstrez moralul sus",
                "Aș negocia cu un pirat să mă ducă înapoi la civilizație"
                });

            QuizQuestion question6 = new QuizQuestion(
                "Ce fel de pâine ai fi?",
                new List<string> {
                "O pâine artizanală cu forme ciudate",
                "O pâine integrală, plină de semințe",
                "O pâine pufoasă și caldă",
                "O baghetă franțuzească"
                });

            QuizQuestion question7 = new QuizQuestion(
                "Dacă ai putea trăi într-un alt timp, unde ai merge?",
                new List<string> {
                "În perioada Renașterii",
                "În viitor",
                "În anii ‘70",
                "În perioada regilor și reginelor"
                });

            quiz.questions = new List<QuizQuestion>{ question1, question2, question3, question4, question5, question6, question7};

            return quiz;

        }
        [HttpGet]
        public IActionResult Index()
        {
            Quiz quiz = getQuiz();
            return View(quiz);
        }

        [HttpPost]
        public IActionResult Index( Quiz formQuiz)
        {
            // 7 INTREBARI HARDCODAT !!! DE REZOLVAT!
            if(formQuiz.answers.Count != 7)
            {
                ModelState.AddModelError(string.Empty, "All questions have to be answered!");
                return View(getQuiz());
            }

            var answers = formQuiz.answers;

            int design = 0, edu = 0, hr = 0, mf = 0;

            foreach (string answer in answers)
            {
                if (answer[0] == '1')
                {
                    design++;
                }
                else if (answer[0] == '2')
                {
                    edu++;
                }
                else if (answer[0] == '3')
                {
                    hr++;
                }
                else
                {
                    mf++;
                }
            }

            ViewBag.scores = new List<int> { design, edu, hr, mf };


            return View(null);
        }

    }
}
