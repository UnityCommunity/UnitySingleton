using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace UnityCommunity.UnitySingleton.Samples
{

    public class Test : MonoBehaviour
    {

        void Start()
        {
            Debug.Log(GameManager.Instance.GetPlayerName());
        }

    }

}