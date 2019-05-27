using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTrigger : MonoBehaviour {

    public GameObject image;

    private void OnTriggerEnter(Collider other) {
        image.gameObject.SetActive(true);
    }
}
