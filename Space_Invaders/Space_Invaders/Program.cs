using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using System.Threading;

namespace Space_Invaders
{
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
            //  Instanciar a coleção thread-safe; por omissão esta coleção
            // utiliza uma fila, mas isto pode ser alterado invocando outro
            // overload do construtor
            queue = new BlockingCollection<ConsoleKey>();
        }

        /// <summary>Inicia o programa propriamente dito.</summary>
        private void Start()
        {
            // Declarar e instanciar thread produtora (coloca teclas na
            // coleção) e thread consumidora (retira teclas da coleção)
            Thread prodThread = new Thread(PlayerInput);
            // Iniciar thread
            prodThread.Start();
            // Esperar que as threads terminem
            prodThread.Join();

            GameLoop();
        }


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


        private void Update()
        {

        }


        public void Render() { }

    }





}


