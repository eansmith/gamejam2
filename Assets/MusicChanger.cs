using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    
    AudioSource audio ;
    [SerializeField] AudioClip[] music;
    bool factory = true;
    bool ending = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(factory){
            audio.clip = music[0]; //factory music is first in list
            audio.Play();
        }
        if(ending){
            audio.clip = music[1]; // ending is second in list
            audio.Play();
        }
    }
}
