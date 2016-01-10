public static class CoreComponentIds {
    public const int Acceleratable = 0;
    public const int Accelerating = 1;
    public const int Destroy = 2;
    public const int FinishLine = 3;
    public const int Move = 4;
    public const int Position = 5;
    public const int Resource = 6;
    public const int View = 7;

    public const int TotalComponents = 8;

    public static readonly string[] componentNames = {
        "Acceleratable",
        "Accelerating",
        "Destroy",
        "FinishLine",
        "Move",
        "Position",
        "Resource",
        "View"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(AcceleratableComponent),
        typeof(AcceleratingComponent),
        typeof(DestroyComponent),
        typeof(FinishLineComponent),
        typeof(MoveComponent),
        typeof(PositionComponent),
        typeof(ResourceComponent),
        typeof(ViewComponent)
    };
}