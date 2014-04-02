using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int playerScore1 = 0;
	public static int playerScore2 = 0;

	public GUISkin skin;

	// Update is called once per frame
	public static void Score (string wallName) 
	{
		if(wallName == "rightWall")
		{
			playerScore1++;
		}
		else
		{
			playerScore2++;
		}
		Debug.Log("1: " +playerScore1);
		Debug.Log("2: " +playerScore2);
	}

	void OnGUI ()
	{
		GUI.skin = skin;
		GUI.Label(new Rect(Screen.width/2 - 150-18, 20, 100, 100),"" + playerScore1);
		GUI.Label(new Rect(Screen.width/2 + 150-18, 20, 100, 100),"" + playerScore2);
	}
}
