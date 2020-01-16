using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	private Rigidbody2D rb2d;
	private Vector2 vel;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		Invoke("GoBall", 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GoBall() {
		float rand =  Random.Range(0, 2);
		if (rand < 1) {
			rb2d.AddForce(new Vector2(200, -200));
		} else {
			rb2d.AddForce(new Vector2(-200, 150));
		}
	}

	void ResetBall(){
    	rb2d.velocity = Vector2.zero;
    	transform.position = Vector2.zero;
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.collider.CompareTag("Player")){
			Vector2 vel;
			vel.x = rb2d.velocity.x;
			vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
			rb2d.velocity = vel;
		}
	}

	void RestartGame() {
		ResetBall ();
		Invoke ("GoBall", 1);
	}
}
