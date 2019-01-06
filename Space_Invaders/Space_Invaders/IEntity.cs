
namespace Space_Invaders
{
    /// <summary>
    /// ~Interface para as entidades do jogo, como player,
    /// inimigos, entre outros.
    /// </summary>
    public interface IEntity
    {
        //number of slots in world space
        uint ID { get; set; }
        uint SlotNumber { get; set; }
        //first slot coordinates
        uint SCoorX { get; set; }
        uint SCoorY { get; set; }

        //characteres for the slots
        char[] Visual { get; set; }
    }
}
