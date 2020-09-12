using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour
{
    public float ballCount = CameraCharacter.ballCount;
    public GameObject hitobstacle;
    private void Start()
    {
        
    }
    private float BallCollect(Collider other)
    {
        if (other.gameObject.CompareTag("hitobstacle"))
        {
            Destroy(other.gameObject);
            ballCount ++;
            Debug.Log("+3 ball");
        }
        return ballCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        BallCollect(other);
    }

}
