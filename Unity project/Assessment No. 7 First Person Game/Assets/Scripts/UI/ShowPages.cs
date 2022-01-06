using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPages : MonoBehaviour
{

    // BoolObject
    [Header("Page Colection bool")]
    [SerializeField]
    BoolObject page1;
    [SerializeField]
    BoolObject page2;
    [SerializeField]
    BoolObject page3;

    //Page UI
    [Header("Page UI")]
    [SerializeField]
    Image page1UI;
    [SerializeField]
    Image page2UI;
    [SerializeField]
    Image page3UI;


    //Page Button
    [Header("Page Button UI")]
    [SerializeField]
    Button page1Button;
    [SerializeField]
    Button page2Button;
    [SerializeField]
    Button page3Button;

    void Start()
    {
        HideAllButtons();
        HideAllPages();
    }

    public void UpdateButtons()
    {
        page1Button.enabled = page1.value;
        page2Button.enabled = page2.value;
        page3Button.enabled = page3.value;
    }

    void HideAllPages()
    {
        page1UI.enabled = false;
        page2UI.enabled = false;
        page3UI.enabled = false;
    }

    void HideAllButtons()
    {
        page1Button.enabled = false;
        page2Button.enabled = false;
        page3Button.enabled = false;
    }

    public void TablePuzzle()
    {
        HideAllPages();
        page1UI.enabled = true;
    }

    public void OfficeTable()
    {
        HideAllPages();
        page1UI.enabled = true;
    }

    public void Door()
    {
        HideAllPages();
        page1UI.enabled = true;
    }

}
