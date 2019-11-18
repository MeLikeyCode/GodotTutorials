using Godot;
using System;

public class Sprite : Godot.Sprite
{

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _UnhandledInput(InputEvent @event){
        if (@event is InputEventMouseButton buttonEvent){
            if (buttonEvent.Pressed)
                this.Position = buttonEvent.GlobalPosition;
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }
}
