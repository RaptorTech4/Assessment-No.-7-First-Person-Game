using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{

    [SerializeField]
    IntObject PlayerScore;
    [SerializeField]
    stringObject PlayerName;
    [SerializeField]
    TMP_InputField PlayerNameInput;

    private Transform entryContainer;
    private Transform entryTemplate;

    private List<Transform> highscoreEntriesTransformList;

    private void Awake()
    {

        PlayerName.value = "";
        PlayerScore.value = 0;

        entryContainer = transform.Find("HighScoreContainer");
        entryTemplate = entryContainer.Find("HighScoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);


        //load save
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        var highscores = JsonUtility.FromJson<Highscore>(jsonString);

        if(highscores != null)
        {

            AddHighscoreEntry(0, "HHS");

            jsonString = PlayerPrefs.GetString("highscoreTable");
            highscores = JsonUtility.FromJson<Highscore>(jsonString);
        }
        
            //sorting 
            for (int i = 0; i < highscores.HSEntries.Count; i++)
            {
                for (int j = i + 1; j < highscores.HSEntries.Count; j++)
                {
                    if (highscores.HSEntries[j].score > highscores.HSEntries[i].score)
                    {
                        HighscoreEntry tmp = highscores.HSEntries[i];
                        highscores.HSEntries[i] = highscores.HSEntries[j];
                        highscores.HSEntries[j] = tmp;
                    }
                }
            }

            highscoreEntriesTransformList = new List<Transform>();
            foreach (HighscoreEntry item in highscores.HSEntries)
            {
                CreateHighscoreEntryTransform(item, entryContainer, highscoreEntriesTransformList);
            }
    }

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {

        float templateHeight = 50f;

        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();

        entryRectTransform.anchoredPosition = new Vector2(0f, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;

        string rankString;
        switch (rank)
        {
            case 1: rankString = "1ST"; break;
            case 2: rankString = "2NT"; break;
            case 3: rankString = "3RD"; break;
            default: rankString = rank + "TH"; break;
        }
        entryTransform.Find("posText").GetComponent<Text>().text = rankString;

        int score = highscoreEntry.score;
        entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString();

        string name = highscoreEntry.name;
        entryTransform.Find("nameText").GetComponent<Text>().text = name;

        transformList.Add(entryTransform);
    }

    public void SetPlayerName()
    {
        PlayerName.value = PlayerNameInput.text;
    }

    private void AddHighscoreEntry(int score, string name)
    {
        // Create HighscoreEntry
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };

        // Load saved Highscores
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscore highscores = JsonUtility.FromJson<Highscore>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            highscores = new Highscore()
            {
                HSEntries = new List<HighscoreEntry>()
            };
        }

        // Add new entry to Highscores
        highscores.HSEntries.Add(highscoreEntry);

        // Save updated Highscores
        string json = JsonUtility.ToJson(highscores,true);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    public void AddHighScoreEntry()
    {
        SetPlayerName();
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = PlayerScore.value, name = PlayerName.value };
        // load save
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscore highscores = JsonUtility.FromJson<Highscore>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            highscores = new Highscore()
            {
                HSEntries = new List<HighscoreEntry>()
            };
        }

        highscores.HSEntries.Add(highscoreEntry);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    private class Highscore
    {
        public List<HighscoreEntry> HSEntries;
    }

    [System.Serializable]
    private class HighscoreEntry
    {
        public int score;
        public string name;
    }

}
