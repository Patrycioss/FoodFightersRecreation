namespace GXPEngine.player;

public interface IPlayerKeyMap
{
    public int Left { get; }
    public int Right { get; }
    public int Down { get; }
    public int Attack { get; }
    public int Swap { get; }
}