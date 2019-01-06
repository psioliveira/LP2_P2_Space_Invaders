using System;
using System.Runtime.InteropServices;

namespace Space_Invaders
{
    /// <summary>
    /// calsse para controlar a renderização e o tamanho da tela. 
    /// </summary>
    class ConsoleRenderer2D
    {
        // Construtor
        public ConsoleRenderer2D()
        {
        }

        /// <summary>
        /// metodos para o setup inicial da tela
        /// </summary>
        public void Setup(Scenario worldToRender)
        {
            /// <summary>
            /// limpa a consola
            /// </summary>
            Console.Clear();

            /// <summary>
            /// esconde o cursor
            /// </summary>
            Console.CursorVisible = false;

            /// <summary>
            /// Se estivermos em Windows adicionar o 
            /// terminal com o tamanho do mundo de simulação.
            /// </summary>

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                /// <summary>
                /// cenario de tamanho fixo,
                /// </summary>
                Console.SetWindowSize(87, 45);
            }
        }

        /// <summary>
        /// Metodo que realiza a renderização. 
        /// </summary>
        public void Render(Scenario worldToRender)
        { /// <summary>
          /// Posicionar cursor no início. 
          /// </summary>
            Console.SetCursorPosition(0, 0);
            Draw_Hud();
        }


        /// <summary>
        /// desenha o Hud.
        /// </summary>
        public void Draw_Hud()
        {
            Console.WriteLine("000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000000");
            Console.WriteLine("000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000000");
            Console.SetCursorPosition(2, 2);
            Console.Write("Score:");

            Console.SetCursorPosition(2, 68);
            Console.Write("Lives: ");

            Console.SetCursorPosition(0, 29);
            Console.WriteLine("000000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine("000000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000");
        }


    }
}
