﻿using Microsoft.AspNetCore.Mvc;

namespace FridaReads.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MartinFierroController : Controller
    {
        private static readonly List<string> Phrases = new List<string>
        {
            "Los hermanos sean unidos / porque ésa es la ley primera, / tengan unión verdadera, / en cualquier tiempo que sea, / porque si entre ellos se pelean / los devoran los de ajuera",
            "Junta esperencia en la vida / Hasta pa dar y prestar / Quien la tiene que pasar / Entre sufrimiento y llanto, / Porque nada enseña tanto / Como el sufrir y el llorar",
            "Hay hombres que de su ciencia / Tienen la cabeza llena; / Hay sabios de todas menas, / Mas digo sin ser muy ducho / Es mejor que aprender mucho / El aprender cosas buenas",
            "Un padre que da consejos, / Más que padre es un amigo / Y así como tal les digo / Que vivan con precaución / Que nadie sabe en qué rincón / Se esconde el que es su enemigo",
            "Estas cosas y otras muchas, / Medité en mis soledades / Sepan que no hay falsedades / Ni error en estos consejos / Es de la boca del viejo / De ande salen las verdades",
            "Al que es amigo, jamás / lo dejen en la estacada / Pero no le pidan nada / Ni lo aguarden todo de él / Siempre el amigo más fiel / es una conduta honrada",
            "Yo soy toro en mi rodeo / Y torazo en rodeo ajeno; / Siempre me tuve por güeno / Y si me quieren probar, / Salgan otros a cantar / Y veremos quién es menos",
            "Mucho tiene que contar / el que tuvo que sufrir, / y empezaré por pedir / no duden de cuanto digo, / pues debe crerse al testigo / si no pagan por mentir",
            "Lo que pinta este pincel / ni el tiempo lo ha de borrar; / ninguno se ha de animar a corregirme la plana; / no pinta quien tiene gana / sino quien sabe pintar",
            "Y no piensen los oyentes / que del saber hago alarde; / he conocido, aunque tarde, / sin haberme arrepentido, / que es pecado cometido / el decir ciertas verdades",
        };

        [HttpGet("phrase")]
        public ActionResult<string> GetRandomPhrase()
        {
            var random = new Random();
            var randomPhrase = Phrases[random.Next(Phrases.Count)];
            return Ok(randomPhrase);
        }
    }
}
