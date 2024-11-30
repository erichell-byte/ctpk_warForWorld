using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaver<T>
{
    public void Save(T amount);

    public T Load();
}
