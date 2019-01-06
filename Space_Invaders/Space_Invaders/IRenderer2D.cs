
namespace Space_Invaders
{
    interface IRenderer2D
    {
        // Método que faz o setup inicial antes da renderização começar
        void Setup(Slot worldToRender);

        // Método que realiza a renderização
        void Render(Slot worldToRender);
    }
}
