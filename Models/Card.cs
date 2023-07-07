using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
  public int id;
  public string cardName;
  public int power;
  public int defense;
  public string cardType;
  public string cardDescription;


  public Card()
  {

  }

  public Card(int Id, string CardName, int Power, int Defense, string CardType, string CardDescription)
  {
    id = Id;
    cardName = CardName;
    power = Power;
    defense = Defense;
    cardType = CardType;
    cardDescription = CardDescription;
  }

}