using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

public class SpotifySDK : MonoBehaviour
{
      private static SpotifyWebAPI _spotify;

    void Start()
    {
        _spotify = new SpotifyWebAPI()
    {
        AccessToken = "BQDYUD7CcvAFskTY_YmC8UqHJTQAwBOUn81wxHuoInRTXm4k8bHyc7lpPGx9UeKedn7bs56sqebgZezIp5o",
        TokenType = "Bearer"
    };
    AudioAnalysis  analysis  = _spotify.GetAudioAnalysis("3Hvu1pq89D4R0lyPBoujSv");
  
    Debug.Log(analysis.Bars.Count.ToString()); //Yeay! We just printed a tracks name.
    Debug.Log(analysis.Beats.Count.ToString()); //Yeay! We just printed a tracks name.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
