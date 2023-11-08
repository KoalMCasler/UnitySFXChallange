using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    public AudioSource SFXPlayer;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SFXPlayer.Play();
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
            SFXPlayer.Stop();
        }
        else
        {
            Debug.Log("Not a player!");
        }
    }
}
