using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay2 : MonoBehaviour
{
   	public Card newcard;

	public Text newnameText;
	public Text newdescriptionText;

	public Image newartworkImage;

	public Text newmanaText;
	public Text newattackText;
	public Text newhealthText;

	// Use this for initialization
	void Start () {
		newnameText.text = newcard.name;
		newdescriptionText.text = newcard.description;

		newartworkImage.sprite = newcard.artwork;

		newmanaText.text = newcard.manaCost.ToString();
		newattackText.text = newcard.attack.ToString();
		newhealthText.text = newcard.health.ToString();
	}
	
}

}
