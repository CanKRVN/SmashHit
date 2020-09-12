using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraCharacter : MonoBehaviour
{
    public float spawnHelper = 4.5f;
    public GameObject ball;
    public float ballForce;
    public float camSpeed;

    private Camera _cam;

    public static float ballCount = 15;
    public Text BallCountText;
    public Text GameOverText;

    void Start()
    {
        _cam = GetComponent<Camera>();

    }

    private void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1 * camSpeed);

        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && ballCount > 0)
        {
            GameObject ballRigid;
            ballRigid = Instantiate(ball, transform.position, transform.rotation) as GameObject;
            ballCount--;
            Vector3 targetLoc = ray.direction;
            ballRigid.GetComponent<Rigidbody>().AddForce(targetLoc * ballForce);
        }

        BallCountText.text = " " + ballCount;

        if (ballCount == 0)
        {
            GameOverText.gameObject.SetActive(true);
            camSpeed = 0;
            
        }

       // Debug.Log(Time.time);
    }
}
