using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private AudioSource Music;

    void Start()
    {
        Music = this.GetComponent<AudioSource>();
    }


    void Update()
    {
        Music.Play();
    }
}
