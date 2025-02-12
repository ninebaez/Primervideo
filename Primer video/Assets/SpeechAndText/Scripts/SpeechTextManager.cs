using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextSpeech;
using UnityEngine.Android;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using Unity.VisualScripting;

public class SpeechTextManager : MonoBehaviour
{

/*
   [SerializeField] private string language = "es-ES";
   [SerializeField] private Text uIText;

   [Serializable]
    public struct VoiceCommand

     {
        public string keyword;
        public UnityEvent Response;
     }

     public VoiceCommand[] VoiceCommands;

     private Dictionary<string, UnityEvent> commands = new Dictionary<string, UnityEvent>(); 

     private void Awake() 
     
     {
       #if UNITY_ANDROID
         
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
     {
       Permission.RequestUserPermission(Permission.Microphone);     
     }
       #endif
     }

     foreach ( var command in VoiceCommands)
     {
        commands.Add(command.keyword.ToLower(), command.Response);
     }

    // Start is called before the first frame update
    void Start()
    {
      TextToSpeech.Instance.Setting(language, 1,1);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    */
}
