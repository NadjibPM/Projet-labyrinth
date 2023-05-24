using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public bool CanOpen = false;

    [SerializeField]
    AudioClip sndOpen, sndDenied;

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    GameObject endPoint;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" && CanOpen)
        {
            myAnimator.enabled = true;
            myAudioSource.PlayOneShot(sndOpen);
            endPoint.SetActive(true);
        }
        else
        {
            myAudioSource.PlayOneShot(sndDenied);
        }
      
    }

    


}
