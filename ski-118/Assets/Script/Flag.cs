using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.Point += 10;

        MainUI.Instance.ShowNoticeText($"+10! Score: {player.Point}");
    }
}
