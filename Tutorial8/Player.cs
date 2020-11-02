using Godot;
using System;

public class Player : Node2D
{
	public override void _Ready()
	{
		var streamPlayer = GetNode<AudioStreamPlayer2D>("AudioStreamPlayer2D");
		streamPlayer.Stream = GD.Load<AudioStream>("res://short_sound.wav");
		streamPlayer.Attenuation = 10;
		streamPlayer.Play();
	}

	public override void _Process(float delta)
	{
		float speed = 300;
		float moveAmount = speed * delta;
		Vector2 moveVector = new Vector2(0, 0);
		if (Input.IsKeyPressed((int)KeyList.W))
		{
			moveVector.y -= moveAmount;
		}
		if (Input.IsKeyPressed((int)KeyList.S))
		{
			moveVector.y += moveAmount;
		}
		if (Input.IsKeyPressed((int)KeyList.A))
		{
			moveVector.x -= moveAmount;
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			moveVector.x += moveAmount;
		}
		Position += moveVector;

	}
}
