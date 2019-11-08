using Godot;
using System;

public class Sprite : Godot.Sprite
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        uint randomNumber = GD.Randi() % 4; // 0 - 3
        float AMOUNT = 5;
        if (randomNumber == 0){
            this.Position += new Vector2(0,-AMOUNT);
        }
        if (randomNumber == 1){
            this.Position += new Vector2(0,AMOUNT);
        }
        if (randomNumber == 2){
            this.Position += new Vector2(-AMOUNT,0);
        }
        if (randomNumber == 3){
            this.Position += new Vector2(AMOUNT,0);
        }
    }

}
