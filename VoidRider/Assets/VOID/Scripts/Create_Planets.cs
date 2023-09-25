using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Planets : MonoBehaviour
{
    [SerializeField] private GameObject planet;
    [SerializeField] private float radio;
    [SerializeField] private List<GameObject> planets;
    [SerializeField] private List<Material> color;
    
    
    void Start()
    {
        float total = Random.Range(800, 1000);
        
        for (int i = 0; i <= total; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-8000, 8000), Random.Range(-8000,8000), Random.Range(-8000,8000));

            if (IsPositionEmpty(randomPos))
            {
                GameObject newInst = Instantiate(planet, randomPos, Quaternion.identity);
                newInst.transform.localScale = Vector3.one * Random.Range(10, 100);
                Material plat = color[Random.Range(0, color.Count)];
                Material mate = newInst.GetComponent<Material>();
                mate = plat;
                planets.Add(newInst);
            }
            
        }
    }

    bool IsPositionEmpty(Vector3 position)
    {
        foreach (var plan in planets)
        {
            if (Vector3.Distance(position, plan.transform.position) < radio)
            {
                return false;
            }
        }

        return true;
    }


}
