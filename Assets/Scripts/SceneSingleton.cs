using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// "Scene Singleton Pattern" or "Local Singleton Pattern"
// It differs from the traditional "Global singleton pattern", 
// The purpose of "Scene Singleton Pattern" is to ensure that there is only one instance of the class in a given scene, but it does not require that instance to persist across scenes. 
// This pattern is useful when you need to manage certain assets or features in a single scene, but you don't want those assets or features to remain present when the scene is switched.

public abstract class SceneSingleton<T> : MonoBehaviour where T : Component
{

    #region Fields

    /// <summary>
    /// The instance.
    /// </summary>
    private static T instance;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <value>The instance.</value>
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Use this for initialization.
    /// </summary>
    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

}
