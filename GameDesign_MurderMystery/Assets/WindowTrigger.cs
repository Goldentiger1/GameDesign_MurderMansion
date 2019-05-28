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
                character.SetUIText("Press u to use knife to open window");
                if(Input.GetKeyDown(KeyCode.U)) {
                    cc.enabled = false;
                    other.transform.position = balcony.position;
                    cc.enabled = true;
                    balconyLight.gameObject.SetActive(false);
                    Destroy(window);
                }

            }
        }
    }
}
