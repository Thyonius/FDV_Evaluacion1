using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bones : MonoBehaviour
{
    public bool bigBone;     // Defines whether the bone is big or small.
    public int bigReward = 10;      // Defines the reward for big bones /by default 10).
    public int smallReward = 5;     // Defines the reward for small bones (by default 5).

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (bigBone == true)
            {
                ScoreManager.score += bigReward;
                Debug.Log(ScoreManager.score);
            }
            else if (bigBone == false)
            {
                ScoreManager.score += smallReward;
                Debug.Log(ScoreManager.score);
            }
        }
       
    }

}
