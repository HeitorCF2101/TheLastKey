using Godot;
using System;

public partial class Enemy : CharacterBody2D {

    [Export]
    public int Speed { get; set; } = 350;

    [Export]
    public int Damage { get; set;} = 1;

    public override void _PhysicsProcess(double delta) {

    }

}
