using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Character
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //�ѹ�����¹������� player ��µ͹ⴹ ant ����Ѻ
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }

    
}

