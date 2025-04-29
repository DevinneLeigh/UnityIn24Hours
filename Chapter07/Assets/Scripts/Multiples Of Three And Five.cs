using UnityEngine;

public class MultiplesOfThreeAndFive: MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                print("Programming is awesome!" );
            }
            else
            {
                print(i);
            }
        }
    }
    
}
