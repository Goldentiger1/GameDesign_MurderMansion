using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Knife : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {

    }
    private void OnTriggerStay(Collider other) {
        var character = other.gameObject.GetComponent<Character>();
        if(character != null) {

            character.SetUIText("Press Spacebar to pick up the Knife.");

        }
        if(Input.GetKeyDown(KeyCode.Space)) {
            character.PlayerFoundKnife();
            Destroy(gameObject);
            character.SetUIText("");
        }
    }
}
