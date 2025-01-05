using GXPEngine.animation;

namespace GXPEngine.player;

public abstract class Character : GameObject
{
    public readonly Sprite Hitbox;
    public readonly AnimatedModel Model;

    protected Character(string hitboxPath, AnimationSpriteInfo animationSpriteInfo)
    {
        Hitbox = new Sprite(hitboxPath)
        {
            visible = false,
        };
        AddChild(Hitbox);

        Model = new AnimatedModel(animationSpriteInfo);
        AddChild(Model);
    }


    protected override void OnMirror(bool mirror, int offset)
    {
        Model.Mirror(mirror, offset);
    }
}