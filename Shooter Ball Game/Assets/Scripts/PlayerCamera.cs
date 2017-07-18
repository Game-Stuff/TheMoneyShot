using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    // pub decs
    public GameObject player;

    // priv decs
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position + player.transform.position;
    }

    // Update is called once per frame, after all other calculations. 
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
