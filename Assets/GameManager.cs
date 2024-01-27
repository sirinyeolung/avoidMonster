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
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(monster,pos,Quaternion.identity);
        
    }

    
}
