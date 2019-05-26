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
       // player = 
        //anim = 
    }

    void onTriggerEnter(Collider csTriggers)
    {
        if(csTriggers.gameObject.tag == "Balcony")
        {
            hasBalcony = true;
        } else if (csTriggers.gameObject.tag == "Mirror" && hasBalcony == false && hasMirror == false && hasKnife == true)
        {
            hasMirror = true;
        }else if(csTriggers.gameObject.tag == "Knife" && hasBalcony == false && hasMirror == false && hasKnife == false)
        {
            print("inside collider");
            hasKnife = true;
        }
    }
}