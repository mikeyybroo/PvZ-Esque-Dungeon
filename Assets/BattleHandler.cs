using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform Player1CharacterBattle;
    private void Start() {
        SpawnCharacter(true);
        SpawnCharacter(false);
    }
        private void SpawnCharacter(bool isPlayerTeam)
        {
            Vector3 position;
            if (isPlayerTeam)
            {
                position = new Vector3(-5, 0);
            } else
            {
                position = new Vector3(+5, 0);
            }
            Instantiate(Player1CharacterBattle, position, Quaternion.identity);
        }

    }
