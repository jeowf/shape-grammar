using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : MonoBehaviour
{

    public GameObject rule;

    void Start()
    {
        //Debug.Log(name);

        if (rule != null)
        {
            GameObject obj = nextRule(rule);
            if (obj != null)
            {
                GameObject next = Instantiate(obj) as GameObject;
                next.transform.parent = transform;
                resetTransform(next);
            }
            
        }
        
        


    }


    public GameObject nextRule(GameObject rule)
    {
        
        List<GameObject> rules = new List<GameObject>();
        foreach (Transform t in rule.transform)
        {
            rules.Add(t.gameObject);
        }
        if (rules.Count > 0)
            return rules[Random.Range(0, rules.Count)];
        return null;

    }

    public void resetTransform(GameObject obj)
    {
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one;
    }


}
