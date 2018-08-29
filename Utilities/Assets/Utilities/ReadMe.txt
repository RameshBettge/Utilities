All Utility-Scripts are in the namespace Utilities.

Overview:

- Enumerations:
	Axis {x, y, z}

- Extensions: 
	Vector3:
		Vector3 = Vector3.Planer(Axis ignoredAxis) 
		Vector2 = Vector3.ToVector2(Axis ignoredAxis)
	Transform:
		SetAxisPosition(Axis axis, float value) -> mutates the transforms position (on one axis only).

- Classes:
	abstract: Singleton<T> 
		  	Inhering class needs to follow this syntax: 
			public class NewSingleton : Singleton<NewSingleton>