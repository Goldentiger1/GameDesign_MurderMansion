using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenDoors : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        var character = other.gameObject.GetComponent<Character>();
        if(character != null) {
            if(character.PlayerHasBeenToKitchen()) {
                character.FindKeys();
            }
        }
    }
}
