using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameWithKeypad : MonoBehaviour
{

    [SerializeField]
    BoolObject DpadUnlockLock;
    [SerializeField]
    BoolObject WinGame;

    private void Update()
    {
        if(DpadUnlockLock.value == true)
        {
            WinGame.value = true;
        }
    }

}
