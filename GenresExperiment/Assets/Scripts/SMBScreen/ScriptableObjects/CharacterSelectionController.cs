using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelectionController : MonoBehaviour
{
	public CharacterSO characterRef;

	[SerializeField] private Animator _characterAnim;
	[SerializeField] private TextMeshProUGUI _characterName, _powerOfAttack, _powerOfSpecial, _powerDefense;
	[SerializeField] private Image _characterIcon, _characterBackgroundImage;


	void Awake()
	{

	}


	void Update()
	{

	}
	public void ShowInfo()
	{
		if (characterRef.animController !=null)
		{
			characterRef.animController = _characterAnim;

		}
		_characterName.text = characterRef.characterName;
		_powerOfAttack.text = characterRef.powerOfAttack.ToString();
		_powerOfSpecial.text = characterRef.powerOfSpecial.ToString();
		_powerDefense.text = characterRef.powerDefense.ToString();
		_characterIcon.sprite = characterRef.characterIcon;
		_characterBackgroundImage.sprite = characterRef.characterBackgroundImage;
	}

}
