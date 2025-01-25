using UnityEngine;
using Zenject;
using static Zenject.CheatSheet;

public class StorageInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Storage>().AsSingle();
    }
}