using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Data
{
    public int[] data;

    public Data(int[] data)
    {
        this.data = data;
    }
}

public class Collector : MonoBehaviour
{
    public List<int> values = new List<int> { };

    private RequestHelper requestHelper = new RequestHelper();

    public void AddValue(int value)
    {
        values.Add(value);
    }

    private void OnDestroy()
    {
        requestHelper.Post("http://localhost:3000/data", new Data(values.ToArray()));
    }
}

