using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuButton : MonoBehaviour
{
    CameraCharacter cameraCharacter;
    public GameObject panel;

    private void Start()
    {
        cameraCharacter = Camera.main.GetComponent<CameraCharacter>();
    }

    public void MenuPanel()
    {
        panel.SetActive(true);
        cameraCharacter.isGamePause = true;
    }

    public void ResumeButton()
    {
        panel.SetActive(false);
        cameraCharacter.isGamePause = false;
    }
}
