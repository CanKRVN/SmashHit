using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour
{
    CameraCharacter cameraCharacter;
   
    private void Start()
    {
        cameraCharacter = Camera.main.GetComponent<CameraCharacter>();
        
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
        }
    }
}
