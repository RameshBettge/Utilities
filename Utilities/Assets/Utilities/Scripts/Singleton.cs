using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    static T instance;

    // is set to true as soon as the static Instance is destroyed. Used to avoid 'Some objects were not cleaned up when closing the scene'-bug
    private static bool apllicationIsQuitting = false;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                if (apllicationIsQuitting)
                {
                    Debug.LogWarning("Preventing Instantiation of Singleton '" + typeof(T).ToString() + "', because applicationIsQuitting == true.");
                    return null;
                }

                //If the reference isn't filled, this method will look for the corresponding GameObject in the scene. 
                instance = (T)FindObjectOfType(typeof(T));

                //A new Gameobject will be instantiated if none could be found.
                if (instance == null)
                {
                    GameObject singletonGO = new GameObject();
                    instance = singletonGO.AddComponent<T>();
                    singletonGO.name = typeof(T).ToString() + " (Singleton)";
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        apllicationIsQuitting = true;
    }
}

