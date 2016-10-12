using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Listener : MonoBehaviour {

    List<AudioSource> audioSources;


	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	    audioSources = FindSounds();

	}

    List<AudioSource> FindSounds()
    {
        List<AudioSource> audio = new  List<AudioSource>();
        foreach (AudioSource a in FindObjectsOfType<AudioSource>())
        {
            if (a.isPlaying)
            {
                if((transform.position - a.transform.position).magnitude <= a.maxDistance * )
                    audio.Add(a);
            }   
        }

        return audio;
    }

    void SampleAudio()
    {
        if(audioSources.Count > 0)
        {
            float[] samples;
            samples = new float[44100];
            audioSources[0].clip.GetData(samples, 0);
        }
    }
}
