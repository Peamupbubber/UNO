using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNORunnerTemp : MonoBehaviour
{
     public GameObject m_card;

    void Start()
    {
        var card = Instantiate(m_card);
        card.GetComponent<Card>().CreateCard("Temp", 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
