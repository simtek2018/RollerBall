using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    private int coins = 0;
    [SerializeField] Text displayScore;

    private void Awake() {
        if (gm == null) {
            gm = this;
        }
    }

    public void Loot(int amount) {
        coins += amount;
        displayScore.text = coins.ToString();
    }
}
