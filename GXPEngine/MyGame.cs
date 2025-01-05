using GXPEngine.player;

namespace GXPEngine;

public sealed class MyGame : Game
{
    private readonly Player _player;

    public MyGame() : base(1360, 760, false)
    {
        _player = new Player(PlayerKeyMap.Player1Preset());
        AddChild(_player);
    }

    private void Update()
    {
       
    }

    private static void Main()
    {
        new MyGame().Start();
    }
}