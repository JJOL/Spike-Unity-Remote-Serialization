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

        Debug.Log("Testing SpotifyWebAPI Client...");

        _spotify = new SpotifyWebAPI()
        {
            AccessToken = "BQCbA3-36RXsmkIW9OHVoCjRHrYyCIqTxIQR9E_If3NPw_McHQaFykPSOOEdDa5wjX-9dKIrdZ6SFwD3PDg",
            TokenType = "Bearer"
        };
        Debug.Log("SpotifyWebInstance() successfully created and connected!");

        AudioAnalysis analysis  = _spotify.GetAudioAnalysis("3Hvu1pq89D4R0lyPBoujSv");
        if (analysis == null || analysis.Bars == null)
        {
            Debug.Log("NO AnalysisResults RETURNED!");
            return;
        }
        Debug.Log("AnalysisResults succesfully loaded!");

        Debug.Log("Bars: " + analysis.Bars.Count.ToString()); //Yeay! We just printed a tracks name.
        Debug.Log("Beats: " + analysis.Beats.Count.ToString()); //Yeay! We just printed a tracks name.

        Debug.Log("Prueba Concluida con Exito!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
