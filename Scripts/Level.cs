using Godot;
using System;

namespace LearningGodot.Scripts;

public partial class Level : Node2D
{
    private void OnArea2DBodyExited(Node2D body)
    {
        var sceneTree = GetTree();
        if (body.GetType() == typeof(Player))
            sceneTree.ReloadCurrentScene();
    }
}