using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject pivot;
    public GameObject chain;
    bool soundPlayed;
    bool doorOpened;

    private void OnTriggerStay(Collider other) {
        var character = other.gameObject.GetComponent<Character>();
        if(character != null) {
            if(character.PlayerHasFoundCutters()) {
                if(!doorOpened) {
                    character.SetUIText("Press Spacebar to use cutters on chain.");
                    if(Input.GetKeyDown(KeyCode.Space)) {
                        Destroy(chain);
                        doorOpened = true;
                        pivot.transform.LookAt(Vector3.right, Vector3.up);
                        character.SetUIText("");
                    }
                }
            } else {
                if(!soundPlayed) {
                    audioSource.PlayOneShot(audioClip);
                    soundPlayed = true;
                }

            }
        }
    }
    private void OnTriggerExit(Collider other) {
        soundPlayed = false;
    }
}
