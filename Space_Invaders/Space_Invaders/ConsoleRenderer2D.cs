using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Space_Invaders
{
    class ConsoleRenderer2D
    {
        private readonly char alive, dead;

        // Construtor
        public ConsoleRenderer2D(char alive, char dead)
        {
            this.alive = alive;
            this.dead = dead;
        }

        // Faz o setup inicial antes da renderização começar
        public void Setup(IBuffer2D<IEntity> worldToRender)
        {
            // Limpar a consola
            Console.Clear();

            // Esconder o cursor pois causa distração
            Console.CursorVisible = false;

            // Se estivermos em Windows vamos meter o terminal com o tamanho do
            // mundo de simulação (não suportado em Linux e Mac)
            // (é nescessário o projecto estar em .Net Framework 4.7.2)
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(
                    worldToRender.XDim, worldToRender.YDim + 2);
            }
        }

        // Método que faz a renderização
        public void Render(IBuffer2D<IEntity> worldToRender)
        {
            // Usamos uma instância de StringBuilder para criar uma string de
            // forma eficiente, indicando o tamanho final dessa string
            StringBuilder sb = new StringBuilder(
                worldToRender.XDim * worldToRender.YDim
                +
                Environment.NewLine.Length * worldToRender.YDim);

            // Construir a string contendo o mundo
            for (int y = 0; y < worldToRender.YDim; y++)
            {
                for (int x = 0; x < worldToRender.XDim; x++)
                {
                    sb.Append(worldToRender[x, y].Alive ? alive : dead);
                }
                sb.Append(Environment.NewLine);
            }

            // Posicionar cursor no início
            Console.SetCursorPosition(0, 0);

            // Mostrar mundo
            Console.WriteLine(sb.ToString());
        }
    }
}
