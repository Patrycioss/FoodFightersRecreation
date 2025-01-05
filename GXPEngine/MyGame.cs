using GXPEngine.player;

namespace GXPEngine;

public sealed class MyGame : Game
{
    private Player _player;

    public MyGame() : base(1360, 760, false)
    {
        _player = new Player(PlayerKeyMap.Player1Preset(), new PastaMan());
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