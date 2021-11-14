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
            jenerateScore = true;
            SetScore();
        }
    }

    void SetScore()
    {
        if (jenerateScore)
        {
            int myInt = Mathf.FloorToInt((timeRemaining.value * 100) / AmountOfHintsTamen.value);
            finalScore.value = myInt;
            jenerateScore = false;
        }
    }
}
