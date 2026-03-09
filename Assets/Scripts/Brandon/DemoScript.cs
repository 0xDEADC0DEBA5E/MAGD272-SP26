using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int a;
    public int b;
    
    public int addNumbers ( int a, int b ) 
    {
        return a + b;
    }
    
    public int subNumbers ( int a, int b ) 
    {
        return a - b;
    }
    
    public int mulNumbers ( int a, int b ) 
    {
        return a * b;
    }
}
