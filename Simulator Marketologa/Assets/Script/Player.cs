using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Camera mainCamera;


    //[SerializeField] private int moneyCount;

    //private Interaction previusInteraction;
    public Selectible selected_obj;   
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            var selectible = hit.collider.GetComponent<Selectible>();
            if(selectible != null)
            {
                if(selected_obj != null)
                {
                    selected_obj.UnSelect();
                }
                selectible.Select();
                selected_obj = selectible;
            }
            else
            {
                if (selected_obj != null)
                {
                    selected_obj.UnSelect();
                }
                selected_obj = null;
            }


        }


    }
}
