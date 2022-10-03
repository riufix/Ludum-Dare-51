using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{

    [SerializeField] private float currentTime = 0f;
    private float startingTime = 10f;

    public float passifRange = 1.5f;
    
    public GameObject Player;
    public GameObject Assassin;
    public GameObject Bagarreur;
    public GameObject Chevalresse;
    void Start()
    {
        currentTime = startingTime;
        GameObject gameObject = Instantiate(Assassin);
        GameObject gameObject1 = Instantiate(Bagarreur);
        GameObject gameObject2 = Instantiate(Chevalresse);

        gameObject.GetComponent<Character>().enabled = false;
        gameObject1.GetComponent<Character>().enabled = false;
        gameObject2.GetComponent<Character>().enabled = false;

        this.Assassin.SetActive(true);
        this.Bagarreur.SetActive(true);
        this.Chevalresse.SetActive(true);

    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if(currentTime <= 0)
        {
            int num = Random.Range(1, 4);
            if(num == 1)
            {
                this.Assassin.GetComponent<Character>().enabled = true;
                this.Bagarreur.GetComponent<Character>().enabled = false;
                this.Chevalresse.GetComponent<Character>().enabled = false;
            }
            else if(num == 2)
            {
                this.Assassin.GetComponent<Character>().enabled = false;
                this.Bagarreur.GetComponent<Character>().enabled = true;
                this.Chevalresse.GetComponent<Character>().enabled = false;
            }
            else
            {
                this.Assassin.GetComponent<Character>().enabled = false;
                this.Bagarreur.GetComponent<Character>().enabled = false;
                this.Chevalresse.GetComponent<Character>().enabled = true;
            }
            currentTime = 10f;
            print(num);
        }
    }




}
