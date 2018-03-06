using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backSound : MonoBehaviour {

	/*public AudioClip backsound1;

	AudioSource audioSource;

	void awake(){
		audioSource = GetComponent<AudioSource> ();
	}

	public void klikButton(){
		audioSource.Play ();
	}*/

	AudioSource audiosource;
	public void play()
	{
		audiosource = GetComponent<AudioSource>();
		audiosource.Play();
	}

}
