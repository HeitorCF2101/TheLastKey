using Godot;
using System;

public partial class DetectionBox : Area2D{

    private void OnBodyEntered(Node2D body){
        GD.Print(body.Name);
    }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
        BodyEntered += OnBodyEntered;
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

    }
}
