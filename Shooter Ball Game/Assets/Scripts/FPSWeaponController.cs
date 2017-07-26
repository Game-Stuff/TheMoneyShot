using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSWeaponController : MonoBehaviour {

    public Camera m_mainCam;
    [SerializeField] private Vector3 weaponMoveVector;
    [SerializeField] private GameObject weapon;

    // Use this for initialization
    void Start ()
    {
        // weaponMoveVector = new Vector3();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame, after calculations
    void FixedUpdate()
    {

    }
}
