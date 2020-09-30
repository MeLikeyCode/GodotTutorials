using Godot;
using System;

public class Test : Sprite
{
	public override void _Ready()
	{
		// local to parent
		var result =Transform.Xform(new Vector2(10,10));
		GD.Print("(10,10), local to parent: ",result);

		// parent to local
		var result2 = Transform.Inverse().Xform(result);
		GD.Print($"{result}, parent to local: ",result2);

		var result3 = Transform.XformInv(result);
		GD.Print("parent to local, way 2: ",result3);

		// local to global
		var result4 = GlobalTransform.Xform(new Vector2(10,10));
		GD.Print("(10,10), local to global: ",result4);

		// global to local
		var result5 = GlobalTransform.XformInv(result4);
		GD.Print($"{result4}, global to local");

		// sibling to sibling
		var sibling = GetNode<Godot.Sprite>("../Child2");
		
		var asGlobal = GlobalTransform.Xform(new Vector2(10,10));
		var result6 = sibling.GlobalTransform.XformInv(asGlobal);
		GD.Print("(10,10), local to sibling: ",result6);
	}
}
