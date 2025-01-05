namespace GXPEngine.animation;

public struct AnimationSpriteInfo
{
    public readonly string Path;
    public readonly int Cols;
    public readonly int Rows;
    public readonly int Frames;

    public AnimationSpriteInfo(string path, int cols, int rows, int frames = -1)
    {
        Path = path;
        Cols = cols;
        Rows = rows;
        Frames = frames;
    }
}

public static class AnimationSpriteInfoExtensions
{
    public static AnimationSprite ToAnimationSprite(this AnimationSpriteInfo animationSpriteInfo,
        bool addCollider)
    {
        return new AnimationSprite(animationSpriteInfo.Path, animationSpriteInfo.Cols, animationSpriteInfo.Rows,
            animationSpriteInfo.Frames, addCollider: addCollider);
    }
}