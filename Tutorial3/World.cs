using Godot;
using System;

public class World : Node2D
{
    PackedScene packedScene;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        packedScene = (PackedScene)GD.Load("res://Sprite.tscn");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }

    public override void _UnhandledInput(InputEvent @event){
        if (@event is InputEventMouseButton mouseEvent){
            // create instance of Sprite scene
            Sprite sprite = (Sprite)packedScene.Instance();
            sprite.Position = mouseEvent.Position;
            this.AddChild(sprite);
        }
    }
}
