using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigger : MonoBehaviour {

    public Transform balcony;
    public GameObject balconyLight;
    public GameObject window;

    private void OnTriggerStay(Collider other) {
        var character = other.gameObject.GetComponent<Character>();
        if(character != null) {
            if(character.PlayerHasFoundKnife() && character.PlayerHasSeen1stCutscene()) {
                var cc = character.GetComponent<CharacterController>();
                character.SetUIText("Press Spacebar to crank open the Window");
                if(Input.GetKeyDown(KeyCode.Space)) {
                    cc.enabled = false;
                    other.transform.position = balcony.position;
                    cc.enabled = true;
                    balconyLight.gameObject.SetActive(false);
                    character.SetUIText("");
                    Destroy(window);
                }

            }
        }
    }
}
