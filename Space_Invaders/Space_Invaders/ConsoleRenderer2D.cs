using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Space_Invaders
{
    class ConsoleRenderer2D
    {
        // Construtor
        public ConsoleRenderer2D()
        {
        }

        // Faz o setup inicial
        public void Setup(Scenario worldToRender)
        {
            // Limpar a consola
            Console.Clear();

            // Esconder o cursor
            Console.CursorVisible = false;

            // Se estivermos em Windows adicionar o terminal com o tamanho do mundo de simulação
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //cenário contém um tamanho fixo
                Console.SetWindowSize(87, 45);
            }
        }

        // Método que faz a renderização
        public void Render(Scenario worldToRender)
        {
            // Posicionar cursor no início
            Console.SetCursorPosition(0,0);
            Draw_Hud();
        }

      

        public void Draw_Hud()
        {
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(2, 2);
            Console.Write("Score:" );

            Console.SetCursorPosition(2, 68);
            Console.Write("Lives: ");

            Console.SetCursorPosition(0, 29);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        }


    }
}
