using System.Numerics;

namespace GXPEngine.player;

public sealed class Player : GameObject
{
    private readonly PlayerKeyMap _playerKeyMap;
    private Character _character;
    private bool _hasActiveCharacter;
    private bool _moving;
    private int _selectedCharacterIndex = -1;

    private readonly Character[] _characters =
    [
        new PastaMan(),
        new BurgerWoman(),
    ];

    public Player(PlayerKeyMap playerKeyMap)
    {
        _playerKeyMap = playerKeyMap;
        NextCharacter();
    }

    protected override void OnMirror(bool mirror, int offset)
    {
        _character.Mirror(mirror, offset);
    }

    private void NextCharacter()
    {
        string activeAnimation = "";
        
        if (_hasActiveCharacter)
        {
            activeAnimation = _character.Model.ActiveAnimation;
            _character.parent = null;
        }
        
        _selectedCharacterIndex++; 
        if (_selectedCharacterIndex >= _characters.Length) _selectedCharacterIndex = 0;

        _character = _characters[_selectedCharacterIndex];
        _character.Mirror(Mirrored);
        _character.Model.StartAnimation(_hasActiveCharacter? activeAnimation : "Idle");
        AddChild(_character);
        _hasActiveCharacter = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_playerKeyMap.Swap))
        {
            NextCharacter();
            return;
        }
        
        Vector2 direction = GetDirection();

        if (direction.X < 0 || direction.X > 0 || direction.Y < 0 || direction.Y > 0)
        {
            if (!_moving)
            {
                _character.Model.StartAnimation("Walking");
            }

            Mirror(direction.X < 0);

            _moving = true;
            SetXY(x + direction.X, y + direction.Y);
        }
        else if (_moving)
        {
            _moving = false;
            _character.Model.StartAnimation("Idle");
        }
    }

    private Vector2 GetDirection()
    {
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

        if (Input.GetKey(_playerKeyMap.Up))
        {
            direction.Y -= 1;
        }

        return direction;
    }
}