using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace UnityCommunity.UnitySingleton.Samples
{

    public class SceneTest : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(SceneGameManager.Instance.GetPlayerName());
        }
    }

}