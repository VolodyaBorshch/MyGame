using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Camera mainCamera;

    // [SerializeField] private LayerMask moveMask;
    /*[SerializeField] private Interaction focus;
    [SerializeField] private GameObject swordObj;
    [SerializeField] private GameObject shieldObj;
    [SerializeField] private int moneyCount;
*/
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
           // Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);
            /*if(interactable != null)
            {
                if(interactable != this && interactable != previusInteraction)
                {
                    print("onMoveEnter");
                    previusInteraction = interactable;
                }
                
            }
            else if(previusInteraction != null)
            {
                print("onHoverExit");
                previusInteraction = null;
            }*/
        }
       
        /* if (Input.GetMouseButtonDown(0))
         {
             Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             if(Physics.Raycast(ray, out hit, 100,moveMask))
             {

             }
         }*/
    }
}
