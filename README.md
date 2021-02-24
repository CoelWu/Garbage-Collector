<p align="center">
    <img src="https://i.loli.net/2021/02/24/EzIOcftFVg6huXQ.png" align="center" height="80"/>
</p>

<div align="center">

# 垃圾回收 .NET SDK

[![Nuget](https://img.shields.io/nuget/v/CoelWu.Garbage.Collector)](https://www.nuget.org/packages/CoelWu.Garbage.Collector/)

该SDK在.NET Standard 2.0上构建

</div>

## 简单的开始

使用前，你需要先安装 **CoelWu.Garbage.Collector** nuget包

```csharp
// 创建实例
public GarbageCollector garbageCollector = new GarbageCollector();

protected override void OnStartup(StartupEventArgs e)
{
    // 开始收集清理 (默认30s执行一次)
    garbageCollector.StartCollecting();
    base.OnStartup(e);
}
```

## 图标版权

图标来自于Nhor Phai.

- [Nhor Phai](https://www.flaticon.com/authors/nhor-phai)
