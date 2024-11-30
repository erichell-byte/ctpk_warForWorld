using UnityEngine;
using UnityEngine.Pool;

public class EnemyPool : MonoBehaviour
{
   private ObjectPool<Enemy> _pool;

   public EnemyPool()
   {
      _pool = new ObjectPool<Enemy>(Create, Get, Release, OnDestroyed);
   }

   private void OnDestroyed(Enemy obj)
   {
      throw new System.NotImplementedException();
   }

   //вернуть в пул неиспользуемые обьекты
   private void Release(Enemy obj)
   {
      throw new System.NotImplementedException();
   }

   private void Get(Enemy obj)
   {
      throw new System.NotImplementedException();
   }

   private Enemy Create()
   {
      throw new System.NotImplementedException();
   }
}


public class PrintSingleton
{
   private static PrintSingleton _instance;

   public static PrintSingleton Instance()
   {
      if (_instance == null)
      {
         _instance = new PrintSingleton();
         return _instance;
      } 
      
      return _instance;
   }
}
