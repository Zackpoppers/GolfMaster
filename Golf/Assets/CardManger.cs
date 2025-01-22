using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManger : MonoBehaviour
{
    

    public Card card;

    public List<Card> deck = new List<Card>();

    public List<Card> disacrdPile = new List<Card>();

    public void Start()
    {

    }

    public void Update()
    {
        
    }

    public void ShuffleCard()
    {

    }

    public void Discard()
    {

    }

    public Card DrawFromDeck() 
    {
        return card;
    }
}
