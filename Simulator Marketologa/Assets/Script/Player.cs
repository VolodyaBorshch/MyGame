using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Camera mainCamera;


    //[SerializeField] private int moneyCount;

    //private Interaction previusInteraction;

    // Update is called once per frame
   void Update()
    {

        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            var interactable = hit.collider.GetComponent<Outline>();
            interactable.OutlineWidth = 10;


        }


    }
}
