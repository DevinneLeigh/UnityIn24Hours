using UnityEngine;

public class AddEvenNumbers: MonoBehaviour
{
    void Start()
    {
        int i = 0;
        int x = 0;
        while (i <= 499)
        {
            i = i + 2;
            x = x + i; 
        }  
        print(x);
    }
}


