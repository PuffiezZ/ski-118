using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField] TMP_Text noticeText;
    public static MainUI Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void ShowNoticeText(string s)
    {
        noticeText.text = s;
    }
}
