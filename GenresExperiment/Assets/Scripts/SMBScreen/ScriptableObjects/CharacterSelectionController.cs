using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterSelectionController : MonoBehaviour
{
	public CharacterSO characterRef;

	[SerializeField] private Animator _characterAnim;
	[SerializeField] private Text _characterName, _powerOfAttack, _powerOfSpecial, _powerDefense;
	[SerializeField] private Image _characterIcon;


	void Awake()
	{

	}


	void Update()
	{

	}
	public void ShowInfo()
	{
		characterRef.animController = _characterAnim;
		characterRef.characterName = _characterName.text;
		_powerOfAttack.text = characterRef.powerOfAttack.ToString();
		_powerOfSpecial.text = characterRef.powerOfSpecial.ToString();
		_powerDefense.text = characterRef.powerDefense.ToString();
		characterRef.characterIcon = _characterIcon.sprite;
	}

}
