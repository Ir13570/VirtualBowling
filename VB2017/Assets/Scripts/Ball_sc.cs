using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_sc : MonoBehaviour {

	private GameObject ball, light, maincamera;
	private Vector3 ball_v, ball_p;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindGameObjectWithTag ("Ball");
		light = GameObject.Find ("/Ball_light") as GameObject;
		maincamera = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		ball_v = ball.gameObject.GetComponent<Rigidbody> ().velocity;
		ball_p = ball.transform.position;
		light.transform.position = new Vector3(ball_p.x, 2.5f, ball_p.z);
		if (ball_p.z >= -10 && ball_p.z <= 13) {
			maincamera.transform.position = new Vector3 (ball_p.x, 2.5f, ball_p.z - 3f);	
		}
	}

	void OnCollisionEnter(Collision collider){
		if (collider.gameObject.transform.tag == "Garter" || collider.gameObject.transform.tag == "Stage") {
			Vector3 force = new Vector3 (ball_v.x, ball_v.y, 10f);
			ball.GetComponent<Rigidbody> ().velocity = force;
	
		}
	}
}
