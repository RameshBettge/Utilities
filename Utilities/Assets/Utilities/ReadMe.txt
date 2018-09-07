All Utility-Scripts are in the namespace Utilities.

All functions and its parameters are explained in thir summarys as well.

Overview:

- Enumerations:
	Axis {x, y, z}

- Extensions: 

	Vector3:
		Vector3 = Vector3.SetMagnitude(float newMagnitude)
		Vector3 = Vector3.Planer(Axis ignoredAxis) 
		Vector3 = Vector2.SetMagnitude(float newMagnitude)
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

	Tools (helper class):
		Map(float value, float oldMin, float oldMax, float newMin, float newMax)
			-> Maps a value to an new Range
		Map01(float value, float oldMin, float oldMax)
			-> Maps a value between 0 and 1

        public static IEnumerator LerpRoutine(LPDelegate del, float lerpTime, WaitForEndOfFrame wait, float startPercentage = 0f)
			-> Executes a delegate once per frame until a timer reaches lerpTime.
        public delegate void LPDelegate(float percentage);
			-> Used in the LerpRoutine.