using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    WindowManager _windowManager;

	private void Awake()
	{
        _windowManager = FindObjectOfType<WindowManager>();
	}


	public GameObject WindowNote;

    public Selectible selected_obj;

    MoneySystem youMoney;

    
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OpenWindowNote();
        }*/

        if (EventSystem.current.IsPointerOverGameObject())
            return;

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
        _windowManager.OpenWindow(WindowNote);
    }
}
