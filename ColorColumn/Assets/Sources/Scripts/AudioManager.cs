using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Clips[] clips;
    public static AudioManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(Clips c in clips)
        {
            c.source = gameObject.AddComponent<AudioSource>();
            c.source.clip = c.clip;
            c.source.volume = c.volume;
            c.source.pitch = c.pitch;
            c.source.loop = c.loop;
        }
    }

    private void Start()
    {
        Play("BGM");
    }

    public void Play(string name)
    {
        Clips c = Array.Find(clips, clip => clip.name == name);
        c.source.Play();
    }
}
