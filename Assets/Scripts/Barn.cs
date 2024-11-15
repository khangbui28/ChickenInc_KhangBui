using UnityEngine;

public class Barn : MonoBehaviour
{
    public static Barn chickenBarn;

    private void Awake()
    {
       

        chickenBarn = this;
    }

   
}
