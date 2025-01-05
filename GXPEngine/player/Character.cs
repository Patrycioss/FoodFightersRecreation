using GXPEngine.animation;

namespace GXPEngine.player;

public abstract class Character
{
    public readonly Sprite Hitbox;
    public readonly AnimatedModel Model;

    protected Character(string hitboxPath, AnimationSpriteInfo animationSpriteInfo)
    {
        Hitbox = new Sprite(hitboxPath)
        {
            visible = false,
        };

        Model = new AnimatedModel(animationSpriteInfo);
    }

    public void Link(GameObject parent)
    {
        Hitbox.SetPosition(parent.GetPosition());
        parent.AddChild(Hitbox);

        Model.SetPosition(parent.GetPosition());
        parent.AddChild(Model);
    }
}