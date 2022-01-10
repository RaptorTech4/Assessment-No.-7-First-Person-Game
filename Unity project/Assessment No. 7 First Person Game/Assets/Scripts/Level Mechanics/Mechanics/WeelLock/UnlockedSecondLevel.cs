using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedSecondLevel : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    [SerializeField]
    BoolObject PuzzleOneA;

    bool Puzzle1Update = false;

    private void Start()
    {
        Puzzle1Update = false;
        PuzzleOneA.value = false;
    }

    void Update()
    {
        if (PuzzleOneA.value == true)
        {
            if (!Puzzle1Update)
            {
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
