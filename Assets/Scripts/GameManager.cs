using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    private int coins = 0;
    [SerializeField] Text displayScore;
    public GameObject mainCanvas;
    public GameObject endGameCanvas;
    public Text endGameScore;
    private Health health;
    private GameObject player;

    private void Awake() {
        if (gm == null) {
            gm = this;
        }
    }

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) {
            health = player.GetComponent<Health>();
        }
        mainCanvas.SetActive(true);
        endGameCanvas.SetActive(false);
    }

    private void Update() {
        if (health.hitpoints <= 0) {
            endGameScore.text = coins.ToString();
            mainCanvas.SetActive(false);
            endGameCanvas.SetActive(true);
        }
    }

    public void Loot(int amount) {
        coins += amount;
        displayScore.text = coins.ToString();
    }
}
