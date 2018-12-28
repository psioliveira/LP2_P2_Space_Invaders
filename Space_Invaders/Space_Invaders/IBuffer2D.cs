namespace Space_Invaders
{
    interface IBuffer2D<T>
    {
        int XDim { get; }
        int YDim { get; }
        T this[int x, int y] { get; }
    }
}
