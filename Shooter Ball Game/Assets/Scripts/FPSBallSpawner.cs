using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FPSBallSpawner : MonoBehaviour {

    public GameObject parentWeapon;
    public GameObject ballBullet;

    [SerializeField] private Rigidbody ballRigidBody;
    [SerializeField] private bool      m_isShooting;

	// Use this for initialization
	void Start ()
    {
        ballRigidBody = ballBullet.GetComponent<Rigidbody>(); ;
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    void FixedUpdate()
    {
        // is player pressing the Shoot key
        m_isShooting = Input.GetButton("Fire1");

        // if the player has clicked the fire key and the ball is stopped
        if (m_isShooting && ballRigidBody.velocity.magnitude < 0.1f)
        {
            ballRigidBody.velocity.Set(0.0f, 0.0f, 0.0f);  // Might not have to do as it should be stopped already
            ballBullet.transform.position = this.transform.position;
            ballBullet.transform.rotation = parentWeapon.transform.rotation;

            ballRigidBody.AddRelativeForce(0.0f, 800.0f, 0.0f);
        }
    }
}
