using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioClip;
    bool soundPlayed;
    bool doorOpened;

    private void OnTriggerStay(Collider other) {
        if(!doorOpened) {
            var character = other.gameObject.GetComponent<Character>();
            if(character != null) {
                if(character.PlayerHasFoundKeys()) {
                    character.SetUIText("Press Spacebar to open");
                    if(Input.GetKeyDown(KeyCode.Space)) {
                        doorOpened = true;
                        transform.LookAt(Vector3.right, Vector3.up);
                        character.SetUIText("");
                    }
                } else {
                    if(!soundPlayed) {
                        soundPlayed = true;
                        audioSource.PlayOneShot(audioClip);
                    }

                }
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        soundPlayed = false;
    }
}
