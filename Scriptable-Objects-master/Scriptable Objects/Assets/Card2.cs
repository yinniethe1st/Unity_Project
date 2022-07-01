using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Name", menuName = "New Card")]
public class Card2 : ScriptableObject
{
   public new string cardName;
   public string cardDescription;

   public Sprite cardArtWork;

   public int manaCardCost;
   public int cardAttack;
   public int cardHealth;

   
	public void Print ()
	{
		Debug.Log(cardName + ": " + cardDescription + " The card costs: " + manaCardCost);
	}

}
