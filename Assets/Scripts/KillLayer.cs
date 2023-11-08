using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class KillLayer : MonoBehaviour
{
    public AudioSource KillSound;
    public int sceneBuildIndex;
    public int clipLength;
    public Animator crossFade;

    void Start()
    {
        sceneBuildIndex = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(PlayKillSound());
        }
        else
        {
            Debug.Log("Not a player");
        }
    }
    private IEnumerator PlayKillSound()
    {
        crossFade.SetBool("Start", true);
        KillSound.Play();
        yield return new WaitForSeconds(clipLength);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
