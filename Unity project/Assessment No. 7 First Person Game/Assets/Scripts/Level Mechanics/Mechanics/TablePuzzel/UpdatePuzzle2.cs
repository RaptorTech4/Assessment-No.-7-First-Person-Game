using UnityEngine;

public class UpdatePuzzle2 : MonoBehaviour
{

    [SerializeField]
    Animator anim;

    [SerializeField]
    IntObject LevelPuzzleNumber;

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

    bool Puzzle2Update = false;

    void Start()
    {
        Puzzle2Update = false;

        PuzzleTwoA.value = false;
        PuzzleTwoB.value = false;
        PuzzleTwoC.value = false;
        PuzzleTwoD.value = false;
        PuzzleTwoE.value = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleTwoA.value == true && PuzzleTwoB.value == true && PuzzleTwoC.value == true && PuzzleTwoD.value == true && PuzzleTwoE.value == true)
        {
            if (!Puzzle2Update)
            {
                LevelPuzzleNumber.value = 3;
                Puzzle2Update = true;
                UpdetAnim();
            }
        }
    }

    void UpdetAnim()
    {
        anim.Play("TableDoorOpen");
    }

}
