using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTrigger : MonoBehaviour {

    public GameObject image;
    bool hasSeen;

    private void OnTriggerEnter(Collider other) {

        var character = other.gameObject.GetComponent<Character>();
        if(character != null) {
            if(!hasSeen) {
                image.gameObject.SetActive(true);
                hasSeen = true;
                character.PlayerSees1stCutscene();
            }
        }

    }
}
