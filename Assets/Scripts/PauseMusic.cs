using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMusic : MonoBehaviour
{
    public AudioSource MusicPlayer;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            MusicPlayer.Pause();
        }
        else
        {
            Debug.Log("Not a player!");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            MusicPlayer.Play();
        }
        else
        {
            Debug.Log("Not a player!");
        }
    }
}
