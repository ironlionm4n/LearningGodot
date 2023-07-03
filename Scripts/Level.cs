using Godot;
using System;

namespace LearningGodot.Scripts;

	public partial class Level : Node2D
	{

		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
		
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)
		{
		}

		private void OnArea2DBodyExited(Node2D body)
		{
			var sceneTree = GetTree();
			if(body.GetType() == typeof(Player))
				sceneTree.ReloadCurrentScene();
		}
	}
