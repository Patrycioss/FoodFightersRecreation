namespace GXPEngine;

public struct AnimationSettings
{
    public string Path;
    public int Cols;
    public int Rows;
    public int Frames;

    public AnimationSettings(string path, int cols, int rows, int frames = -1)
    {
        Path = path;
        Cols = cols;
        Rows = rows;
        Frames = frames;
    }
}

public static class AnimationSettingsExtensions
{
    public static AnimationSprite ToAnimationSprite(this AnimationSettings animationSettings,
        bool addCollider)
    {
        return new AnimationSprite(animationSettings.Path, animationSettings.Cols, animationSettings.Rows,
            animationSettings.Frames, addCollider: addCollider);
    }
}