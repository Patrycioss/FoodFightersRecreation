using System.Numerics;

namespace GXPEngine;

public static class GameObjectExtensions
{
    public static Vector2 GetPosition(this GameObject gameObject)
    {
        return new Vector2(gameObject.x, gameObject.y);
    }

    public static void SetPosition(this GameObject gameObject, Vector2 position)
    {
        gameObject.SetXY(position.X,position.Y);
    }
}