using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NarrativeManager : MonoBehaviour
{
    private List<Conversation> _conversations = new List<Conversation>();
    private List<Narrative> _narratives = new List<Narrative>();
    // Start is called before the first frame update
         void Start()
         {
             
         }
     
         // Update is called once per frame
         void Update()
         {
             
         }

    private void OnEnable()
    {
        EventManager.StartListening("FoundCoins", ShowText);
    }

    private void OnDisable()
    {
        EventManager.StopListening("FoundCoins", ShowText);
    }

    private void ShowText() {
    }
}
