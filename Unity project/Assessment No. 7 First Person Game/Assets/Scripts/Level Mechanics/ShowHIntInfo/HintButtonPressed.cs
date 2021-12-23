using UnityEngine;

public class HintButtonPressed : MonoBehaviour
{

    [SerializeField]
    FloatObject HintTimer;
    [SerializeField]
    IntObject CurrentPuzzelOn;
    [SerializeField]
    IntObject AmountOfHintsTaken;

    [SerializeField]
    GameObject HintPannelBoard;

    [Header("HintMaterials")]
    [SerializeField]
    Material defaltHintMat;
    [SerializeField]
    Material FirsHintMat;
    [SerializeField]
    Material SecondHintMat;
    [SerializeField]
    Material ThirdHintMat;
    [SerializeField]
    Material FourthHintMat;

    int lastPuzzleButtenPresed = 0;

    void Start()
    {
        AmountOfHintsTaken.value = 1;
        lastPuzzleButtenPresed = 0;
        if (HintPannelBoard != null)
        {
            HintPannelBoard.GetComponent<Renderer>().material = defaltHintMat;
        }
    }

    public void ShowHint()
    {
        if (HintTimer.value <= 0f)
        {
            if (lastPuzzleButtenPresed <= AmountOfHintsTaken.value)
            {
                AmountOfHintsTaken.value++;
                HintMaterials();
            }
        }
    }

    void HintMaterials()
    {
        if (HintPannelBoard != null)
        {
            switch (CurrentPuzzelOn.value)
            {
                case 1:
                    HintPannelBoard.GetComponent<Renderer>().material = FirsHintMat;
                    lastPuzzleButtenPresed = 1;
                    break;
                case 2:
                    HintPannelBoard.GetComponent<Renderer>().material = SecondHintMat;
                    lastPuzzleButtenPresed = 2;
                    break;
                case 3:
                    HintPannelBoard.GetComponent<Renderer>().material = ThirdHintMat;
                    lastPuzzleButtenPresed = 3;
                    break;
                case 4:
                    HintPannelBoard.GetComponent<Renderer>().material = FourthHintMat;
                    lastPuzzleButtenPresed = 4;
                    break;
                default:
                    HintPannelBoard.GetComponent<Renderer>().material = defaltHintMat;
                    break;
            }
        }
    }

}
