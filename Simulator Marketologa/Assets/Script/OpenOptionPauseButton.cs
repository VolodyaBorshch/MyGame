using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptionPauseButton : MonoBehaviour
{
    public GameObject OpenOption;
    public GameObject CloseOption;

	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenWindowNote();
    }

    public void OpenWindowNote()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OpenOption.SetActive(true);
            print("Active");
        }
        else
        {
            CloseWindowNote();
        }
    }

    public void CloseWindowNote()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CloseOption.SetActive(false);
            print("NonActive");
        }
    }
}
