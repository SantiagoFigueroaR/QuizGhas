using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGhas
{
    public class Pregunta
    {
        public string PreguntaTexto { get; set; }
        public List<string> Opciones { get; set; }
        public int RespuestaCorrecta { get; set; }
    }
}
