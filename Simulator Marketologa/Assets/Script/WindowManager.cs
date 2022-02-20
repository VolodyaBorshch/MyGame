using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class WindowManager : MonoBehaviour
{
    [SerializeField] List<GameObject> _windows;

	private void Awake()
	{
		_windows = FindObjectsOfType<Window>(true)
			.Select(x => x.gameObject)
			.ToList();
	}

	public void OpenWindow(GameObject window)
	{
		foreach (var item in _windows)
		{
			var reslut = ReferenceEquals(item, window);
			item.SetActive(reslut);
		}
	}
}
