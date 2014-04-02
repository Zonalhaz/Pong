﻿using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public Camera mainCam;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform Player1;
	public Transform Player2;

	// Use this for initialization
	IEnumerator Start () 
	{
		//Move walls to the correct location
		topWall.size= new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

		bottomWall.size= new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

		leftWall.size= new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
		leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.2f, 0f);

		rightWall.size= new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
		rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.2f, 0f);

		Player1.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(100, 0f, 0f)).x,0f);
		Player2.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 100, 0f, 0f)).x, 0f);

		yield return new WaitForSeconds(2);
		audio.Play();
	}

}
