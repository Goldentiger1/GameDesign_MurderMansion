using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutters : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        var character = other.gameObject.GetComponent<Character>();

        if(character != null) {

            character.SetUIText("Press Spacebar to pick up cutters.");
            if(Input.GetKeyDown(KeyCode.Space)) {
                character.PlayerFoundCutters();
                Destroy(gameObject);
                character.SetUIText("");
            }
        }
    }
}
