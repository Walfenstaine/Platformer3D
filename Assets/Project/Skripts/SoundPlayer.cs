using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {
    public AudioSource sorse { get; set;}
    public static SoundPlayer regit {get; set;}

	void Awake(){
		sorse = GetComponent<AudioSource> ();
		if (regit == null) {
			regit = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		regit = null;
	}
}