namespace GXPEngine.animation;

public struct Animation
{
    public readonly int StartFrame;
    public readonly int FrameCount;
    public readonly byte AnimationDelay;

    public Animation(int startFrame, int frameCount, byte animationDelay = 255)
    {
        StartFrame = startFrame;
        FrameCount = frameCount;
        AnimationDelay = animationDelay;
    }
}