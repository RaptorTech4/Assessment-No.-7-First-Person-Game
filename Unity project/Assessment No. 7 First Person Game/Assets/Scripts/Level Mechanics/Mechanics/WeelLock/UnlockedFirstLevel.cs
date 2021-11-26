using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedFirstLevel : MonoBehaviour
{

    [SerializeField]
    Animator anim;

    [SerializeField]
    IntObject LevelPuzzleNumber;

    [SerializeField]
    BoolObject PuzzleOneA;
    [SerializeField]
    BoolObject PuzzleOneB;

    bool Puzzle1Update = false;

    private void Start()
    {
        LevelPuzzleNumber.value = 1;

        Puzzle1Update = false;
        PuzzleOneA.value = false;
        PuzzleOneB.value = false;
    }

    void Update()
    {
        if (PuzzleOneA.value == true && PuzzleOneB.value == true)
        {
            if (!Puzzle1Update)
            {
                LevelPuzzleNumber.value = 2;
                Puzzle1Update = true;
                UpdateAnim();
            }
        }
    }

    void UpdateAnim()
    {
        anim.Play("FirePlaceDoors");
    }

}
