using UnityEngine;

public class LevelProgression : MonoBehaviour
{
    [SerializeField]
    IntObject LevelPuzzleNumber;

    #region Puzzle One
    [Header("Puzzle one Var")]
    [SerializeField]
    BoolObject PuzzleOneA;
    [SerializeField]
    BoolObject PuzzleOneB;
    #endregion Puzzle One

    #region Puzzle Two
    [Header("Puzzle two Var")]
    [SerializeField]
    BoolObject PuzzleTwoA;
    [SerializeField]
    BoolObject PuzzleTwoB;
    [SerializeField]
    BoolObject PuzzleTwoC;
    [SerializeField]
    BoolObject PuzzleTwoD;
    [SerializeField]
    BoolObject PuzzleTwoE;
    #endregion Puzzle Two

    #region Puzzle Three
    [Header("Puzzle three Var")]
    [SerializeField]
    BoolObject PuzzleThreeA;
    #endregion Puzzle Three

    bool Puzzle1Update = false;
    bool Puzzle2Update = false;
    bool Puzzle3Update = false;

    void Start()
    {
        LevelPuzzleNumber.value = 1;

        Puzzle1Update = false;
        Puzzle2Update = false;
        Puzzle3Update = false;
    }

    void Update()
    {
        if (PuzzleOneA.value == true && PuzzleOneB.value == true)
        {
            if (!Puzzle1Update)
            {
                LevelPuzzleNumber.value = 2;
                Puzzle1Update = true;
            }
        }

        if (PuzzleTwoA.value == true && PuzzleTwoB.value == true && PuzzleTwoC.value == true && PuzzleTwoD.value == true && PuzzleTwoE.value == true)
        {
            if (!Puzzle2Update)
            {
                LevelPuzzleNumber.value = 3;
                Puzzle2Update = true;
            }
        }

        if (PuzzleThreeA.value == true)
        {
            if (!Puzzle3Update)
            {
                LevelPuzzleNumber.value = 4;
                Puzzle3Update = true;
            }
        }

    }
}
