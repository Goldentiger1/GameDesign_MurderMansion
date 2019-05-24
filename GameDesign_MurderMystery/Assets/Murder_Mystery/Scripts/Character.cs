using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    bool keysFound;
    bool beenToKitchen;
    bool hasCutters;

    public void PlayerFoundKeys() {
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

    public void PlayerFoundCutters() {
        hasCutters = true;
    }

    public bool PlayerHasFoundCutters() {
        return hasCutters;
    }
}
