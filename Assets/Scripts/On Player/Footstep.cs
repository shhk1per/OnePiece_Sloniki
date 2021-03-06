using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    PlayerController playerController;
    AudioSource audio;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerController.movementSpeed > 0.5f && !audio.isPlaying)
        {
            audio.volume = Random.Range(0.3f, 0.5f);
            audio.pitch = Random.Range(0.8f, 1.1f);
            audio.Play();
        }
    }
}
