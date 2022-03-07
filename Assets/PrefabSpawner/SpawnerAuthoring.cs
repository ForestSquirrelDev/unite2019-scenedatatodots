using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SpawnerAuthoring : MonoBehaviour, IDeclareReferencedPrefabs
{
    public PrefabListAuthoring PrefabList;
    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
        => referencedPrefabs.Add(PrefabList.gameObject);
}
