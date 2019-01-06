
namespace Space_Invaders
{
    /// <summary>
    /// interface responsável pela renderização 
    /// </summary>
    interface IRenderer2D
    {
        /// <summary>
     /// metodos para o setup inicial 
     /// </summary>
        void Setup(Slot worldToRender);

        /// <summary>
        /// metodos de renderização
        /// </summary>
        void Render(Slot worldToRender);
    }
}
