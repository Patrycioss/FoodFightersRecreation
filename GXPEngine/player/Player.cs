using System;
using System.Numerics;

namespace GXPEngine.player;

public sealed class Player : GameObject
{
    private PlayerKeyMap _playerKeyMap;
    private Character _character;

    public Player(PlayerKeyMap playerKeyMap, Character startCharacter)
    {
        _playerKeyMap = playerKeyMap;
        _character = startCharacter;

        _character.Link(this);
    }

    private void Update()
    {
        _character.Model.Animate(Time.deltaTime);
        
        Vector2 direction = Vector2.Zero;

        if (Input.GetKey(_playerKeyMap.Right))
        {
           direction.X += 1;
        }

        if (Input.GetKey(_playerKeyMap.Left))
        {
            direction.X -= 1;
        }

        if (Input.GetKey(_playerKeyMap.Down))
        {
            direction.Y += 1;
        }

        if (direction.X < 0 || direction.X > 0 || direction.Y < 0 || direction.Y > 0)
        {
            this.SetPosition(this.GetPosition() + direction);
            Console.WriteLine("yep " + this.GetPosition());
        }
    }
}