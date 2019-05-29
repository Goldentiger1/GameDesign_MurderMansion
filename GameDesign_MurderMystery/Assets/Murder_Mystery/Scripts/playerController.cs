using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public Animation anim;
    public bool hasKnife = false;
    public bool hasMirror = false;
    public bool hasBalcony = false;
    void Start()
    {
        player = this.gameObject; 
        //anim = 
    }

    void OnTriggerEnter(Collider csTriggers)
    {
        if (csTriggers.gameObject.tag == "Balcony" && hasBalcony == false && hasMirror == true && hasKnife == true)
        {
            print("Leaving Startingroom!");
            hasBalcony = true;
        }else if (csTriggers.gameObject.tag == "Mirror" && hasBalcony == false && hasMirror == false && hasKnife == true)
        {
            print("Looked at self in the mirror!");
            hasMirror = true;
        }else if(csTriggers.gameObject.tag == "Knife" && hasBalcony == false && hasMirror == false && hasKnife == false)
        {
            print("Kicked knife and picked it up!");
            hasKnife = true;
        }
    
    }
}