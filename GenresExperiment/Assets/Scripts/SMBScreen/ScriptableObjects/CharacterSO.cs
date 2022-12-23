using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Character", menuName ="ScriptableObject/SMBScreen/Character")]
public class CharacterSO : ScriptableObject
{
	public Animator animController;
	public string characterName;
	public int powerOfAttack, powerOfSpecial, powerDefense;
	public Sprite characterIcon, characterBackgroundImage;

}
