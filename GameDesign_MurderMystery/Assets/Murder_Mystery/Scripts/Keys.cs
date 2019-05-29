using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour {

    private void OnTriggerStay(Collider other) {
        var character = other.gameObject.GetComponent<Character>();

        if(character != null) {

            character.SetUIText("Press Spacebar to pick up the Keys.");
            if(Input.GetKeyDown(KeyCode.Space)) {
                character.PlayerFoundKeys();
                Destroy(gameObject);
                character.SetUIText("");
            }
        }

    }
}
