using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int playerHealth1;
    public int playerHealth2;
    public Image hpBar1;
    public Image hpBar2;
    public void DamagePlayer(int playerID, int value)
    {
        if (playerID == 1)
        {
            ReduceHP(ref playerHealth1,ref hpBar1, value);
        }
        if (playerID == 2)
        {
            ReduceHP(ref playerHealth2,ref hpBar2, value);
        }

    }

    void ReduceHP(ref int health,ref Image bar, int value)
    {
        health -= value;
        health= Mathf.Clamp(health, 0, 100);
        bar.fillAmount = (float)health / 100;
        if (health <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
