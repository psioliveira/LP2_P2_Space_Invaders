
namespace Space_Invaders
{
    public interface IEntity
    {
        //number of slots in world space
        uint SlotNumber { get; set; }
        //first slot coordinates
        uint SCoorX { get; set; }
        uint SCoory { get; set; }
    }
}
