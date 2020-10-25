using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour{
    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Text typeText;

    public Image artworkImage;

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        typeText.text = card.type;
        artworkImage.sprite = card.artwork;

    }

}
