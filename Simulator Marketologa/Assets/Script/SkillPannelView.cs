using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPannelView : MonoBehaviour
{
    [SerializeField] Text _titleText;
    [SerializeField] RectTransform _skillPointsContainer;
    [SerializeField] Button _addSkillButton;
    [Space]
    [SerializeField] string _title = "Title";
    [SerializeField] int _skillPoints = 0;
    [SerializeField] bool _canAddSkillPoints = false;


	private void OnValidate()
	{
        Title = _title;
        SkillPoints = _skillPoints;
        CanAddSkillPoints = _canAddSkillPoints;
	}

    public string Title
	{
        get => _title;
        set
		{
            _title = string.IsNullOrWhiteSpace(value) ? "<empty>" : value;

			_titleText.text = _title;

		}
	}

    
    public bool CanAddSkillPoints
	{
        get => _canAddSkillPoints;
        set
		{
            _canAddSkillPoints = value;
            _addSkillButton.interactable = value;
		}
	}

    public int SkillPoints
	{
        get => _skillPoints;
        set
		{
            value = Mathf.Clamp(value, 0, _skillPointsContainer.childCount);

			for (int i = 0; i < _skillPointsContainer.childCount; i++)
			{
                _skillPointsContainer.GetChild(i).gameObject.SetActive(value > i);
			}

            _skillPoints = value;
		}
	}
}
