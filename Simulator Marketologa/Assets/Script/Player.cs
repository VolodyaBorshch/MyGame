using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject WindowNote;

    public Selectible selected_obj;   

    
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OpenWindowNote();
        }*/

        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            var selectible = hit.collider.GetComponent<Selectible>();

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (hit.collider.gameObject.tag == "Chek")
                {
                    OpenWindowNote();
                    
                }
            }
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
    public void OpenWindowNote()
    {

        WindowNote.SetActive(true);
        print("Active");

    }
}
