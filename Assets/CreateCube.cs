using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateCube : MonoBehaviour

{    
    public GameObject cube; 
    public InputField InputField; 
    public Button Button;
    public Canvas Canvas;
    private int ballCount;
    void Start()
    {
        Time.timeScale = 0;
    }

    private int RandomNumber() {
        return Random.Range(-45, 45);
    }

    public void Create(){
        if (InputField.text != null) ballCount = int.Parse(InputField.text);
        for(int i = 0; i < ballCount; i++)
        Instantiate(cube, new Vector3(RandomNumber(), 1, RandomNumber()), Quaternion.Euler(0, 0, 0)); 

        Canvas.enabled = false;

        Time.timeScale = 1;
    }
}
