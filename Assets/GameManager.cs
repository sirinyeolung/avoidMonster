using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject monster;

    void Start()
    {
        StartCoroutine(CreateMonsterRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator CreateMonsterRoutine()
    {
        while (true)
        {
            CreateMonster();
            yield return new WaitForSeconds(1);
        }
        
    }

    private void CreateMonster()
    {
        Vector3 pos = new Vector3(0, 6, 0);
        Instantiate(monster,pos,Quaternion.identity);
    }
}
