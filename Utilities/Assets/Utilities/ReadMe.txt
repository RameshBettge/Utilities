All Utility-Scripts are in the namespace Utilities.

Overview:

- Enumerations:
	Axis {x, y, z}

- Extensions: 

	Vector3:
		Vector3 = Vector3.Scale(Vector3 vectorToScaleWith)
		Vector3 = Vector3.Planer(Axis ignoredAxis) 
		Vector2 = Vector3.ToVector2(Axis ignoredAxis)

	Transform:
		SetAxisPos(Axis axis, float value, bool global = true) 
			-> mutates the transforms position (on one axis only).
		SetAxisRot(Axis axis, float value, bool global = true)
			-> Like SetAxisPos but with Rotation.

- Classes:
	abstract: Singleton<T> 
		  	Inhering class needs to follow this syntax: 
			public class NewSingleton : Singleton<NewSingleton>