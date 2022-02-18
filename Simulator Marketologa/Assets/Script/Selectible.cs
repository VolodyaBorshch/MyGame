using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectible : MonoBehaviour
{
    private Outline outline;
    // Start is called before the first frame update
   
    private void OnEnable()
    {
        outline = GetComponent<Outline>();
        outline.OutlineWidth = 0;
    }
    // Update is called once per frame
    public void Select()
    {
        outline.OutlineWidth = 5;
    }
    public void UnSelect()
    {
        outline.OutlineWidth = 0;
    }
}
