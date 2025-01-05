using System;
using System.Numerics;

namespace GXPEngine.player;

public sealed class Player : GameObject
{
    private PlayerKeyMap _playerKeyMap;
    private Character _character;

    private bool _moving = false;
    private bool _mirrored = false;

    public Player(PlayerKeyMap playerKeyMap, Character startCharacter)
    {
        _playerKeyMap = playerKeyMap;
        _character = startCharacter;
        AddChild(_character);
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
            
            Mirror(direction.X < 0);

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

    protected override void OnMirror(bool mirror, int offset)
    {
        _character.Mirror(mirror, offset);
        _mirrored = mirror;    
    }
}