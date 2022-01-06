using TMPro;
using UnityEngine;

public class GenerateFinalScore : MonoBehaviour
{

    [SerializeField]
    FloatObject timeRemaining;
    [SerializeField]
    IntObject AmountOfHintsTamen;
    [SerializeField]
    IntObject finalScore;

    [SerializeField]
    BoolObject playerWin;
    [SerializeField]
    BoolObject playerLost;

    [SerializeField]
    TMP_Text ScoreTextOnWinScrean;

    bool jenerateScore = false;

    void Start()
    {
        finalScore.value = 0;
        jenerateScore = false;
    }

    void Update()
    {
        if (playerLost.value || playerWin.value)
        {
            if (!jenerateScore)
            {
                SetScore();
                jenerateScore = true;
            }
        }
    }

    void SetScore()
    {
        int myInt = Mathf.FloorToInt((timeRemaining.value * 100) / AmountOfHintsTamen.value);
        finalScore.value = myInt;
        ScoreTextOnWinScrean.text = myInt.ToString();
        jenerateScore = false;
    }
}
