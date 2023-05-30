using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public enum TargetPlayer{
        player1=1,player2=2 
    }
    public TargetPlayer target;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (target == TargetPlayer.player1)
            GetComponent<MeshRenderer>().material.color = Color.red;
        if (target == TargetPlayer.player2)
            GetComponent<MeshRenderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().DamagePlayer((int)target , damage);
            Destroy(gameObject);
        }
    }
}
