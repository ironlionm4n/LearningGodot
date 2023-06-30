using Godot;

namespace LearningGodot.Scripts;

public partial class Player : Node2D
{
    [Export] private int _speed = 200;
    [Export] private bool _isDead = false;
    
    private RigidBody2D _playerRigidbody;

    public override void _Ready()
    {
        base._Ready();
        _playerRigidbody = GetNode<RigidBody2D>("RigidBody2D"); // provide path to the RigidBody2D node if it's not a direct child
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        var direction = Vector2.Zero;

        if (Input.IsActionPressed("ui_up"))
            direction.Y -= 1;
        if (Input.IsActionPressed("ui_down"))
            direction.Y += 1;
        if (Input.IsActionPressed("ui_left"))
            direction.X -= 1;
        if (Input.IsActionPressed("ui_right"))
            direction.X += 1;

        direction = direction.Normalized();

        // Apply the velocity to the rigidbody
        _playerRigidbody.LinearVelocity = direction * _speed;
    }

}