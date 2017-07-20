using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin_sound : MonoBehaviour {
	private AudioSource audioSource;
	public AudioClip sound;

	void Start() {
		audioSource        = gameObject.GetComponent<AudioSource>();
		audioSource.loop    = false;    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision collider){
		if (collider.gameObject.tag == "Ball") {
			audioSource.PlayOneShot (sound);
		}
	}
}
