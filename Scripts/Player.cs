﻿using Godot;

namespace LearningGodot.Scripts;

public partial class Player : RigidBody2D
{
    [Export] private int _speed = 200;

    private RigidBody2D _playerRigidbody;

    public override void _Ready()
    {
        base._Ready();
        _playerRigidbody = this;
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        var direction = Vector2.Zero;

        if (Input.IsActionPressed("move_up"))
            direction.Y -= 1;
        if (Input.IsActionPressed("move_down"))
            direction.Y += 1;
        if (Input.IsActionPressed("move_left"))
            direction.X -= 1;
        if (Input.IsActionPressed("move_right"))
            direction.X += 1;

        direction = direction.Normalized();

        _playerRigidbody.ApplyForce(direction * _speed);

    }
}