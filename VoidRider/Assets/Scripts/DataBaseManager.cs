using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using UnityEngine.UI;
using TMPro;

public class DataBaseManager : MonoBehaviour
{
    public TextMeshProUGUI name;
    public float time;
    public TimerGame timer;
    FirebaseApp app;

    private string RankingID;
    private DatabaseReference dbReference;
    [System.Serializable]

    public class Player
    {
        public string key;
        public string value;

        // Constructor to set the values
        public Player(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                app = Firebase.FirebaseApp.DefaultInstance;

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void CreateRanking()
    {
        timer = FindObjectOfType<TimerGame>();
        time = timer.timeToKeep;

        Player newPlayer = new Player(name.text, time.ToString());

        // Generate a unique key for each new entry
        string newEntryKey = dbReference.Child("Ranking").Push().Key;

        // Set the new player data under the generated key
        string json = JsonUtility.ToJson(newPlayer);
        dbReference.Child("Ranking").Child(newEntryKey).SetRawJsonValueAsync(json);
    }


    public void pruevaDb()
    {
        Ranking newRanking = new Ranking("charpruv", 15);
        string json = JsonUtility.ToJson(newRanking);

        dbReference.Child("Ranking").Child(RankingID).SetRawJsonValueAsync(json);
    }
}
