using UnityEngine;
using Utilities;

public class Tester : MonoBehaviour
{
    Vector3 myVector = new Vector3(1f, 2f, 3f);

    void Start()
    {
        //myVector = myVector.Planar(Axis.x);
        //Debug.Log(myVector);

        //Debug.Log(myVector.ToVector2(Axis.z));

        //transform.SetAxisPos(Axis.x, 1.5f, false);
        //transform.SetAxisRot(Axis.y, 90f, false);

        //Debug.Log( Tools.Map(7.5f, 5f, 10f, -10f, 30f));


        Tools.LPDelegate myDelegate = FirstDelegate;
        StartCoroutine(Tools.LerpRoutine(myDelegate, 1f, new WaitForEndOfFrame()));

        myDelegate = SecondDelegate;
        StartCoroutine(Tools.LerpRoutine(myDelegate, 1f, new WaitForEndOfFrame()));
    }

    void FirstDelegate(float percentage)
    {
        print(percentage);
    }

    void SecondDelegate(float p)
    {
        Debug.Log("percentage");
    }
}
