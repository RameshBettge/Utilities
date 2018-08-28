using UnityEngine;
using Utilities;

public class Tester : MonoBehaviour
{
    Vector3 myVector = new Vector3(1f, 2f, 3f);


    void Start()
    {
        myVector = myVector.Planar(Axis.x);
        Debug.Log(myVector);

        Debug.Log(myVector.ToVector2(Axis.z));

        transform.SetAxisPos(Axis.y, 8.5f);
    }
}
