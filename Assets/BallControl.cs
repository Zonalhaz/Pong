using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () 
	{
		yield return new WaitForSeconds(2);
		GoBall();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D thisCollision) 
	{
		if(thisCollision.collider.tag == "Player")
		{
			float velY = rigidbody2D.velocity.y;
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,(velY/2 + thisCollision.collider.rigidbody2D.velocity.y/3));

		}
	}

	IEnumerator ResetBall ()
	{
		rigidbody2D.velocity = new Vector2(0,0);
		transform.position = new Vector3(0,0,0);
		yield return new WaitForSeconds(0.5f);
		GoBall();
	}

	void GoBall ()
	{
		float randomNumber = Random.Range(0,2);
		if(randomNumber <= 0.5)
		{
			rigidbody2D.AddForce(new Vector2(Random.Range(80,130),Random.Range(-10,10)));
		}
		else
		{
			rigidbody2D.AddForce(new Vector2(Random.Range(-130,-80),Random.Range(-10,10)));
		}
	}
}
