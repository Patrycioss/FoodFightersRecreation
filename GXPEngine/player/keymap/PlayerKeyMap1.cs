namespace GXPEngine.player;

public class PlayerKeyMap1 : IPlayerKeyMap
{
    public int Left => Key.A;
    public int Right => Key.D;
    public int Down => Key.S;
    public int Attack => Key.F;
    public int Swap => Key.S;
}