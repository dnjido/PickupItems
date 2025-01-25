using UnityEngine;
using Zenject;

public class ControllerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Viewing>().FromComponentInHierarchy().AsSingle();
    }
}