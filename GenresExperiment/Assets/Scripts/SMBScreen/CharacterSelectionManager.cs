using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionManager : MonoBehaviour
{
    public static CharacterSelectionManager instance;
    void Awake()
    {
        if (!instance)
		{
            instance = this;
		}
        else
		{
            Destroy(gameObject);
		}


    }

	

	
}
//[SerializeField] private Animator _characterAnim;
//[SerializeField] private Text _characterName, _powerOfAttack, _powerOfSpecial, _powerDefense;
//[SerializeField] private Image _characterIcon;
