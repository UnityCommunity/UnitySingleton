using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityCommunity.UnitySingleton.Samples
{

    public class SceneGameManager : MonoSingleton<SceneGameManager>
    {

        [SerializeField]
        protected string m_PlayerName = "NoSLoofah";

        public string GetPlayerName()
        {
            return m_PlayerName;
        }

    }

}