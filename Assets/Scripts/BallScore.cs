﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour
{
    CameraCharacter cameraCharacter;



    private void Start()
    {
        cameraCharacter = Camera.main.GetComponent<CameraCharacter>();
        GameObject.Find("doorbutton");

    }

    private void Update()
    {
        if (transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hitobstacle"))
        {
            Destroy(other.gameObject);
            cameraCharacter.ballCount += 3;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("doorbutton"))
        {
            cameraCharacter.DoorAnim();
            Debug.Log("you shot button");
            cameraCharacter.passedDoor++;

        }
    }
}
