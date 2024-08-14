using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace QuizGhas
{
    public partial class Form1 : Form
    {
        private List<Pregunta> preguntas;
        private List<int> respuestasUsuario;
        private int preguntaActual = 0;
        private int puntaje = 0;
        private Timer temporizador; // Declarar el temporizador
        private int tiempoRestante = 3600; // Tiempo total en segundos (60 minutos)

        public Form1()
        {
            InitializeComponent();
            CargarPreguntas();
            respuestasUsuario = new List<int>();
            for (int i = 0; i < preguntas.Count; i++)
            {
                respuestasUsuario.Add(-1); // Inicializar la lista con valores -1
            }

            // Inicializar el temporizador
            temporizador = new Timer();
            temporizador.Interval = 1000; // 1 segundo
            temporizador.Tick += Temporizador_Tick;
            temporizador.Start();

            MostrarPregunta();
        }

        private void CargarPreguntas()
        {
            string json = File.ReadAllText("preguntas.json"); // Ruta del archivo JSON
            preguntas = JsonConvert.DeserializeObject<List<Pregunta>>(json);
            // Mezclar las preguntas aleatoriamente
            Random rnd = new Random();
            preguntas = preguntas.OrderBy(x => rnd.Next()).ToList();
        }

        private void MostrarPregunta()
        {
            if (preguntaActual < preguntas.Count)
            {
                // Mostrar el número de pregunta actual y total
                lblNumeroPregunta.Text = $"Pregunta {preguntaActual + 1} / {preguntas.Count}";

                var pregunta = preguntas[preguntaActual];
                lblPregunta.Text = pregunta.PreguntaTexto;
                rdbtnOpcion1.Text = pregunta.Opciones[0];
                rdbtnOpcion2.Text = pregunta.Opciones[1];
                rdbtnOpcion3.Text = pregunta.Opciones[2];

                rdbtnOpcion4.Visible = pregunta.Opciones.Count > 3;
                rdbtnOpcion4.Text = pregunta.Opciones.Count > 3 ? pregunta.Opciones[3] : "";

                rdbtnOpcion5.Visible = pregunta.Opciones.Count > 4;
                rdbtnOpcion5.Text = pregunta.Opciones.Count > 4 ? pregunta.Opciones[4] : "";

                // Habilitar los RadioButtons y el botón Validar
                rdbtnOpcion1.Enabled = true;
                rdbtnOpcion2.Enabled = true;
                rdbtnOpcion3.Enabled = true;
                rdbtnOpcion4.Enabled = pregunta.Opciones.Count > 3;
                rdbtnOpcion5.Enabled = pregunta.Opciones.Count > 4;
                btnValidar.Enabled = true;

                // El botón Siguiente está habilitado para permitir avanzar sin validar
                btnSiguiente.Enabled = true;

                // Desmarcar los RadioButtons al mostrar una nueva pregunta
                rdbtnOpcion1.Checked = false;
                rdbtnOpcion2.Checked = false;
                rdbtnOpcion3.Checked = false;
                rdbtnOpcion4.Checked = false;
                rdbtnOpcion5.Checked = false;
            }
        }

        // Manejo del evento Tick del temporizador
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            // Mostrar el tiempo restante en la interfaz
            lblTiempoRestante.Text = $"Tiempo restante: {tiempoRestante / 60}:{tiempoRestante % 60:D2}";

            // Si el tiempo se agota
            if (tiempoRestante <= 0)
            {
                temporizador.Stop(); // Detener el temporizador
                MessageBox.Show("Se ha agotado el tiempo.");

                // Finalizar el quiz o manejar el tiempo agotado a su gusto
                FinalizarQuiz();
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = ObtenerOpcionSeleccionada();

            if (indiceSeleccionado != -1)
            {
                // Guardar la respuesta seleccionada por el usuario
                respuestasUsuario[preguntaActual] = indiceSeleccionado;

                var pregunta = preguntas[preguntaActual];
                if (indiceSeleccionado == pregunta.RespuestaCorrecta)
                {
                    MessageBox.Show("¡Correcto!");
                    puntaje++;
                    MostrarRespuestaCorrecta(); // Mostrar la respuesta correcta por 5 segundos
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.");
                    MostrarRespuestaCorrecta(); // Mostrar la respuesta correcta por 5 segundos
                }

                // Deshabilitar solo el botón Validar, no los RadioButtons
                btnValidar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción antes de validar.");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            GuardarRespuestaActual(); // Asegurar que la respuesta se guarda antes de avanzar

            preguntaActual++;
            if (preguntaActual < preguntas.Count)
            {
                MostrarPregunta();
            }
            else
            {
                MessageBox.Show("No hay más preguntas.");
                btnSiguiente.Enabled = false; // Deshabilitar el botón Siguiente al final del quiz
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarQuiz(); // Llamar a la función para finalizar el quiz
        }

        private void FinalizarQuiz()
        {
            temporizador.Stop(); // Detener el temporizador al finalizar
            puntaje = 0;
            int totalPreguntasContestadas = 0;
            for (int i = 0; i < preguntas.Count; i++)
            {
                if (respuestasUsuario[i] != -1)
                {
                    totalPreguntasContestadas++;
                    if (respuestasUsuario[i] == preguntas[i].RespuestaCorrecta)
                    {
                        puntaje++;
                    }
                }
            }

            MessageBox.Show($"Quiz finalizado. Puntaje total: {puntaje} de {totalPreguntasContestadas}");

            // Cerrar la aplicación
            Application.Exit();
        }

        // Nueva función para guardar la respuesta actual si no se ha validado
        private void GuardarRespuestaActual()
        {
            int indiceSeleccionado = ObtenerOpcionSeleccionada();
            if (indiceSeleccionado != -1)
            {
                respuestasUsuario[preguntaActual] = indiceSeleccionado;
            }
            else
            {
                respuestasUsuario[preguntaActual] = -1; // Guardar -1 si no se ha seleccionado ninguna opción
            }
        }

        // Ocultar la respuesta correcta después de 5 segundos
        private async void MostrarRespuestaCorrecta()
        {
            // Obtener la respuesta correcta para la pregunta actual
            int respuestaCorrecta = preguntas[preguntaActual].RespuestaCorrecta;

            // Mostrar la respuesta correcta en un label o mensaje
            // (Reemplaza "lblRespuesta" con el nombre de tu label)
            lblRespuestaCorrecta.Text = $"La respuesta correcta es: {preguntas[preguntaActual].Opciones[respuestaCorrecta]}";
            lblRespuestaCorrecta.Visible = true;

            // Esperar 5 segundos
            await Task.Delay(5000);

            // Ocultar la respuesta correcta
            lblRespuestaCorrecta.Visible = false;
        }

        // Obtener la opción seleccionada
        private int ObtenerOpcionSeleccionada()
        {
            if (rdbtnOpcion1.Checked) return 0;
            if (rdbtnOpcion2.Checked) return 1;
            if (rdbtnOpcion3.Checked) return 2;
            if (rdbtnOpcion4.Checked) return 3;
            if (rdbtnOpcion5.Checked) return 4;
            return -1; // No se seleccionó nada
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (preguntaActual > 0)
            {
                preguntaActual--;
                MostrarPregunta();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            int indiceSeleccionado = ObtenerOpcionSeleccionada();

            if (indiceSeleccionado != -1)
            {
                // Guardar la respuesta seleccionada por el usuario
                respuestasUsuario[preguntaActual] = indiceSeleccionado;

                var pregunta = preguntas[preguntaActual];
                if (indiceSeleccionado == pregunta.RespuestaCorrecta)
                {
                    MessageBox.Show("¡Correcto!");
                    puntaje++;
                    MostrarRespuestaCorrecta(); // Mostrar la respuesta correcta por 5 segundos
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.");
                    MostrarRespuestaCorrecta(); // Mostrar la respuesta correcta por 5 segundos
                }

                // Deshabilitar solo el botón Validar, no los RadioButtons
                btnValidar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción antes de validar.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rdbtnOpcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}