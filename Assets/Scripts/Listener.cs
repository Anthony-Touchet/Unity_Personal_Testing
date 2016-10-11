using UnityEngine;
using System.Collections.Generic;

public class Listener : MonoBehaviour {

    bool hearingNoise;
    List<AudioSource> audioSources;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    List<AudioSource> FindSounds()
    {
        List<AudioSource> audio = new  List<AudioSource>();
        foreach (AudioSource a in FindObjectsOfType<AudioSource>())
        {
            if (a.isPlaying)
            {
                if((transform.position - a.transform.position).sqrMagnitude <= a.maxDistance)
                audio.Add(a);
            }
                
        }

        return audio;
    }
}
