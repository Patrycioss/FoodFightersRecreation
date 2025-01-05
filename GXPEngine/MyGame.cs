using System.Numerics;
using GXPEngine.player;

namespace GXPEngine;

public class MyGame : Game
{
    private Player _player;
    
    public MyGame() : base(1360, 760, false)
    {
        _player = new Player(new PlayerKeyMap1(), new PastaMan());
        AddChild(_player);
    }

    void Update()
    {
    }

    static void Main()
    {
        new MyGame().Start();
    }
}