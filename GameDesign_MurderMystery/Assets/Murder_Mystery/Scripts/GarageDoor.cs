using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioclip;

    private void OnTriggerEnter(Collider other) {
        //if(other.keys == true) {
        //    open door
        //}
        audioSource.PlayOneShot(audioclip);
    }
}
