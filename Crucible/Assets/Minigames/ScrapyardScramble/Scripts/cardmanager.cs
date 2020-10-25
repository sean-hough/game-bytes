using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardmanager : MonoBehaviour
{
    public GameObject card;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(card, transform);
        Instantiate(card, transform);
        Instantiate(card, transform);
        Instantiate(card, transform);
        Instantiate(card, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
