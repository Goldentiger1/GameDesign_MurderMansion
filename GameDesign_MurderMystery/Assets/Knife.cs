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

            character.SetUIText("Press U to pick up knife.");

        }
        if(Input.GetKeyDown(KeyCode.U)) {
            character.PlayerFoundKnife();
            Destroy(gameObject);
        }
    }
}
