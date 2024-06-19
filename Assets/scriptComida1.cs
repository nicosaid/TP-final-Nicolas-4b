using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class scriptComida1 : MonoBehaviour
{
    public GameObject[] comida1;
    int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (currentIndex < comida1.Length)
            {
                currentIndex++;
            }

            else
            {
                currentIndex = comida1.Length - 1;
            }
            deacivateAll();
            comida1[currentIndex].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }

            else
            {
                currentIndex = 0;
            }
            deacivateAll();
            comida1[currentIndex].SetActive(true);
        }
        void deacivateAll()
        {
            for (int i = 0; i < comida1.Length; i++)
            {
                comida1[i].SetActive(false);
            }
        }
    }
}
