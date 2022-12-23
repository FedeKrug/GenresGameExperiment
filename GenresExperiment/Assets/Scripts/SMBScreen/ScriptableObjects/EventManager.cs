using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Game.Events;
using UnityEngine.UI;
using System;

namespace Game.Events
{
	public class SelectionCharacter : UnityEvent <CharacterSO>{ }

}

public class EventManager : MonoBehaviour
{
	public static EventManager instance;

	//public Action <CharacterSO, Animator, Text, Text, Text, Text, Text, Image>SelectionCharacterAction; 

	private void Awake()
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
