using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayersNames : MonoBehaviour
{
    public TextMeshProUGUI player;
    public TextMeshProUGUI enemy;

    // Start is called before the first frame update
    void Start()
    {
        SaveController saveController = SaveController.Instance;
        player.text = saveController.namePlayer;
        enemy.text = saveController.nameEnemy;
    }

}
