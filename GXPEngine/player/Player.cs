using System;
using System.Numerics;

namespace GXPEngine.player;

public sealed class Player : GameObject
{
    private PlayerKeyMap _playerKeyMap;
    private Character _character;

    private bool _moving = false;

    public Player(PlayerKeyMap playerKeyMap, Character startCharacter)
    {
        _playerKeyMap = playerKeyMap;
        _character = startCharacter;

        _character.Link(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(Key.R))
        {
            _character.Model.StartAnimation("Idle");
        }

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
            if (!_moving)
            {
                _character.Model.StartAnimation("Walking");
            }

            _moving = true;
            this.SetPosition(this.GetPosition() + direction);
            Console.WriteLine("yep " + this.GetPosition());
        }
        else if (_moving)
        {
            _moving = false;
            _character.Model.StartAnimation("Idle");
        }
    }
}