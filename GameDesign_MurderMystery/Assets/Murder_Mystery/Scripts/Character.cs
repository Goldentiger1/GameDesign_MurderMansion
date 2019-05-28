using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour {

    public TextMeshProUGUI UIText;

    public bool knifeFound;
    public bool hasSeen1stCutscene;
    public bool keysFound;
    public bool beenToKitchen;
    public bool hasCutters;

    float textTimer;
    float textTime = 3;

    private void Update() {
        textTimer -= Time.deltaTime;
        if(textTimer < 0)
            SetUIText("");
    }

    public void PlayerSees1stCutscene() {
        hasSeen1stCutscene = true;
    }

    public bool PlayerHasSeen1stCutscene() {
        return hasSeen1stCutscene;
    }

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

    public void PlayerFoundKnife() {
        knifeFound = true;
    }

    public bool PlayerHasFoundKnife() {
        return knifeFound;
    }

    public void SetUIText(string text) {
        UIText.text = text;
        textTimer = textTime;
    }
}
