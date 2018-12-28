
namespace Space_Invaders
{
    interface IRenderer2D
    {
        // Método que faz o setup inicial antes da renderização começar
        void Setup(IBuffer2D<IEntity> worldToRender);

        // Método que realiza a renderização
        void Render(IBuffer2D<IEntity> worldToRender);
    }
}
