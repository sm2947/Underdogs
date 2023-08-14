using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public enum LinkType
    {
        
        Red,
        Blue,
        Green,
        None
    }

    [SerializeField] private LinkType[] links = new LinkType[4];
    [SerializeField] private Sprite[] linkImages;
    [SerializeField] private GameObject[] cardLinks;
    [SerializeField] private bool resolveOrder;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 3; i++) //Assign the card links according to entered card data
        {
            if (links[i] != LinkType.None)
            {
                cardLinks[i].GetComponent<Image>().sprite = linkImages[i];
                cardLinks[i].SetActive(true);
            }
        }
            
    }

    public void Placed()
    {
        //Card has been placed, trigger the effect
    }
}
