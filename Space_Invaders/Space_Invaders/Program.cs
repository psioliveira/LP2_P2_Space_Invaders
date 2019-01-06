using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Space_Invaders
{
    /// <summary>
    /// Classe program, no qual o programa corre.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Coleção thread-safe que vamos utilizar para passar as teclas lidas
        /// do produtor para o consumidor.
        /// </summary>
        private readonly BlockingCollection<ConsoleKey> queue;

        /// <summary>
        /// Valor base de milisegundos por frame.
        /// (17ms/frame = aprox. 60fps)
        /// </summary>
        private long MS_PER_FRAME = 17;

        /// <summary>
        /// Inicialia um objecto do tipo Scenario. 
        /// </summary>
        private Scenario scenario = new Scenario();


        /// <summary>Inicio do Programa</summary>
        static void Main()
        {
            Program prog = new Program();
            prog.Start();
        }

        /// <summary>Constroi uma instância da classe Program.</summary>

        public Program()
        {
            /// <summary>
            ///  Instanciar a coleção thread-safe; por omissão esta coleção
            /// utiliza uma fila, mas isto pode ser alterado invocando outro
            /// overload do construtor
            /// </summary>
            queue = new BlockingCollection<ConsoleKey>();
        }

        /// <summary>Inicia o programa propriamente dito.</summary>
        private void Start()
        {
            /// <summary> Declarar e instanciar thread produtora 
            /// (coloca teclas na coleção)</summary>
            Thread prodThread = new Thread(PlayerInput);
            /// <summary> Iniciar thread </summary>
            prodThread.Start();
            /// <summary> Esperar que as threads terminem </summary>
            prodThread.Join();
            /// <summary>chama o metodo GameLoop </summary>
            GameLoop();
        }

        /// <summary> metodo que realiza o gameloop </summary>
        void GameLoop()
        {
            while (true)
            {
                long start = DateTime.Now.Ticks; // 10000 ticks = 1 segundo
                // Iniciar threads
                ColectInput();
                Update();
                Render();
                Thread.Sleep(Convert.ToInt32((start / 10000) + MS_PER_FRAME - (DateTime.Now.Ticks / 10000)));
            }
        }

        /// <summary>
        /// Método que lê teclas do teclado e coloca-as na fila thread-safe.
        /// </summary>
        private void PlayerInput()
        {
            // Variável para as teclas pressionadas
            ConsoleKey key;

            // Ler teclas pressionadas enquanto o escape não for pressionado
            do
            {
                // Lê tecla premida
                key = Console.ReadKey(false).Key;

                queue.Add(key);

            } while (key != ConsoleKey.Escape);
        }


        /// <summary>Metodo que coleta o input do jogador </summary>
        private void ColectInput()
        {
            // Variável para as teclas retiradas da coleção
            ConsoleKey key;

            // Ler teclas pressionadas enquanto o escape não for pressionado
            while (queue.TryTake(out key) || key == ConsoleKey.Escape)
            {

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow || key == ConsoleKey.Spacebar)
                {
                    
                }

                else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                {
                    
                }
                else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                {
                    
                }

            }
        }

        /// <summary> metodo update </summary>
        private void Update()
        {

        }

        /// <summary> metodo renderer </summary>
        public void Render() { }

    }





}


