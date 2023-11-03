using Godot;
using System;

public partial class Floor : Node3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		PackedScene floor1 = ResourceLoader.Load<PackedScene>("res://Building/Floor/floor_tile_1.tscn");
        PackedScene floor2 = ResourceLoader.Load<PackedScene>("res://Building/Floor/floor_tile_2.tscn");

        PackedScene wall1 = ResourceLoader.Load<PackedScene>("res://Building/Wall/Wall_01.tscn");
        PackedScene wall2 = ResourceLoader.Load<PackedScene>("res://Building/Wall/wall_02.tscn");

        //Godot.Node3D node;
        Node3D node;
        node = (Node3D) floor1.Instantiate();
        node.Position = new Vector3(0, 0, 0);
        this.AddChild(node);

        node = (Node3D)floor2.Instantiate();
        node.Position = new Vector3(1, 0, 0);
        this.AddChild(node);

        node = (Node3D)floor2.Instantiate();
        node.Position = new Vector3(0, 0, 1);
        this.AddChild(node);

        node = (Node3D)floor1.Instantiate();
        node.Position = new Vector3(1, 0, 1);
        this.AddChild(node);

        node = (Node3D)wall1.Instantiate();
        node.Position = new Vector3(0, 0, -0.5f);
        this.AddChild(node);
        //PackedScene wall2 = ResourceLoader.Load<PackedScene>("res://Building/Wall/wall_02.tscn");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
