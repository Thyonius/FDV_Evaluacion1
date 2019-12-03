using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject HUD;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HUD.SetActive(true);
    }
}
