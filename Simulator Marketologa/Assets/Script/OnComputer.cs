using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OnComputer : MonoBehaviour
{
    

    public bool ComputerOn;
    public GameObject WindowNote;

    public GameObject clouseButt;


	private void OnMouseDown()
	{
        WindowNote.SetActive(true);
        
    }
}
