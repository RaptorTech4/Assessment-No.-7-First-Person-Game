using UnityEngine;

public class LockControl : MonoBehaviour
{
    [Header("Wheel Codes")]
    [SerializeField]
    IntObject Wheel1;
    [SerializeField]
    IntObject  Wheel2;
    [SerializeField]
    IntObject  Wheel3;
    [SerializeField]
    IntObject  Wheel4;
    [Header("Wheel Value Changed?")]
    [SerializeField]
    BoolObject valueChanged;
    [Header("Final Code")]
    [SerializeField]
    private int[] currectCombination;

    [SerializeField]
    BoolObject PuzzleCompleet;

    private int[] result;


    private void Start()
    {
        result = new int[] { Wheel1.value, Wheel2.value, Wheel3.value, Wheel4.value };

    }

    private void Update()
    {
        if (valueChanged.value)
        {

            result[0] = Wheel1.value;
            result[1] = Wheel2.value;
            result[2] = Wheel3.value;
            result[3] = Wheel4.value;

            if (result[0] == currectCombination[0] && result[1] == currectCombination[1] && result[2] == currectCombination[2] && result[3] == currectCombination[3])
            {
                PuzzleCompleet.value = true;
            }
            else
            {
                PuzzleCompleet.value = false;
            }
            valueChanged.value = false;
        }
    }
}
