using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 6.5f, -12.5f);
    private Vector3 hoodCam = new Vector3(0, 3.4f, 0);
    bool camOnHood = false;

    //Set default position when starting game
    private void Start()
    {
        transform.position = player.transform.position + offset;
    }

    //Change cam position according to bool which depends on 'V' key press
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.V)) 
        {
           camOnHood = !camOnHood;
        }
        if(camOnHood)
        {
            transform.position = player.transform.position + hoodCam;
            transform.rotation = player.transform.rotation;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
