using System;

namespace GXPEngine.player;

public class Character
{
    public readonly Sprite Hitbox;
    public readonly AnimationSprite Model;

    protected Character(string hitboxPath, AnimationSettings animationSettings)
    {
        Hitbox = new Sprite(hitboxPath)
        {
            visible = false,
        };
        Model = animationSettings.ToAnimationSprite(false);
        Model.SetCycle(0, 25, 40);
    }

    public void Link(GameObject parent)
    {
        Hitbox.SetPosition(parent.GetPosition());
        parent.AddChild(Hitbox);
        
        Model.SetPosition(parent.GetPosition());
        parent.AddChild(Model);
    }
}