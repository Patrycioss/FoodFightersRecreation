using GXPEngine.animation;

namespace GXPEngine.player;

public class BurgerWoman : Character
{
    public BurgerWoman() : base(
        "assets/characters/burger_woman/hitbox.png", new AnimationSpriteInfo(
            "assets/characters/burger_woman/model.png", 9, 6)
    )
    {
        Model.AddAnimation("Walking", new Animation(0, 25, 35));
        Model.AddAnimation("Idle", new Animation(25, 5, 100));
        Model.AddAnimation("Attack", new Animation(30, 11, 60));
        Model.AddAnimation("Special", new Animation(41, 13, 70));
        Model.StartAnimation("Idle");
    }

    protected override void OnMirror(bool mirror, int offset)
    {
        Model.Mirror(mirror, offset + 256);
    }
}