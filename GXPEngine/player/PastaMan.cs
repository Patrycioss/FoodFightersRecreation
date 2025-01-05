using GXPEngine.animation;

namespace GXPEngine.player;

public sealed class PastaMan : Character
{
    public PastaMan() : base(
        "assets/characters/pasta_man/hitbox.png",
        new AnimationSpriteInfo(
            "assets/characters/pasta_man/model.png", 9, 5
        )
    )
    {
        Model.AddAnimation("Walking", new Animation(0, 25, 40));
        Model.AddAnimation("Idle", new Animation(25, 5, 100));
        Model.AddAnimation("Attack", new Animation(31, 11, 100));
        Model.AddAnimation("Special", new Animation(41, 4, 100));
        Model.StartAnimation("Idle");
    }

    protected override void OnMirror(bool mirror, int offset)
    {
        Model.Mirror(mirror, offset + 256);
    }
}