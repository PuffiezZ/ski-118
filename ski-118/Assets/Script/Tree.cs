using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;
    private void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();
        player.HP -= 1;

        MainUI.Instance.ShowNoticeText($"Ouch! hp left {player.HP}");

        if(player.HP <= 0)
        {
            MainUI.Instance.ShowNoticeText("You are dead!");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(104,79,41,255);
    }
}
