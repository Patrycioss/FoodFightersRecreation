﻿using System.Collections.Generic;
using System.Diagnostics;

namespace GXPEngine.animation;

public class AnimatedModel : GameObject
{
    private readonly AnimationSprite _animationSprite;
    private readonly Dictionary<string, Animation> _animations;

    public AnimatedModel(AnimationSpriteInfo animationSpriteInfo, bool addCollider = false) : base(addCollider)
    {
        _animations = new Dictionary<string, Animation>();
        _animationSprite = animationSpriteInfo.ToAnimationSprite(addCollider);
        AddChild(_animationSprite);
    }
    
    public void AddAnimation(string key, Animation animation)
    {
        if (!_animations.TryAdd(key, animation))
        {
            Debug.Fail($"Animation with {key} has already been added");
        };
    }

    public void StartAnimation(string key)
    {
        if (_animations.TryGetValue(key, out Animation animation))
        {
            _animationSprite.SetCycle(
                animation.StartFrame,
                animation.FrameCount,
                animation.AnimationDelay,
                true
            );
        }
        else Debug.Fail($"Animation with key: {key} does not exist!");
    }

    private void Update()
    {
        _animationSprite.Animate(Time.deltaTime);
    }
}