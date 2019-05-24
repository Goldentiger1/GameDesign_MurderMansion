using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public bool keysFound;
    public bool beenToKitchen;

    public void FindKeys() {
        keysFound = true;
    }

    public bool PlayerHasFoundKeys() {
        return keysFound;
    }

    public void PlayerGoesToKitchen() {
        beenToKitchen = true;
    }

    public bool PlayerHasBeenToKitchen() {
        return beenToKitchen;
    }
}
