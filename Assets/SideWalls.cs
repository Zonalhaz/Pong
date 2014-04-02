using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D thisHit) 
	{
		if(thisHit.name == "Ball")
		{
			GameManager.Score(transform.name);
			thisHit.gameObject.SendMessage("ResetBall");
		}
	}
}
