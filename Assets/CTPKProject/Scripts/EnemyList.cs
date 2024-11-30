using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : ScriptableObject, IEnumerable<Enemy>
{
    [SerializeField] private Enemy[] _list;
    public IEnumerator<Enemy> GetEnumerator()
    {
        return new EnemyDeck(_list);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class EnemyDeck : IEnumerator<Enemy>
{
    private readonly Enemy[] _array;
    private Enemy _current;
    private int _index = -1;
    
    public Enemy Current { get; }
    object IEnumerator.Current => _current;

    public EnemyDeck(Enemy[] array)
    {
        _array = array;
    }
    
    public bool MoveNext()
    {
        throw new System.NotImplementedException();
    }

    public void Reset()
    {
        throw new System.NotImplementedException();
    }

    

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }
}