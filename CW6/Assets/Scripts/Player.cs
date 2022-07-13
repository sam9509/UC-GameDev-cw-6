using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public Image HealthBar;
    private float Health;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {

        
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Bullet")

        {
            Health -= 5f;
            HealthBar.fillAmount = Health / 100f;
            if (Health<=0)
                SceneManager.LoadScene("UI");

        }
    }


}
