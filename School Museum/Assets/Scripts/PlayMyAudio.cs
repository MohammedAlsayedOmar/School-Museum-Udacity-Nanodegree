using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GvrAudioSource))]
public class PlayMyAudio : MonoBehaviour {

    GvrAudioSource src;
    	
	void Start () {
        src = GetComponent<GvrAudioSource>();
	}

    public void OnClickTheButton()
    {
        src.Play();
    }

    public void OnClickTheButton(AudioClip clip)
    {
        src.Stop();
        src.PlayOneShot(clip);
    }
}
