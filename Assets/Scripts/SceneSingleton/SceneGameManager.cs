using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGameManager : SceneSingleton<SceneGameManager>
{
	[SerializeField]
	protected string m_PlayerName = "NoSLoofah";	

	public string GetPlayerName()
	{
		return m_PlayerName;
	}
}
