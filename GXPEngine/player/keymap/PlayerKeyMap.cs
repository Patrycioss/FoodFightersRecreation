namespace GXPEngine.player;

public class PlayerKeyMap
{
    public int Left;
    public int Right;
    public int Down;
    public int Attack;
    public int Swap;

    public static PlayerKeyMap Player1Preset()
    {
        return new PlayerKeyMap
        {
            Left = Key.A,
            Right = Key.D,
            Down = Key.S,
            Attack = Key.F,
            Swap = Key.G,
        };
    }
}