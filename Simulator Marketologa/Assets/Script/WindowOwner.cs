using UnityEngine;

public class WindowOwner : MonoBehaviour
{
    [SerializeField] GameObject window;

    WindowManager manager;


	private void Awake()
	{
        manager = FindObjectOfType<WindowManager>();
	}

	private void OnMouseDown()
	{
        manager.OpenWindow(window);
	}
}
