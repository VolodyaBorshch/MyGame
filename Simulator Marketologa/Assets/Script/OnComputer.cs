using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OnComputer : MonoBehaviour
{
    

    public bool ComputerOn;
    public GameObject WindowNote;

    public GameObject clouseButt;
    void Start()
    {
        //canvas = GetComponent<Canvas>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
                OpenWindowNote();

           
            
        }

    }

    public void OpenWindowNote()
    {
        WindowNote.SetActive(true) ;
        print("Active");

    }

    public void onCLick()
    {

    }
    
}
