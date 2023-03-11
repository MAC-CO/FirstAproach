using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamara : MonoBehaviour
{
    public GameObject Camera1, Camera2, Camera3, Camera4, Camera5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TurnOffC();
    }

    void TurnOffC()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            //Camera2.SetActive();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(true);
            Camera5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(true);
        }
    }
}