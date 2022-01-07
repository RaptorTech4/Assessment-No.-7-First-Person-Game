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
        page1Button.gameObject.SetActive(page1.value);
        page2Button.gameObject.SetActive(page2.value);
        page3Button.gameObject.SetActive(page3.value);
    }

    void HideAllPages()
    {
        page1UI.gameObject.SetActive(false);
        page2UI.gameObject.SetActive(false);
        page3UI.gameObject.SetActive(false);
    }

    void HideAllButtons()
    {
        page1Button.gameObject.SetActive(false);
        page2Button.gameObject.SetActive(false);
        page3Button.gameObject.SetActive(false);
    }

    public void TablePuzzle()
    {
        HideAllPages();
        page1UI.gameObject.SetActive(true);
    }

    public void OfficeTable()
    {
        HideAllPages();
        page2UI.gameObject.SetActive(true);
    }

    public void Door()
    {
        HideAllPages();
        page3UI.gameObject.SetActive(true);
    }

}
