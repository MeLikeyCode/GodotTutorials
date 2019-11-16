using Godot;
using System;

public class GDGuy : Sprite
{

    [Signal]
    public delegate void Moved(float newx, float newy);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Timer timer = this.GetNode<Timer>("Clock");
        timer.WaitTime = 1;
        timer.Connect("timeout",this,"on_timeout");
        timer.Start();

        this.Connect("Moved",this,"on_moved");
    }

    void on_timeout(){
        float randX = (float)GD.RandRange(0,500);
        float randY = (float)GD.RandRange(0,500);
        this.Position = new Vector2(randX,randY);

        this.EmitSignal("Moved",randX,randY);
    }

    void on_moved(float newx, float newy){
        GD.Print("we moved!");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
    }
}
